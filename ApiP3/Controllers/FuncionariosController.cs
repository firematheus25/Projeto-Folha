using ApiP3.DATA;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<FuncionarioVw>> Get()
        {
            var Query = db.FuncionarioVw.ToList();
            return Ok(Query);
        }

        [HttpGet("Horista")]
        public List<FuncionarioVw> GetByHorista()
        {
            return db.FuncionarioVw.Where(X => X.HoristaId != null).ToList();
        }

        [HttpGet("Comissionado")]
        public List<FuncionarioVw> GetByComissionado()
        {
            return db.FuncionarioVw.Where(X => X.ComissionadoId != null).ToList();
        }

        [HttpGet("Sindicato")]
        public List<FuncionarioVw> GetBySindicato()
        {
            return db.FuncionarioVw.Where(X => X.ComissionadoId != null).ToList();
        }

        [HttpGet("Id")]
        public FuncionarioVw Get(int Id)
        {
            return db.FuncionarioVw.Where(x => x.FuncionariosId == Id).FirstOrDefault();
        }


        [HttpGet("{KeyWord}")]
        public List<FuncionarioVw> GetByKeyWord(string KeyWord)
        {
            var sql = $"select * from funcionariosVw where concat (nome, funcionariosId) like concat ('%','{KeyWord}','%')";

            return db.FuncionarioVw.FromSqlRaw(sql).ToList();
        }



        [HttpGet("BuscaCB")]
        public FuncionarioVw GetConsulta(int Id)
        {
            return db.FuncionarioVw.Where(X => X.FuncionariosId == Id).Select(x => new FuncionarioVw()
            {
                FuncionariosId = x.FuncionariosId,
                Nome = x.Nome
            }).FirstOrDefault();

        }

                    

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Funcionario> Post(Funcionario funcionario)
        {

            using (var transaction = db.Database.BeginTransaction())
            {
                if (funcionario.TipoFuncionario == 1)
                {
                    db.Assalariado.Add(funcionario.Assalariado);
                    db.SaveChanges();
                    funcionario.AssalariadoId = funcionario.Assalariado.AssalariadoId;
                }
                else if (funcionario.TipoFuncionario == 2)
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

                transaction.Commit();
                return Ok();

            }


        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Funcionario> Put(Funcionario funcionario)
        {
            if (funcionario.FuncionariosId != 0)
            {
                using(var transaction = db.Database.BeginTransaction())
                {
                    db.Assalariado.Update(funcionario.Assalariado);
                    db.SaveChanges();
                    db.Funcionario.Update(funcionario);
                    db.SaveChanges();
                    transaction.Commit();
                    return Ok();                    
                }

            }
            return Ok();

        }


    }
}
