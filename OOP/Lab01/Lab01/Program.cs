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

            Console.WriteLine("Ввведите переменную типа Int");
            VariableInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввведите переменную типа String");
            VariableString = Console.ReadLine();
            Console.WriteLine("Ввведите переменную типа Char");
            VariableChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Ввведите переменную типа Bool");
            VariableBool = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Ввведите переменную типа Byte");
            VariableByte = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ввведите переменную типа Long");
            VariableLong = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Ввведите переменную типа Short");
            VariableShort = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ввведите переменную типа Decimal"); 
            VariableDecimal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ввведите переменную типа Float");
            VariableFloat = float.Parse(Console.ReadLine());
            Console.WriteLine("Ввведите переменную типа Double");
            VariableDouble = Convert.ToDouble(Console.ReadLine());

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
            //Error = "hello";


            //Zadanie 2

            string StrFirst = "Hello";
            string StrSecond = "hello";
            Console.WriteLine($"Строки равны или нет: {StrSecond == StrFirst}");

            string StrOne = "Q WE";
            string StrTwo = "ASD";
            string StrThree = "ZXC";
            string[] StringBuff;

            Console.WriteLine($"Результат сцепления строк {string.Concat(StrOne, StrThree)}");
            Console.WriteLine($"Результат копирования строки {string.Copy(StrOne)}");
            Console.WriteLine($"Результат выделения подстроки {StrOne.Substring(1)}");
            Console.WriteLine($"Результат разделения на строки");
            StringBuff = StrOne.Split();
            for (int i = 0; i < StringBuff.Length; i++)
            {
                Console.WriteLine(StringBuff[i]);
            }
            Console.WriteLine($"Результат подстановки строки {StrOne.Insert(1, StrTwo)}");
            Console.WriteLine($"Результат выделения подстроки {StrOne.Remove(1, 2)}");

            string StrEmpty = "";
            string StrNull = null;
            Console.WriteLine($"Результат выделения подстроки {StrOne.Remove(1, 2)}");
            Console.WriteLine($"IsNullOrEmpty: {string.IsNullOrEmpty(StrEmpty)}");
            Console.WriteLine($"IsNullOrEmpty: {string.IsNullOrEmpty(StrNull)}");
            Console.WriteLine($"Результат сравнение пустой и нулевой строки: {StrNull == StrEmpty}");

            StringBuilder StrBuilder = new StringBuilder("абв");
            StrBuilder.Append("где");
            StrBuilder.Insert(0, "123");
            StrBuilder.Remove(5, 1);
            Console.WriteLine($"Результат работы с StringBuilder: {StrBuilder}");

            //Zadanie 3

            Console.WriteLine("Двумерный массив:");
            int[,] DoubleMassiv = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + DoubleMassiv[i, j]);
                }
                Console.WriteLine();
            }

            string[] MassivStr = new string[4] { "ABC", "BCD", "DCV", "DFC" };
            Console.WriteLine("Начальный массив строк:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(MassivStr[i] + ' ');
            }
            Console.WriteLine();
            Console.WriteLine($"Длина массива:{MassivStr.Length}"); ; ;
            Console.WriteLine("Введите номер элемента, который хотите заменить...");
            int NumElement = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите новое значение элемента, который хотите заменить...");
            string BuffStr = Convert.ToString(Console.ReadLine());
            MassivStr[NumElement] = BuffStr; 
            Console.WriteLine("Изменённый массив строк:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(MassivStr[i] + ' ');
            }

            double[][] ZubMass = new double[3][];
            ZubMass[0] = new double[2];
            ZubMass[1] = new double[3];
            ZubMass[2] = new double[4];
            Console.WriteLine();

            Console.WriteLine("Заполните зубчатый массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < ZubMass[i].Length; j++)
                {
                    ZubMass[i][j] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("Зубчатый массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < ZubMass[i].Length; j++)
                {
                    Console.Write("\t" + ZubMass[i][j]);
                }
                Console.WriteLine();
            }

            var Test = "qsd";
            var TestMass = new[] { 2, 3 };

            //Zadanie 4

            (int, string, char, string, ulong) Kortej = (5, "qwe", '2', "zxc", 23);
            Console.WriteLine($"Кортеж:{Kortej}");
            Console.WriteLine($"1 элемент кортежа:{Kortej.Item1}");
            Console.WriteLine($"3 элемент кортежа:{Kortej.Item3}");
            Console.WriteLine($"4 элемент кортежа:{Kortej.Item4}");
            (int Var1, string Var2, _, string Var4, ulong Var5) = Kortej;
            Console.WriteLine($"4 элемент кортежа через переменную:{Var4}");
            var Var42 = Kortej.Item4;
            Console.WriteLine($"4 элемент кортежа через переменную другим способом:{Var4}");
            var KortOne = ("we", 'w');
            var KortTwo = ("we", 'w');
            Console.WriteLine($"Результат сравнения кортежей:{KortOne == KortTwo}");

            //Zadanie 5
            (int, int, int, char) Function(int[] A, string B)
            {
                int MaxNumber = A.Max();
                int MinNumber = A.Min();
                int SumNumber = A.Sum();
                var FirstLetter = B[0];
                var t = (MaxNumber, MinNumber, SumNumber, FirstLetter);
                return t;
            }

            int[] MassivChisel = new int[3] { 1, 2, 3 };
            string StrKakaytoPoSchetu = "ZXC";
            Console.WriteLine($"Результат работы локальной функции: {Function(MassivChisel, StrKakaytoPoSchetu)}");

            //Zadanie poslednee

            int FuncUnCheck(int Limit)
            {
                unchecked
                {
                    Console.WriteLine(Limit+1); 
                }
                return 0;
            }
            int FuncCheck(int Limit)
            {
                checked
                {
                    Console.WriteLine(Limit);//выбьет ошибку если прибавить единицу;

                }
                return 0;
            }
            int Lim = int.MaxValue;

            FuncCheck(Lim);
            FuncUnCheck(Lim);

        }
    }
}
