using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterSaver.ListBoxClasses
{
    public class BongoFilter : Filter
    {
        public BongoFilter() { new Filter { FilterName = "BongoFilter", Filters = new List<string>() }; }
    }
}
