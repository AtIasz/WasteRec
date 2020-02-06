using System;
using System.Collections.Generic;
using System.Text;

namespace WasteRec
{
    class Dustbin
    {
        
        private string color { get; set; }
        private string name { get; set; }
        public PaperGarbage[] PaperContent { get; set; }
        public PlasticGarbage[] PlasticContent { get; set; }
        public Garbage[] HouseWasteContent { get; set; }
        public Dustbin(string name)
        {
            color = DustbinColor();
            this.name = name;
            PaperContent = new PaperGarbage[0];
            PlasticContent = new PlasticGarbage[0];
            HouseWasteContent = new Garbage[0];
        }
        public void DisplayContents()
        {
            Console.WriteLine(this.color +" Dustbin!");
            Console.WriteLine(); Console.WriteLine();

            int paperLength = PaperContent.Length;
            int plasticLength = PlasticContent.Length;
            int dustbinLength = HouseWasteContent.Length;
            
            Console.WriteLine($"House waste content: {dustbinLength} item(s)");
            Console.WriteLine();

            if (dustbinLength > 0)
            {
                for (int i = 0; i < dustbinLength; i++)
                {
                    Console.WriteLine("   " + HouseWasteContent[i].GetName);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Paper content: {paperLength} item(s)");
            Console.WriteLine();
            if (paperLength > 0)
            {
                for (int i = 0; i < paperLength; i++)
                {
                    Console.WriteLine("   " + PaperContent[i].GetName);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Plastic content: {plasticLength} item(s)");
            Console.WriteLine();
            if (plasticLength > 0)
            {
                for (int i = 0; i < plasticLength; i++)
                {
                    Console.WriteLine("   " + PlasticContent[i].GetName);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
        }
        private string DustbinColor()
        {
            int numb;
            string color = "";
            Random rnd = new Random();
            numb = rnd.Next(0, 5);
            if (numb == 0)
            {
                color = "Blue";
            }
            else if (numb == 1)
            {
                color = "Red";
            }
            else if (numb == 2)
            {
                color = "Black";
            }
            else if (numb == 3)
            {
                color = "Green";
            }
            else if (numb == 4)
            {
                color = "Yellow";
            }
            return color;
        }
        public void ThrowOutGarbage(Garbage garbage)
        {
            if (garbage is PlasticGarbage)
            {
                PlasticGarbage garbage1 = (PlasticGarbage)garbage;
                if(!garbage1.IsCleaned)
                {
                    garbage1.Clean();
                    Console.WriteLine("This garbage had to be cleaned");
                }
                Garbage[] tmp = new Garbage[HouseWasteContent.Length + 1];
                tmp[HouseWasteContent.Length] = garbage1;
                HouseWasteContent = tmp;

                PlasticGarbage[] plaTmp = new PlasticGarbage[PlasticContent.Length - 1];
                PlasticContent = plaTmp;
                
            }
            else if (garbage is PaperGarbage)
            {
                PaperGarbage garbage1 = (PaperGarbage)garbage;
                if (!garbage1.IsSqueezed)
                {
                    garbage1.Squeeze();
                    Console.WriteLine("This garbage had to be squeezed");
                }
                Garbage[] tmp = new Garbage[HouseWasteContent.Length + 1];
                tmp[HouseWasteContent.Length] = garbage1;
                HouseWasteContent = tmp;

                PaperGarbage[] papTmp = new PaperGarbage[PaperContent.Length - 1];
                PaperContent = papTmp;

            }
            else
            {
                Garbage[] tmp = new Garbage[HouseWasteContent.Length + 1];
                tmp[HouseWasteContent.Length] = garbage;
                HouseWasteContent = tmp;

                Garbage[] garTmp = new Garbage[HouseWasteContent.Length - 1];
                HouseWasteContent = garTmp;

            }
        }
        public void EmptyContents()
        {
            PaperGarbage[] tmpPap = new PaperGarbage[0];
            PlasticGarbage[] tmpPla = new PlasticGarbage[0];
            Garbage[] tmpGar = new Garbage[0];
            PaperContent = tmpPap;
            PlasticContent = tmpPla;
            HouseWasteContent = tmpGar;
        }
        
    }
}
