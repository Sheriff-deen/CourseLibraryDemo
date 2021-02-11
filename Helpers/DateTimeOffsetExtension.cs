using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibraryAPI.Helpers
{
    public static class DateTimeOffsetExtension
    {

        public static int GetCurrentDate(this DateTimeOffset dateTimeOffset)
        {
            var currentDate = DateTime.UtcNow;

            var age = currentDate.Year - dateTimeOffset.Year;

            if (currentDate < dateTimeOffset.AddYears(age))
            {
                age -= 1;
            }

            return age;
        }
    }
}
