huusing FormsCrud.Model;
using FormsCrud.Model.DAO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCrud.Controller
{
    public class ClienteController
    {
        private readonly SqlConnection _conn;
        public ClienteController()
        {
            _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConn"].ToString());
        }
        public void InserirCliente(string nome, int idade, string email, string endereco)
        {
            var cliente = new ClienteModel()
            {
                Nome = nome,
                Idade = idade,
                Email = email,
                Endereco = endereco
            };
            _conn.Open();
            var trans = _conn.BeginTransaction();
            try
            {
                new ClienteDAO(_conn, trans).InserirCliente(cliente);
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
        public List<ClienteModel> RetornaClientes()
        {
            _conn.Open();
            var trans = _conn.BeginTransaction();
            try
            {
                var lista = new ClienteDAO(_conn, trans).RetornaClientes();
                trans.Commit();
                return lista;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
        public void RemoverCliente(int id)
        {
            _conn.Open();
            var trans = _conn.BeginTransaction();
            try
            {
                new ClienteDAO(_conn, trans).RemoverCliente(id);
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
