using System;

namespace API.Entities
{
    public class TimeAndAttendance
    {
        public int Id { get; set; }
        public DateTimeOffset AttendanceDate { get; set; }
        public DateTimeOffset TimeIn { get; set; }
        public DateTimeOffset TimeOut { get; set; }
    }
}