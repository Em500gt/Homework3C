using static System.Console;
Clear();
Write("Введите пятизначное число: ");
int number = Convert.ToInt32(ReadLine());
int a3 = number / 10 % 10;
int a4 = number % 10;
int result = a4 * 10 + a3;
WriteLine(result == (number / 1000) ? "Да": "Нет");