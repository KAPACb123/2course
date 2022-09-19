using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main()
        {
            byte VariableByte = 1;
            short VariableShort = 12;
            int VariableInt = 8;
            long VariableLong = 29;
            float VariableFloat = 3.43f;
            double VariableDouble = 3.56d;
            decimal VariableDecimal = 3.4m;
            char VariableChar = 'a';
            string VariableString = "Hello";
            bool VariableBool = false;

            Console.WriteLine(VariableBool);
            Console.WriteLine(VariableByte);
            Console.WriteLine(VariableString);
            Console.WriteLine(VariableInt);
            Console.WriteLine(VariableDecimal);
            Console.WriteLine(VariableChar);
            Console.WriteLine(VariableLong);
            Console.WriteLine(VariableDouble);
            Console.WriteLine(VariableShort);
            Console.WriteLine(VariableFloat);

            //Console.WriteLine("Ввведите переменную типа Int");
            //VariableInt = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ввведите переменную типа String");
            //VariableString = Console.ReadLine();
            //Console.WriteLine("Ввведите переменную типа Char");
            //VariableChar = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("Ввведите переменную типа Bool");
            //VariableBool = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine("Ввведите переменную типа Byte");
            //VariableByte = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine("Ввведите переменную типа Long");
            //VariableLong = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("Ввведите переменную типа Short");
            //VariableShort = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Ввведите переменную типа Decimal");
            //VariableDecimal = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Ввведите переменную типа Float");
            //VariableFloat = float.Parse(Console.ReadLine());
            //Console.WriteLine("Ввведите переменную типа Double");
            //VariableDouble = Convert.ToDouble(Console.ReadLine());

            byte bvar = 16;
            short svar = bvar;
            int ivar = svar;
            long lvar = ivar;
            float fvar = lvar;

            int Pack = 8;
            object Zip = Pack;
            int UnPack;
            UnPack = (int)Pack;

            var VarNe = "Hello";

            int? Nullik = null;

            var Error = 23;
            //            Error = "hello";


            //Zadanie 2

            string StrFirst = "Hello";
            string StrSecond = "hello";
            Console.WriteLine($"Строки равны или нет: {StrSecond == StrFirst}");

            string StrOne = "QWE";
            string StrTwo = "ASD";
            string StrThree = "ZXC";

            Console.WriteLine($"Результат сцепления строк {string.Concat(StrOne,StrThree)}");
            Console.WriteLine($"Результат копирования строки {string.Copy(StrOne)}");
            Console.WriteLine($"Результат сцепления строк {string.Equals");
            string.




        }
    }
}
