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

namespace SistemasVentas.VISTA.consulta5
{
    public partial class consulta5 : Form
    {
        public consulta5()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void consulta5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductoBss2();
        }
    }
}
