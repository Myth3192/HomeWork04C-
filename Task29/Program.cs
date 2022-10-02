Console.WriteLine("Введите элементы массива");
string []array = new string[8];
for (int i=0; i<8; i++)
{   
    string number =Console.ReadLine();
    array[i] = number;
}

array = array.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
Console.WriteLine("[{0}]", string.Join(", ", array));
