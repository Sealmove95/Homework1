int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2 && num1 > num3)
  {
    Console.WriteLine(num1);
  }
if (num2 > num1 && num2 > num3)
  {
    Console.WriteLine(num2);
  }
if (num3 > num2 && num3 > num1)
  {
    Console.WriteLine(num3);
  }
