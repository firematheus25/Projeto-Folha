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
    public class HoristaController : ControllerBase
    {

        private readonly P3Context db;

        public HoristaController(P3Context db)
        {
            this.db = db;
        }

        [HttpGet]
        public Horista Get(int Id)
        {
            return db.Horista.Where(x => x.HoristaId == Id).FirstOrDefault();

        }
    }
}
