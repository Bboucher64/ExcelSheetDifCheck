using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSheetDifCheck
{
    class InputModel
    {
        public string FilePath { get; set; }
        public string RangeLow { get; set; }
        public string RangeHigh { get; set; }
        public string SheetCon { get; set; }
        public string SheetExp { get; set; }

    }
}
