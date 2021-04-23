using ApiP3.DATA;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using miscellaneous.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiP3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroPontosController : ControllerBase
    {

        private readonly P3Context db;

        public RegistroPontosController(P3Context db)
        {
            this.db = db;
        }

        [HttpGet]
        public List<RegistroPonto> Get()
        {
            return db.RegistroPontos.ToList();
        }

        [HttpPost]
        public void Post(RegistroPonto Ponto)
        {
            db.RegistroPontos.Add(Ponto);
            db.SaveChanges();
        }

        [HttpPut]
        public void Put(RegistroPonto Ponto)
        {
            db.RegistroPontos.Update(Ponto);
            db.SaveChanges();
        }


    }
}
