using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezhednevnik
{
    internal class Field
    {
        
        public string Name;
       
        public string Content;

        public Field(string name, string content)
        {
            Name = name;
            Content = content;
        }
    }
}
