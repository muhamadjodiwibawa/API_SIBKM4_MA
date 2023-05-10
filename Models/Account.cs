using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace API.Models
{
    [Table(name:"tb_m_Accounts")]
    public class Account
    {
        [Key, Column(name: "employee_nik", TypeName = "char(5)")]
        public string EmployeeNik { get; set; }
        [Column(name:"password",TypeName ="char(255)")]
        public string Password { get; set; }
        //cardinality
        public Employee Employee { get; set; }
        public ICollection <Account_Role>account_roles{ get; set; }

    }
}
