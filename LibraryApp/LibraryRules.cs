using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class LibraryRules
    {
        public static bool IsClassic(int year, int currentYear)
        {
            if (year > currentYear)
                throw new ArgumentException("Год не может быть в будущем", nameof(year));
            return (currentYear - year) >= 100;
        }

    }
}
