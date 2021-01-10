using System;

namespace HW10_3
{
    internal  class Program
    {
        public static void Main()
        { 
            var accent = new Hyundai("accent","sedan"); 
            var elantra = new Hyundai("elantra", "sedan");
            var sonata = new Hyundai("sonata", "sedan");
            var matrix = new Hyundai("matrix","hatchback");
            var santafe = new Hyundai("santafe","crossroad");
            var i10 = new Hyundai("i10","sedan");
            var i20 = new Hyundai("i20","hatchback");
            var i30 = new Hyundai("i30","hatchback");
            var i40 = new Hyundai("i40","coupe");
            var ix20 = new Hyundai("ix20","hatchback");
            var ix35 = new Hyundai("ix35","crossroad");
            var ix55 = new Hyundai("ix55","crossroad");
            var grandeur = new Hyundai("grandeur","sedan");
            
            Console.WriteLine(accent.Model);
            Console.WriteLine(elantra.Model);
            Console.WriteLine(sonata.Model);
            Console.WriteLine(matrix.Model);
            Console.WriteLine(santafe.Model);
            Console.WriteLine(i10.Model);
            Console.WriteLine(i20.Model);
            Console.WriteLine(i30.Model);
            Console.WriteLine(i40.Model);
            Console.WriteLine(ix20.Model);
            Console.WriteLine(ix35.Model);
            Console.WriteLine(ix55.Model);
            Console.WriteLine(grandeur.Model);
        }
    }
}