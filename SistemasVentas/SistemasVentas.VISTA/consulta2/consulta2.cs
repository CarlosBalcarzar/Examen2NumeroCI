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

namespace SistemasVentas.VISTA.consulta2
{
    public partial class consulta2 : Form
    {
        public consulta2()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void consulta2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveedorBss();
        }
    }
}
