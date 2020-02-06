using System;
using System.Collections.Generic;
using System.Text;

namespace WasteRec
{
    class PaperGarbage : Garbage
    {
        private bool squeezed;

        public PaperGarbage(string name, bool squeezed) : base(name)
        {
            this.squeezed = squeezed;
        }
        public void Squeeze()
        {
            squeezed = true;
        }
        public bool IsSqueezed
        {
            get { return this.squeezed; }
            set { this.squeezed = value; }
        }
    }
}
