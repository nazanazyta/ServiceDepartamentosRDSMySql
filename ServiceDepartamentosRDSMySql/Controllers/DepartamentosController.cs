using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceDepartamentosRDSMySql.Models;
using ServiceDepartamentosRDSMySql.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDepartamentosRDSMySql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController: ControllerBase
    {
        RepositoryDepartamentos Repo;

        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.Repo = repo;
        }

        [HttpGet]
        public List<Departamento> GetDepartamentos()
        {
            return this.Repo.GetDepartamentos();
        }

        [HttpGet("{id}")]
        public Departamento FindDepartamento(int id)
        {
            return this.Repo.FindDepartamento(id);
        }
    }
}
