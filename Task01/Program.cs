// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void findPolindrom()
{
Console.WriteLine("Введите пятизначное число:");
string number_str = Console.ReadLine();
if (number_str.Length<5 || number_str.Length>5) Console.WriteLine("Некорректное число!");
 else
{
    char[] number_strReverse = number_str.ToCharArray();
    Array.Reverse(number_strReverse);
    string number_strNew = new string(number_strReverse);
    if (number_str == number_strNew) Console.WriteLine("Это полиндром!");
    else  Console.WriteLine("Это НЕ полиндром!");
}
}
findPolindrom();
// Ну либо можно сделать уже с заявленными параметрами (как в Task02), но я сделал так =)