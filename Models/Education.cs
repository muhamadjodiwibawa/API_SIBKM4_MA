using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace API.Models
{
    [Table(name:"tb_m_Educations")]
    public class Education

    {
        [Key,Column(name:"id")]
        public int Id { get; set; }

        [Column(name: "major", TypeName = "varchar(10)")]
        public string Major { get; set; }

        [Column(name: "degree", TypeName = "varchar(10)")]
        public string Degree { get; set; }

         [ Column(name: "gpa", TypeName = "varchar(5)")]
        public string Gpa { get; set; }

        [Column(name: "university_id", TypeName = "int")]
        public int University_Id { get; set; }
    }
}
