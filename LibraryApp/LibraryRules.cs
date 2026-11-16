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

        public static string GetFineLevel(int daysOverdue)
        {
            if (daysOverdue <= 0) return "Нет";
            if (daysOverdue <= 14) return "Низкий";
            if (daysOverdue <= 30) return "Средний";
            return "Высокий";
        }

    }
}
