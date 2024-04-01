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

namespace SistemasVentas.VISTA.consulta10
{
    public partial class consulta10 : Form
    {
        public consulta10()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void consulta10_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentaBss();
        }
    }
}
