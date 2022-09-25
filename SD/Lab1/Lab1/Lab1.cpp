
#include <iostream>

using namespace std;


void bash(int diski, int first, int second, int buff) {
    if (diski != 0)
    {
        bash(diski - 1, first, buff, second);
        cout << "Переместить диск с " << first << " на " << second << endl;
        bash(diski - 1, buff, second, first);
    }
}

int main()
{
    setlocale(LC_ALL, "Rus");
    int n, i, k;
    bool a;
    int buff;
    do
    {
        a = true;
        cout << "Введите кол-во дисков: " << endl;
        cin >> n;
        cout << "Всего 3 столбика" << endl;
        cout << "Введите на каком столбике находятся все диски: " << endl;
        cin >> i;
        cout << "Введите на который нужно переместить все диски: " << endl;
        cin >> k;
        if (i == 1 && k == 3 || i == 3 && k == 1) {
            buff = 2;
        }
        if (i == 2 && k == 3 || i == 3 && k == 2) {
            buff = 1;
        }
        if (i == 2 && k == 1 || i == 1 && k == 2) {
            buff = 3;
        }

        if (cin.get() != (int)'\n')
        {
            cout << "Некорректный ввод... Повторите еще раз\n" << endl;
            a = false;
            cin.clear();
            cin.ignore(32444, '\n');
        }
        else if (n < 0 || n > 30 || k < 1 || k > 3 || i < 1 || i > 3)
        {
            cout << "Некорректный ввод... Повторите еще раз\n" << endl;
            a = false;
        }
    } while (!a);

    bash(n, i, k, buff);
    return 0;
}




