using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table(name: "tb_tr_profilings")]
    public class Profiling
    {
        [Key,Column(name:"employee_nik",TypeName="char(5)")]
        public string EmployeeNIK { get; set; }

        [Column(name:"education_id")]
        public int EducationId { get; set; }
    }
}

