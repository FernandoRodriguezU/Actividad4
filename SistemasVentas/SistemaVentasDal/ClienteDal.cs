using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ClienteDal
    {
        public DataTable LIstarClienteDal()
        {
            string consulta = "select * from cliente";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;

        }
        public void InsertarClienteDAL(Cliente c)
        {
            string consulta = "insert into cliente values('" + c.Nombre + "'," +
                                                          "'" + c.Apellido + "'," +
                                                          "'" + c.Telefono + "'," +
                                                          "'" + c.CorreoElectronico + "'," +
                                                          "'" + c.Direccion + "')";
            conexion.Ejecutar(consulta);
        }
        public Cliente ObtenerClienteIdDal(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Cliente p = new Cliente();
            if (tabla.Rows.Count > 0)
            {
                p.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Apellido = tabla.Rows[0]["apellido"].ToString();
                p.Telefono = tabla.Rows[0]["telefono"].ToString();
                p.CorreoElectronico = tabla.Rows[0]["correoelectronico"].ToString();
                p.Direccion = tabla.Rows[0]["direccion"].ToString();
            }
            return p;

        }
        public void EditarClienteDal(Cliente c)
        {
            string consulta = "update cliente set nombre='" + c.Nombre + "'," +
                                                        "apellido='" + c.Apellido + "'," +
                                                        "telefono='" + c.Telefono + "'," +
                                                        "correoelectronico='" + c.CorreoElectronico + "'," +
                                                        "direccion='" + c.Direccion + "' " +
                                                        "where idcliente=" + c.IdCliente;
            conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente=" + id;
            conexion.Ejecutar(consulta);
        }
        public DataTable ClienteDatosDal(int id)
        {
            string consulta = " SELECT COUNT(*) AS TotalPedidos FROM PEDIDO WHERE IDCLIENTE = " + id;

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
        public DataTable ClienteDatosDal2(int id)
        {
            string consulta = " SELECT * FROM PEDIDO WHERE IDCLIENTE = " + id;

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
        public DataTable ClienteDatosDal3(int id)
        {
            string consulta = " SELECT SUM(TOTAL) AS TotalMontosPedidos FROM PEDIDO WHERE IDCLIENTE = " + id;

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }

    }
}
