using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicOperations09102022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            NumberOfHouse noh = new NumberOfHouse(Houses(), InfoAboutHouse());
        }
        static string InfoAboutHouse()
        {
            string iAH;
            Console.Write("Введите цвет и количество этажей данные дома, сказанные прохожим: ");
            iAH = Console.ReadLine();
            return iAH;
        }
        static string[] Houses()
        {
            string houseOne, houseTwo, houseThree;
            Console.Write("Введите цвет и количество этажей первого дома: ");
            houseOne = Console.ReadLine();
            Console.Write("Введите цвет и количество этажей второго дома: ");
            houseTwo = Console.ReadLine();
            Console.Write("Введите цвет и количество этажей третьего дома: ");
            houseThree = Console.ReadLine();
            string[] houses = new string[]
            {
                houseOne,
                houseTwo,
                houseThree
            };

            return houses;
        }
        /*  
         *  bool A = true;
            bool B = true;
            bool C = true;
            bool D = true;
            bool result;
            Console.Write(result);
            Console.ReadKey();
         * Logic.OpPred(Logic.OpInversion(A), B);
         * Logic.OpAnd(Logic.OpInversion(Logic.OpImp(A, B)), C);
         * Logic.OpAnd(Logic.OpInversion(A), Logic.OpPred(B, Logic.OpInversion(Logic.XOR(C, D))));
         * Logic.OpImp(Logic.OpOr(Logic.OpInversion(Logic.OpImp((Logic.OpPred(Logic.OpInversion(A), B)), C)), D), Logic.OpOr(Logic.OpInversion(C), Logic.OpImp(D, Logic.OpInversion(Logic.XOR(A, B)))));
         */
    }
}
