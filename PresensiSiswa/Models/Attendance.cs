using System.ComponentModel.DataAnnotations;

namespace PresensiSiswa.Models
{
    public class Attendance
    {
        public int Id { get; set; }

        [Required]
        public string Nama { get; set; }

        [DataType(DataType.Date)]
        public DateTime Tanggal { get; set; }

        [Required]
        public string Status { get; set; }

        public string? Note { get; set; }
    }
}
