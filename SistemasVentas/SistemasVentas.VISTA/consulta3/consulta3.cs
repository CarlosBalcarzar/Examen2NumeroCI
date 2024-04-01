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

namespace SistemasVentas.VISTA.consulta3
{
    public partial class consulta3 : Form
    {
        public consulta3()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void consulta3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarMarcaBss();
        }
    }
}
