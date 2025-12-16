using PresensiSiswa.Models;

namespace PresensiSiswa.Services
{
    public class AttendanceService : IAttendanceService
    {
        private static List<Attendance> _data = new();

        public List<Attendance> GetAll()
        {
            return _data;
        }

        public Attendance? GetById(int id)
        {
            return _data.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Attendance attendance)
        {
            attendance.Id = _data.Count + 1;
            _data.Add(attendance);
        }

        public void Update(Attendance attendance)
        {
            var item = GetById(attendance.Id);
            if (item == null) return;

            item.Nama = attendance.Nama;
            item.Tanggal = attendance.Tanggal;
            item.Status = attendance.Status;
            item.Note = attendance.Note;
        }

        public void Delete(int id)
        {
            var item = GetById(id);
            if (item != null)
                _data.Remove(item);
        }
    }
}
