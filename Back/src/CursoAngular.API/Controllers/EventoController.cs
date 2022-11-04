using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoAngular.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CursoAngular.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
            EventoId = 1,
            Tena = "Angular 11 e .NET 5",
            Local = "Alambari-SP",
            Lote = "1º lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "foto.png"
            },
            new Evento(){
            EventoId = 2,
            Tena = "Angular 11 e .NET 5",
            Local = "Alambari-SP",
            Lote = "2º lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(3).ToString(),
            ImagemURL = "foto.png"
            }
        };
        public EventoController()
        {}


        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
           return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
           return "Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"Put id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return $"Delete id = {id} ";
        }
    }
}