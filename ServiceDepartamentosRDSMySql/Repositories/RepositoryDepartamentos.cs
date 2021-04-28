using ServiceDepartamentosRDSMySql.Data;
using ServiceDepartamentosRDSMySql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDepartamentosRDSMySql.Repositories
{
    public class RepositoryDepartamentos
    {
        DepartamentosContext Context;

        public RepositoryDepartamentos(DepartamentosContext context)
        {
            this.Context = context;
        }

        public List<Departamento> GetDepartamentos()
        {
            return this.Context.Departamentos.ToList();
        }

        public Departamento FindDepartamento(int id)
        {
            return this.Context.Departamentos.SingleOrDefault(x => x.IdDepartamento == id);
        }
    }
}
