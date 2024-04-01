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

namespace SistemasVentas.VISTA.consulta9
{
    public partial class consulta9 : Form
    {
        public consulta9()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();
        private void consulta9_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarTipoProdBss();
        }
    }
}
