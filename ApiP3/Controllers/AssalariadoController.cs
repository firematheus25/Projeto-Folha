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
    public class AssalariadoController : ControllerBase
    {
        private readonly P3Context db;

        public AssalariadoController(P3Context db)
        {
            this.db = db;
        }


        [HttpGet]
        public Assalariado Get(int Id)
        {

            return (Assalariado)db.Assalariado.Where(x => x.AssalariadoId == Id).First();

        }

    }
}
