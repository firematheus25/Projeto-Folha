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
    public class FuncionariosController : ControllerBase
    {
        private readonly P3Context db;
        public FuncionariosController(P3Context db)
        {
            this.db = db;
        }

        [HttpGet]
        public List<FuncionarioVw> Get()
        {
            return db.funcionarioVw.ToList();
        }

        [HttpPost]
        public void Post(Funcionario funcionario)
        {
            db.Assalariado.Add(funcionario.Assalariado);
            db.SaveChanges();
            funcionario.AssalariadoId = funcionario.Assalariado.AssalariadoId;
            db.Funcionario.Add(funcionario);
            db.SaveChanges();
        }

    }
}
