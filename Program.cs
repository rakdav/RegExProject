using System.Text;

Console.Write("Введите число:");
int n;
int.TryParse(Console.ReadLine(), out n);
Console.WriteLine(OurLibrary.OurClass.ToBinary(n));
Console.WriteLine(OurLibrary.OurClass.ToOctal(n));
Console.WriteLine(OurLibrary.OurClass.ToHex(n));


