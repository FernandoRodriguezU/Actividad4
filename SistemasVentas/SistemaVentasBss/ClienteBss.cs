using SistemasVentas.BSS;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.DAL;
namespace SistemasVentas.BSS
{
    public class ClienteBss
    {

        ClienteDal dal = new ClienteDal();
        public DataTable ListarClienteBss()
        {

            return dal.LIstarClienteDal();
        }
        public void InsertarClienteBss(Cliente cliente)
        {
            dal.InsertarClienteDAL(cliente);
        }
        public Cliente ObtenerClienteIdBss(int id)
        {
            return dal.ObtenerClienteIdDal(id);
        }
        public void EditarClienteBss(Cliente p)
        {
            dal.EditarClienteDal(p);
        }

        public void EliminarClienteBss(int id)
        {
            dal.EliminarClienteDal(id);
        }
        public DataTable ClienteDatosBSS(int id)
        {
            return dal.ClienteDatosDal(id);
        }
        public DataTable ClienteDatosBSS2(int id)
        {
            return dal.ClienteDatosDal2(id);
        }
        public DataTable ClienteDatosBSS3(int id)
        {
            return dal.ClienteDatosDal3(id);
        }

    }
}