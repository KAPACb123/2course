using System;

namespace Lab02
{
    class Customer
    {
        int ID;
        string Surname;
        string Name;
        string Patronymic;
        int NumberCard;
        int Balance;
        public Customer()
        {
            Console.WriteLine("Заполнение класса...");
            Surname = "Бекиш";
            Name = "Alexander";
            Patronymic = "Sergeevich";
        }
    }
}
