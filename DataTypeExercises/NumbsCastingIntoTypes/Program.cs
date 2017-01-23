using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbsCastingIntoTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;


            try
            {
               Convert.ToSByte(number);
                num1++;
            }
            catch (Exception)
            {

                
            }
            try
            {
                Convert.ToByte(number);
                num2++;
            }
            catch (Exception)
            {

                
            }
            try
            {
                Convert.ToInt16(number);
                num3++;
            }
            catch (Exception)
            {

                
            }
            try
            {
                Convert.ToUInt16(number);
                num4++;
            }
            catch (Exception)
            {

                
            }
            try
            {
                Convert.ToInt32(number);
                num5++;
            }
            catch (Exception)
            {

                
            }
            try
            {
                Convert.ToUInt32(number);
                num6++;
            }
            catch (Exception)
            {

                
            }
            try
            {
                Convert.ToInt64(number);
                num7++;
            }
            catch (Exception)
            {

                
            }

            int numFinal = num1 + num2 + num3 + num4 + num5 + num6 + num7;

            if (numFinal!=0)
            {
                Console.WriteLine($"{number} can fit in:");
                for (int i = 0; i < numFinal; i++)
                {
                    if (num1==1)
                    {
                        Console.WriteLine("* sbyte");
                        num1 = 0;
                    }
                    else if (num2 == 1)
                    {
                        Console.WriteLine("* byte");
                        num2 = 0;
                    }
                    else if (num3 == 1)
                    {
                        Console.WriteLine("* short");
                        num3 = 0;
                    }
                    else if (num4 == 1)
                    {
                        Console.WriteLine("* ushort");
                        num4 = 0;
                    }
                    else if (num5 == 1)
                    {
                        Console.WriteLine("* int");
                        num5 = 0;
                    }
                    else if (num6 == 1)
                    {
                        Console.WriteLine("* uint");
                        num6 = 0;
                    }
                    else if (num7 == 1)
                    {
                        Console.WriteLine("* long");
                        num7 = 0;
                    }
                }
            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }



        }
    }
}
