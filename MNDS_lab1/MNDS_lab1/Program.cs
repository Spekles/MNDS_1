using System;
using System.Collections.Generic;
using System.Text;

namespace MNDS_lab1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Створити об‘єкт-деталь Ring:
            Class1 Ring = new Class1();
            //На об‘єкті Ring виконати функцію Elasticity():
            Ring.Elasticity();
            //На об‘єкті Ring виконати функцію Elasticity_FEM():
            Ring.Elasticity_FEM();
        }
    }
}
