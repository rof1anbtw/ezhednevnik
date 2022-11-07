using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezhednevnik
{
    internal class NoteBook
    {
       public List<page> Pages;

        public NoteBook(List<page> pages)
        {
            Pages = pages;
        }
    }
}
