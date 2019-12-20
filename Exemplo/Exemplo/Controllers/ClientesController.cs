using System;
using System.Web.Http;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using Exemplo.Models;
using System.Linq;

namespace Exemplo.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> Get()
        {
            return clientes;
        }

        public void Post(string nome)
        {
            if(!string.IsNullOrEmpty(nome))
                clientes.Add(new Cliente(nome));
        }
        public void Delete(string nome)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Equals(nome))));
        }
    }
}
