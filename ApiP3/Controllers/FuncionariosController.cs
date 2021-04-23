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
            if (funcionario.TipoFuncionario == 1)
            {
                db.Assalariado.Add(funcionario.Assalariado);
                db.SaveChanges();
                funcionario.AssalariadoId = funcionario.Assalariado.AssalariadoId;
            }
            else if(funcionario.TipoFuncionario == 2)
            {
                db.Comissionado.Add(funcionario.Comissionado);
                db.SaveChanges();
                funcionario.ComissionadoId = funcionario.Comissionado.ComissionadoId;
            }
            else
            {
                db.Horista.Add(funcionario.Horista);
                db.SaveChanges();
                funcionario.HoristaId = funcionario.Horista.HoristaId;
            }
                      
            db.Funcionario.Add(funcionario);
            db.SaveChanges();


        }

        [HttpPut]
        public void Put(Funcionario funcionario)
        {
            if (funcionario.FuncionariosId != 0)
            {
                db.Assalariado.Update(funcionario.Assalariado);
                db.SaveChanges();
                db.Funcionario.Update(funcionario);
                db.SaveChanges();
            }
        }


    }
}
