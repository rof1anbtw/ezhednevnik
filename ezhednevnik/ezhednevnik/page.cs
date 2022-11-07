using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ezhednevnik
{
    internal class page
    {
        
        public List<Field> Fields;

        public string Date;

        public page(string date, List<Field> fields)
        {
            Fields = fields;
            Date = date;
        }
    }
}
