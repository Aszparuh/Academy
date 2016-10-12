using System.Collections.Generic;

namespace SchoolSystem.Logic
{
    public static class StaticSchool
    {
        internal static Dictionary<int, Teacher> Teachers { get; set; } = new Dictionary<int, Teacher>();

        internal static Dictionary<int, Student> Students { get; set; } = new Dictionary<int, Student>();
    }
}
