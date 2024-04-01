using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.consulta6
{
    public partial class consulta6 : Form
    {
        public consulta6()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();
        private void consulta6_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarUsuarioBss();
        }
    }
}
