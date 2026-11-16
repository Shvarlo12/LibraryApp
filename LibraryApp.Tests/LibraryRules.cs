using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class LibraryRules
    {
        public static string GetFineLevel(int daysOverdue)
        {
            if (daysOverdue <= 0) return "Нет";
            if (daysOverdue < 14) return "Низкий";
            if (daysOverdue <= 30) return "Средний";
            return "Высокий";
        }

    }
}
