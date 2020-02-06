using System;
using System.Collections.Generic;

namespace WasteRec
{
    class Program
    {
        static void Main(string[] args)
        {
            Garbage[] rottenTomatoes = new Garbage[3];
            Dustbin dustbin = new Dustbin("Jenny's handsome");
            List<Garbage> tmpList = new List<Garbage>();
            
            for (int i = 0; i < rottenTomatoes.Length; i++)
            {
                rottenTomatoes[i] = new Garbage("rotten tomato nr." + (i + 1));
                tmpList.Add(rottenTomatoes[i]);
            }
            
            Garbage[] tmpHwc = new Garbage[tmpList.Count];
            for (int i = 0; i < tmpList.Count; i++)
            {
                tmpHwc[i] = tmpList[i];
            }
            dustbin.HouseWasteContent = tmpHwc;
            PlasticGarbage milkJug = new PlasticGarbage("plastic milk jug", false);
            PlasticGarbage[] tmpPla = new PlasticGarbage[dustbin.PlasticContent.Length + 1];
            tmpPla[dustbin.PlasticContent.Length] = milkJug;
            dustbin.PlasticContent = tmpPla;
            dustbin.DisplayContents();
            for (int i = 0; i < 3; i++)
            {
                dustbin.ThrowOutGarbage(rottenTomatoes[i]);
            }
            Console.WriteLine("Checking them milkjugs out.");
            if (!milkJug.IsCleaned)
            {
                Console.WriteLine("The milkjug isn't clean yet.");
                milkJug.Clean();
            }

            Console.WriteLine("The milkjug is clean af.");
            dustbin.ThrowOutGarbage(milkJug);
            Console.WriteLine("The milkjug's gone.");
            dustbin.EmptyContents();
            Console.WriteLine(); Console.WriteLine();
            dustbin.DisplayContents();
            
        }
                
    }
}
