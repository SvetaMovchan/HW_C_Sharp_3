/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

void Print (string text){  
   Console.WriteLine(text); 
}

int GetIntNum(){
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int CountNumberDigits(int number) //Определяем количество знаков в числе
{
    int count = 0;
    while (number > 0)
    {
        number /= 10; 
        count++;
    }
    return count;
}

int TurnNumber(int number)       //Переворачиваем число
{
    int changeling = 0;
    int count = CountNumberDigits(number);
    for (int i = 0; i < count; i++)
        {
        changeling = changeling + number / Convert.ToInt32(Math.Pow(10,i)) % 10 * Convert.ToInt32(Math.Pow(10,count-1-i));
     }
return changeling;
}

Print("Введите число :");
int number = GetIntNum();
int changeling = TurnNumber(number);
if (number == changeling)
{
    Print("Да, это число - палиндром");
}
else
{
    Print("Нет, это число НЕ палиндром");
}