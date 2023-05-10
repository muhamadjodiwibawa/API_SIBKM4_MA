using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace API.Models
{
    [Table(name: "tb_tr_Account_Roles")]
    public class Account_Role
    {
        [Key, Column(name: "id")]
        public int? Id { get; set; }
        [Column(name: "account_nik", TypeName = "char(5)")]
        public string? AccountNik { get; set; }
        [Column(name: "role_id")]
        public int? RoleId { get; set; }

        //cardinality
        public Account Account { get; set; }
        public Role Role { get; set; }
    }
}
