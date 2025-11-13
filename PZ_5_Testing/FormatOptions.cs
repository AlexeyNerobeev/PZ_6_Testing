using PZ_5_Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_6_Testing
{
    /// <summary>
    /// Класс для настройки параметров форматирования
    /// </summary>
    public class FormatOptions
    {
        public bool RemoveExtraSpaces { get; set; }
        public bool ConvertToUpper { get; set; }
        public bool JustifyText { get; set; }
        public int LineWidth { get; set; } = TextFormatter.DefaultLineWidth;
    }
}
