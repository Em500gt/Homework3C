using static System.Console;
Clear();
Write("Введите число: ");
int number = Convert.ToInt16(ReadLine());
int count = 1;
while (count < number + 1)
{
    Write(Math.Pow(count, 3) + " ");
    count++;
}