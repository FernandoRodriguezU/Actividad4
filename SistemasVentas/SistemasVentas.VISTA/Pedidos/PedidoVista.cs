using SistemasVentas.BSS;
using SistemasVentas.DAL;
using SistemasVentas.VISTA.Cliente;
using SistemaVentas.Modelos;
using SistemaVentasBss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.Pedidos
{
    public partial class PedidoVista : Form
    {
        public PedidoVista()
        {
            InitializeComponent();
        }
        PedidoBss bss = new PedidoBss();
        ClienteBss bssuser = new ClienteBss();
        public static int IdClienteSeleccionada = 0;
        private void PedidoVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPedidoBss();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido u = new Pedido();
            u.IdCliente = IdClienteSeleccionada;
            u.Total = Convert.ToDecimal(textBox2.Text);
            u.Fecha = dateTimePicker1.Value;

            bss.InsertarPedidoBss(u);
            MessageBox.Show("Se guardó correctamente");

            dataGridView1.DataSource = bss.ListarPedidoBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdPedidoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Pedido editarPedido = bss.ObtenerPedidoIdBss(IdPedidoSeleccionada);
            editarPedido.IdCliente = IdClienteSeleccionada;
            editarPedido.Fecha = dateTimePicker1.Value;
            editarPedido.Total = Convert.ToDecimal(textBox2.Text);
            bss.EditarPedidoBss(editarPedido);
            MessageBox.Show("Datos Actualizados");

            dataGridView1.DataSource = bss.ListarPedidoBss();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdPedidoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que lo desea eliminar?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarPedidoBss(IdPedidoSeleccionada);
                dataGridView1.DataSource = bss.ListarPedidoBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
