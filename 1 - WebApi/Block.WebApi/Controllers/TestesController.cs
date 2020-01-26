using Block.Business.Base.Interfaces;
using Block.Entities.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Block.WebApi.Controllers
{
    public class TestesController : ApiController
    {
        private readonly IServiceBasic _serviceBasic;

        public TestesController(IServiceBasic serviceBasic)
        {
            _serviceBasic = serviceBasic;
        }

        [HttpGet]
        public List<Pessoa> GetAllPessoa()
        {
            var dados = _serviceBasic.GetAll<Pessoa>().ToList();
            return dados;
        }
    }
}