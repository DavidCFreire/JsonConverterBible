using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonConverterBible
{
    public class BibleModel
    {
        public string abbrev { get; set; }
        public List<List<string>> chapters { get; set; }
        public string name { get; set; }
    }
    public class BibleImportModel
    {
        public int pk { get; set; }
        public string translation { get; set; }
        public int book { get; set; }
        public int chapter { get; set; }
        public int verse { get; set; }
        public string text { get; set; }
    }
}
