Console.WriteLine($"\nЗадача 25. Возведене числа A в натуральную степень B");

int Exponentiation(int numA, int numB){
  int result = 1;
  for(int i=1; i <= numB; i++){
    result = result * numA;
  }
    return result;
}

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int numberA = ReadData("Введите число А: ");
int numberB = ReadData("Введите число В: ");
int exponentiation = Exponentiation(numberA,numberB);

Console.WriteLine($"{numberA} в  степени {numberB} равно: {exponentiation}");
