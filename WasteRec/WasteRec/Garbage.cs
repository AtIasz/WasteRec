using System;
using System.Collections.Generic;
using System.Text;

namespace WasteRec
{
    class Garbage
    {
        private string name;
        public Garbage(string name)
        {
            this.name = name;
        }
        public string GetName
        {
            get { return name; }
        }
        
    }
}
