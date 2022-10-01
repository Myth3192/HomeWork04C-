int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int num = ReadData("Введите число ");


int SummNumber(int num)
{   
    int count = Convert.ToString(num).Length;
    int summ = 0;
    for (int i=1; i <=count; i++)
    {
        summ = summ +(num%10);
        num = num/10;
    }
   return summ;
}

int summ = SummNumber(num);
Console.WriteLine($"Сумма всех чисел = {summ}");