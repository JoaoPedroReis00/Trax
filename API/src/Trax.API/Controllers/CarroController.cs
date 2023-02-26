using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Trax.API.Models;

namespace Trax.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarroController : ControllerBase
    {
        public IEnumerable<Carro> carros = new Carro[] {
            new Carro(1, "F40", "Ferrari", 1984, "f40.png"),
            new Carro(2, "F1", "McLaren", 1990, "f1.png"),
        };
        [HttpGet]
        public IEnumerable<Carro> Get()
        {
            return carros;
        }

        [HttpPost]
        public IEnumerable<Carro> Post(int id, string nome, string marca, int ano, string img)
        {
            carros.Append(new Carro(id, nome, marca, ano, img));
            return carros;
        }

        [HttpPut]
        public IEnumerable<Carro> Put(int id, string nome, string marca, int? ano = null, string img)
        {
            var carro = carros.Where(x => x.Id == id).FirstOrDefault();

            if (carro != null) {
                if (nome != null) carro.Nome = nome;
                if (marca != null) carro.Marca = marca;
                if (ano != null) carro.Ano = ano.Value;
                if (img != null) carro.Img = img;
            }

            return carros;
        }

        [HttpDelete]
        public IEnumerable<Carro> Delete(int id)
        {
            var newCarros = carros.Where(x => x.Id != id);

            return newCarros;
        }
    }
}
