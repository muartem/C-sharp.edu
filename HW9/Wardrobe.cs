using System;
using System.Collections.Generic;

namespace HW9
{
    public class Wardrobe
    {
        public readonly int Open = 8;
        public readonly int Close = 19;
 
        private readonly string[] wardrobe = new string[300];

        public string this[int index]
        {
            get
            {
                var cloth = wardrobe[index];
                wardrobe[index] = null;
                return cloth;
            }
            set => wardrobe[index] = value;
        }
       
    }
}