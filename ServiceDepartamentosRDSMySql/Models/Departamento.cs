using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDepartamentosRDSMySql.Models
{
    [Table("DEPT")]
    public class Departamento
    {
        [Key]
        [Column("DEPT_NO")]
        public int IdDepartamento { get; set; }
        [Column("DNOMBRE")]
        public String Nombre { get; set; }
        [Column("LOC")]
        public String Localidad { get; set; }
    }
}