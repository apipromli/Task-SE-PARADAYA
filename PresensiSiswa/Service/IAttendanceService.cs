using PresensiSiswa.Models;

namespace PresensiSiswa.Services
{
    public interface IAttendanceService
    {
        List<Attendance> GetAll();
        Attendance? GetById(int id);
        void Add(Attendance attendance);
        void Update(Attendance attendance);
        void Delete(int id);
    }
}
