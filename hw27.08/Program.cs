//task1

//int numb;
//Console.WriteLine("Enter the number: ");
//numb =Convert.ToInt32(Console.ReadLine());

//if(numb>100 || numb < 0)
//{
//    Console.WriteLine("Invalid number");
//}
//else if (numb % 15 == 0)
//{
//    Console.WriteLine("Fizz Buzz");
//}
//else if (numb % 3 == 0)
//{
//    Console.WriteLine("Fizz");
//}
//else if (numb % 5 == 0)
//{
//    Console.WriteLine("Buzz");
//}
//else
//{
//    Console.WriteLine(numb);
//}


//task2

//Console.WriteLine("Enter the temperature: ");
//int temp;
//temp = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter 1 to convert temperature from Celsius to Fahrenheit, 2 to convert from Fahrenheit to Celsius.");
//int choice;
//choice = Convert.ToInt32(Console.ReadLine());
//if (choice == 1)
//{
//    Console.WriteLine((temp*9/5)+32);
//}
//else if (choice == 2) {
//    Console.WriteLine((temp-32)*5/9);
//}
//else
//{
//    Console.WriteLine("Incorrect choice");
//}




//task3

//Console.WriteLine("Enter 2 numbers: ");
//int numb1, numb2,tmp;
//numb1 = Convert.ToInt32(Console.ReadLine());
//numb2 = Convert.ToInt32(Console.ReadLine());
//if (numb1 > numb2) {
//    tmp = numb1;
//    numb1 = numb2;
//    numb2 = tmp;
//}
//for (int i = numb1; i <= numb2; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.Write(i+"  ");
//    }
//}


//task4

//Console.WriteLine("Enter six digit number: ");
//int numb,result=0;
//numb = Convert.ToInt32(Console.ReadLine());

//while (numb > 0)
//{   int n=numb % 10;
//    result = result * 10 + n;
//    numb=numb / 10;
//}
//Console.WriteLine("result is "+ result);



//task5

//Console.WriteLine("enter the start and the end: ");
//int start, end;
//start = Convert.ToInt32(Console.ReadLine());
//end = Convert.ToInt32(Console.ReadLine());
//int a = 0;
//int b = 1;
//int current = 0;

//while (current <= end)
//{
//    if (current >= start)
//    {
//        Console.Write(current+ " ");
//    }

//    a = b;
//    b = current;
//    current = a + b;
//}

//task6

//int a, b;
//Console.WriteLine("Enter a and b (b>a) : ");
//a = Convert.ToInt32(Console.ReadLine());
//b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();

//for (int i = a; i <= b; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write(i + " ");
//    }
//    Console.WriteLine();
//}


//task7

//char ch;
//int length, choice;

//Console.WriteLine("Enter the symbol: ");
//ch = Convert.ToChar(Console.ReadLine());
//Console.WriteLine("Enter the length: ");
//length = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Horizontal or vertical (1 for horizontal, 2 for vertical)");
//choice = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine();

//for (int i = 0; i < length; i++)
//{
//    if (choice==1)
//    {
//        Console.Write(ch);
//    }
//    else if (choice == 2)
//    {
//        Console.WriteLine(ch);
//    }
//    else
//    {
//        Console.WriteLine("invalid choice");
//        break;
//    }
//}