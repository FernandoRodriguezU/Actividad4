using SistemasVentas.DAL;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasDal
{
    public class PedidoDal
    {

        public DataTable ListarPedidoDal()
        {
            string consulta = "select * from pedido";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarPedidoDal(Pedido p)
        {
            string consulta = "INSERT INTO PEDIDO VALUES (" + p.IdCliente + " , " +
                                                            " '" + p.Fecha + "' , " +
                                                            " '" + p.Total + "'," +
                                                          "'Completado')";
            conexion.Ejecutar(consulta);
        }
        public Pedido ObtenerPedidoIdDal(int id)
        {
            string consulta = "select * from pedido where idpedido=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Pedido u = new Pedido();
            if (tabla.Rows.Count > 0)
            {
                u.IdPedido = Convert.ToInt32(tabla.Rows[0]["idpedido"]);
                u.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                u.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
                u.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return u;

        }
        public void EditarPedidoDal(Pedido p)
        {
            string consulta = "UPDATE PEDIDO SET IDCLIENTE = " + p.IdCliente + "," +
                                      "FECHA = '" + p.Fecha + "'," +
                                      "TOTAL = " + p.Total + "," +
                                      "ESTADO = 'Completado' " +
                                      "WHERE IDPEDIDO = " + p.IdPedido;


            conexion.Ejecutar(consulta);
        }
        public void EliminarPedidoDal(int id)
        {
            string consulta = "delete from pedido where idpedido=" + id;
            conexion.Ejecutar(consulta);
        }


    }
}
