using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table(name:"Tb_m_employees")]
    public class Employee
    {
        [Key,Column(name:"nik",TypeName ="char(5)")]
        public string NIK { get; set; }
        [ Column(name: "first_name", TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        [Column(name: "last_name", TypeName = "varchar(50)")]
        public string LastName { get; set; }
        [Column(name: "birth_date", TypeName = "datetime")]
        public DateTime BirthDate { get; set; }
        [Column(name: "gender")]
        public  Gender  Gender { get; set; }
        [Column(name: "hiring_date", TypeName = "datetime")]
        public DateTime HiringDate { get; set; }
        [Column(name: "email", TypeName = "varchar(50)")]
        public string Email { get; set; }
        [Column(name: "phone_number", TypeName = "varchar(50)")]
        public string PhoneNumer { get; set; }
        public Profiling Profiling { get; set; }
        public Account Account { get; set; }


    }
    public enum Gender  
    {
        Male,
        Female
    }
}



