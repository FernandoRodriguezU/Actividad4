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

namespace SistemasVentas.VISTA.Cliente
{
    public partial class ClienteVista : Form
    {
        public ClienteVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();

        private void ClienteVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss();
        }
    }
}
