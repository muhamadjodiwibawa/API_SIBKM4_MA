using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace API.Models
{
    [Table(name: "tb_m_Universities")]
    public class University
    {
        [Key,Column(name:"id")]
        public int Id { get; set; }

        [Column(name: "name", TypeName = "char(100)")]
        public string Name { get; set; }

        //cardinalitas 
        public ICollection<Education> Educations { get; set; }
    }
}
