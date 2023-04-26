using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace API.Models
{
    [Table(name:"tb_m_Roles")]
    public class Role
    {
        [Key,Column(name:"id")]
        public int Id { get; set; }
        [Column(name:"name",TypeName ="char(50)")] 
        public string Name { get; set; }
    }
}
