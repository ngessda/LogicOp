using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicOperations09102022
{
    public class NumberOfHouse
    {
        private string returnColor(string houseData)
        {
            int index = houseData.LastIndexOf(" ");
            string color = houseData.Substring(0, index);
            return color;
        }
        private string returnNumber(string houseData)
        {
            int index = houseData.LastIndexOf(" ");
            string number = houseData.Substring(index);
            return number;
        }
        public NumberOfHouse(string[] houses, string info)
        {
            RightHouse(houses, info);
        }
        private bool CheckRightHouse(string allegedHouse,string currentHouse)
        {
            string allegedColor = returnColor(allegedHouse);
            string allegedNumber = returnNumber(allegedHouse);
            string currentColor = returnColor(currentHouse);
            string currentNumber = returnNumber(currentHouse);
            if (allegedColor == currentColor && allegedNumber == currentNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void RightHouse(string[] allegedHouse, string currentHouse)
        {
            bool[] results = new bool[3];
            for (int i = 0; i < allegedHouse.Length; i++)
            {
                if (CheckRightHouse(allegedHouse[i], currentHouse))
                {
                    results[i] = true;
                }
                else
                {
                    results[i] = false;
                }
            }
            for (int i = 0; i < results.Length; i++)
            {
                int counter = 1;
                if (results[i])
                {
                    Console.Write(counter);
                    counter++;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}