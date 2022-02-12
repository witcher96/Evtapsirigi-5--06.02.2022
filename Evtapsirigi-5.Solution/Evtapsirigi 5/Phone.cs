using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evtapsirigi_5
{
    internal class Phone
    {
        public string producer;             //Samsung
        public string model;               //Smartphone
        public int mainCamera;         //12mpx
        public int cores;                //8
        public int memory;              //128gb
        public int prodYear;           //2020
        public double price;          // 3250
        public static int id;
        public int counter = 0;

        public Phone()
        {
            counter++;
            id = counter;
        }
        public override string ToString()
        {
            return $"{id}\n" +
                $"{producer}\n" +
                $"{model}\n" +
                $"{mainCamera}\n" +
                $"{cores}\n" +
                $"{memory}\n" +
                $"{prodYear}\n" +
                $"{price}";
        }

        








    }
}
