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
    public class VendasController : ControllerBase
    {

        private readonly P3Context db;

        public  VendasController(P3Context db)
        {
            this.db = db;

        }

        [HttpGet]
        public List<Vendas> Get()
        {
            return db.Vendas.ToList();
        }

        [HttpGet("Id")]
        public Vendas GetById(int Id)
        {
            return db.Vendas.Where(x => x.VendasId == Id).FirstOrDefault();
        }

        [HttpGet("Ids/{Id}")]
        public List<Vendas> GetByIds(int Id)
        {
            return db.Vendas.Where(x => x.FuncionariosId == Id).ToList();
        }

        [HttpPost]
        public void Post(Vendas Vendas)
        {
            db.Vendas.Add(Vendas);
            db.SaveChanges();            
        }

        [HttpPut]
        public ActionResult Put(Vendas Vendas)
        {
            if (Vendas.VendasId != 0)
            {
                db.Vendas.Update(Vendas);
                db.SaveChanges();

                return Ok();
            }
            return Ok();
        }


    }
}
