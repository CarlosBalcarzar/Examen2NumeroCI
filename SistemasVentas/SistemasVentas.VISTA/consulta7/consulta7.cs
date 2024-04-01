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

namespace SistemasVentas.VISTA.consulta7
{
    public partial class consulta7 : Form
    {
        public consulta7()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void consulta7_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss2();
        }
    }
}
