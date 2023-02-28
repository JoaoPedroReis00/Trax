using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Trax.API.Data;
using Trax.API.Models;

namespace Trax.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public CarroController(DataContext context)
        {
            _dataContext = context;
        }

        [HttpGet]
        public IEnumerable<Carro> Get()
        {
            return _dataContext.Carros;
        }

        [HttpGet]
        [Route("{id}")]
        public Carro GetById(int id)
        {
            return _dataContext.Carros.Where(x => x.Id == id).FirstOrDefault();
        }

        [HttpPost]  
        public IEnumerable<Carro> Post(int id, string nome, string marca, int ano, string img)
        {
            _dataContext.Add(new Carro(id, nome, marca, ano, img));
            return _dataContext.Carros;
        }

        [HttpPut]
        public IEnumerable<Carro> Put(int id, string nome, string marca, string img, int? ano = null)
        {
            return _dataContext.Carros;
        }

        [HttpDelete]
        public IEnumerable<Carro> Delete(int id)
        {
            return _dataContext.Carros;
        }
    }
}
