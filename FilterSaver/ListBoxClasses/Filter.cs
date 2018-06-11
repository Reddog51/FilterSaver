using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterSaver.ListBoxClasses
{
    public class Filter
    {
        virtual public string FilterName { get; set; }
        virtual public List<string> Filters  { get; set; }
    }
}
