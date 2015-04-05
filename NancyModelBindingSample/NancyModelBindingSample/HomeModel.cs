using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyModelBindingSample
{
    public class HomeModel
    {
        public string Text { get; set; }
        public string TextArea { get; set; }
        public string Tel { get; set; }
        public string Url { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public bool Checkbox { get; set; }

        // radio button
        // bind to `value` element
        public string RadioButtonValue { get; set; }

        // bind to `checked` element
        public bool IsGood { get { return RadioButtonValue == "good" ? true : false; } }
        public bool IsNormal { get { return RadioButtonValue == "normal" ? true : false; } }
        public bool IsBad { get { return RadioButtonValue == "bad" ? true : false; } } 
    }
}
