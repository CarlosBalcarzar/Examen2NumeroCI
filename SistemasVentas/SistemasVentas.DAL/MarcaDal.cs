using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class MarcaDal
    {
        public DataTable ListarMarcaDal()
        {
            string consulta = "SELECT MARCA.IDMARCA, MARCA.NOMBRE AS NOMBRE_DE_LA_MARCA, SUM(DETALLEVENTA.CANTIDAD) AS CANTIDAD_TOTAL_VENDIDA\r\nFROM MARCA\r\nINNER JOIN PRODUCTO ON MARCA.IDMARCA = PRODUCTO.IDMARCA\r\nINNER JOIN DETALLEVENTA ON PRODUCTO.IDPRODUCTO = DETALLEVENTA.IDPRODUCTO\r\nGROUP BY MARCA.IDMARCA, MARCA.NOMBRE\r\nORDER BY CANTIDAD_TOTAL_VENDIDA DESC;\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarMarcaDal(Marca marca)
        {
            string consulta = "insert into marca values ('"+ marca.Nombre + "', " 
                                                           + "'" +marca.Estado + "')";
            conexion.Ejecutar(consulta);
        }
        Marca p = new Marca();
        public Marca ObtenerMarcaIdDal(int id)
        {
            string consulta = "select * from marca where idmarca=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarMarcaDal(Marca p)
        {
            string consulta = "update marca set nombre='" + p.Nombre + "'," +
                                                        "estado='" + p.Estado + "' " +
                                                "where idmarca=" + p.IdMarca;
            conexion.Ejecutar(consulta);
        }
        public void EliminarMarcaDal(int id)
        {
            string consulta = "delete from marca where idmarca=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
