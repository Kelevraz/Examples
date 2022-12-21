// вывод суммы двух чисел
//numberA - переменная

int numberA = new Random().Next(1,10); // 1 2 3 4 .... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
//можно сделать с промежуточной переменной:
//int result = numberA + numberB;
//Console.WriteLine(result);
Console.WriteLine(numberA + numberB);