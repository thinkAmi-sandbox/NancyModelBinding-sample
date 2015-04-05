using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyModelBindingSample
{
    public class RazorConfig : Nancy.ViewEngines.Razor.IRazorConfiguration
    {
        public IEnumerable<string> GetAssemblyNames()
        {
            yield return "NancyModelBindingSample";
        }

        public IEnumerable<string> GetDefaultNamespaces()
        {
            yield return "NancyModelBindingSample";
        }

        public bool AutoIncludeModelNamespace
        {
            get { return true; }
        }
    }
}
