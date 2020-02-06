using System;
using System.Collections.Generic;
using System.Text;

namespace WasteRec
{
    class PlasticGarbage : Garbage 
    {
        private bool cleaned;
        public PlasticGarbage(string name, bool cleaned) : base(name)
        {
            this.cleaned = cleaned;
        }
        public void Clean()
        {
            cleaned = true;
        }
        public bool IsCleaned
        {
            get { return this.cleaned; }
            set { this.cleaned = value; }
        }
    }
}
