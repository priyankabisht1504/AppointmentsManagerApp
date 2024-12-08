using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppointmentsManager.Data.Models
{
    public class Appointment
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(150), Column(TypeName = "nvarchar(150)")]
        public string Title { get; set; } = "Title";

        [MaxLength(300), Column(TypeName = "nvarchar(300)")]
        public string Description { get; set; } = "Description";

        //[MaxLength(200), Column(TypeName = "nvarchar(200)")]
        //public string Remark1 { get; set; } = "Remark1";

        //[MaxLength(200), Column(TypeName = "nvarchar(200)")]
        //public string Remark2 { get; set; } = "Remark2";

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;

        public DateTime Date { get; set;} = DateTime.Now;

        //[MaxLength(100), Column(TypeName = "nvarchar(100)")]
        //public string Name { get; set; } = "Name";

        [MaxLength(100), Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; } = "Address";

        [MaxLength(10), Column(TypeName ="nvarchar(10)")]
        public string Time { get; set; } = "12:30";

        public bool Done { get; set; } = false;
        public bool Deleted { get; set; } = false;

        public byte LevelOfImportance { get; set; } = 2;

        //public byte Softewares { get; set; } = 2;

    }
}
