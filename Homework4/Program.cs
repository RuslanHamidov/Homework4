namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            //Console.WriteLine("Enter three integers: ");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a > b && a >c)
            //{
            //    Console.WriteLine($"a is the greatest");
            //}
            //else if(b > a && b > c)
            //{
            //    Console.WriteLine($"b is the greatest");
            //}
            //else if(c > a && c > b)
            //{
            //    Console.WriteLine($"c is the greatest");
            //}


            #endregion
            #region Task2

            // Console.WriteLine("Enter three integers: ");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a > b && a >c || a > b && a == c || a > c && a == b  )
            //{
            //    Console.WriteLine($"a is the greatest");
            //}
            //else if(b > a && b > c || b > a && b == c || b > c && b == a)
            //{
            //    Console.WriteLine($"b is the greatest");
            //}
            //else if(c > a && c > b || c > b && c == a || c > a && c == b)
            //{
            //    Console.WriteLine($"c is the greatest");
            //}
            //else 
            //{
            //     Console.WriteLine($"a b c are equal to each other");
            //}

            #endregion
            #region Task3

            //Console.WriteLine("Enter two numbers:");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());    
            //Console.WriteLine("Choose operation: (+) (-) (*) (/)");
            //char op = char.Parse(Console.ReadLine());
            //int result;



            //switch(op)
            //{
            //    case '+':
            //    result = a + b;
            //    Console.WriteLine(result);
            //    break;
            //   case '-':
            //    result = a - b;
            //    Console.WriteLine(result);
            //    break;
            //   case '*':
            //    result = a * b;
            //    Console.WriteLine(result);
            //    break;
            //   case '/':
            //    result = a / b;
            //    Console.WriteLine(result);
            //    break;
            //    default:
            //    Console.WriteLine("Invalid operator");
            //    break;
            //} 
            #endregion
            #region Task4
            //Console.WriteLine("Enter two numbers:");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());    
            //Console.WriteLine("Choose operation: (+) (-) (*) (/)");
            //char op = char.Parse(Console.ReadLine());
            //int result;

            //if (op == '+')
            //{
            //    result = a + b;
            //    Console.WriteLine(result);
            //}
            //else if (op == '-')
            //{
            //    result = a - b;
            //    Console.WriteLine(result);
            //}
            //else if (op == '*')
            //{
            //    result = a * b;
            //    Console.WriteLine(result);
            //}
            //else if (op == '/')
            //{
            //    result = a / b;
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //   Console.WriteLine("Invalid operation"); 
            //}

            #endregion
            #region Task5

            //Console.WriteLine("Enter two numbers:");
            //float a = float.Parse(Console.ReadLine());
            //float b = float.Parse(Console.ReadLine()); 
            //float sum = a + b;

            //if(sum > 100)
            //{
            //    float b1 = b/2;
            //    float sum2 = a + b1;
            //    Console.WriteLine($"{a} + {b1} ="+ sum2);
            //}
            //else
            //{
            //    Console.WriteLine(sum);
            //}


            #endregion
            #region Task6
            //int a = 5;
            //Console.WriteLine("Guess a number 0-10:");
            //int b = int.Parse(Console.ReadLine());


            //switch (b)
            //{
            //    case 0:
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //        Console.WriteLine("Try greater");
            //        b = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Try greater");
            //        b = int.Parse(Console.ReadLine());                   
            //        Console.WriteLine("You lost");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //    case 9:
            //    case 10:
            //        Console.WriteLine("Try less");
            //        b = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Try less");
            //        b = int.Parse(Console.ReadLine());  
            //        Console.WriteLine("You lost");
            //        break;
            //    case 5:
            //        Console.WriteLine("You won");
            //        break;
            //    default:
            //        Console.WriteLine("Out of range");
            //        break;              

            //}



            #endregion
            #region Task7
            //Console.WriteLine("Enter two numbers:");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //if (a > b)
            //{
            //    string c = a % 2 == 0 ? "odd" : "even";
            //    Console.WriteLine("A is " + c);
            //}
            //else if (b > a)
            //{
            //    string d = b % 2 == 0 ? "odd" : "even";
            //    Console.WriteLine("B is " + d);

            //}
            #endregion
            #region Task8
            //Console.WriteLine("Enter a month:");
            //string month = Console.ReadLine();

            //switch (month) 

            //{
            //    case "december":
            //    case "january":
            //    case "february":
            //        Console.WriteLine("Winter");
            //        break;
            //    case "march":
            //    case "april":
            //    case "may":
            //        Console.WriteLine("Spring");
            //        break;
            //    case "june":
            //    case "july":
            //    case "august":
            //        Console.WriteLine("Summer");
            //        break;
            //    case "september":
            //    case "october":
            //    case "november":
            //        Console.WriteLine("Fall");
            //        break;
            //    default: Console.WriteLine("Unknown month");
            //        break;

            //}



            #endregion
            #region Task9

            //Console.WriteLine("Type 'start'");
            //string game = Console.ReadLine();

            //switch (game) 

            //{
            //    case "start":
            //        Console.WriteLine("Who invented algebra of logic?: \na.Albert Einstein b. Isaac Newton c. George Boole d. Aristotle ");
            //        game = Console.ReadLine();
            //        goto case "second";
            //    case "second" when game "c":
            //        Console.WriteLine("Who invented algebra of logic?: \na.Albert Einstein b. Isaac Newton c. George Boole d. Aristhotel ");
            //        game = Console.ReadLine();
            //        break;

            //}

            Console.WriteLine("Millionaire game");
            Console.WriteLine("Who invented algebra of logic?: \na.Albert Einstein b. Isaac Newton c. George Boole d. Aristotle ");
            char game = char.Parse(Console.ReadLine());
            
            if (game == 'c')
            {
                Console.WriteLine("Next question");
                Console.WriteLine("Which type of language is C#?: \na.Compiled b. Interpreted c. Uninterpreted d. Decompiled ");
                game = char.Parse(Console.ReadLine());
                if (game == 'a')
                {
                    Console.WriteLine("Next question");
                    Console.WriteLine("Which language is the closest to machine language?: \na.Python b. C Language c. Basic d. Assembly ");
                    game = char.Parse(Console.ReadLine());
                    if(game == 'd')
                    {
                        Console.WriteLine("You won!");
                    }
                }
                           
            }
            else
            {
                Console.WriteLine("You lost");
            }


            #endregion
            #region Task10


            //Console.WriteLine("Enter three sides of triangle");

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if(a + b > c || a + c > b || b + c > a)
            //{
            //    Console.WriteLine(true);
            //}
            //else { Console.WriteLine(false); }


            #endregion
            #region Task11
            //Console.WriteLine("Enter day of the week by number:");

            //int day = int.Parse(Console.ReadLine());

            //switch (day)

            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown day");
            //        break;


            //}

            #endregion
            #region Task12


            //Console.WriteLine("Enter number 0-5");
            //int a = int.Parse(Console.ReadLine());

            //switch (a)

            //{
            //    case 0:
            //        Console.WriteLine("Zero");
            //        break;
            //    case 1:
            //        Console.WriteLine("One");
            //        break;
            //    case 2:
            //        Console.WriteLine("Two");
            //        break;
            //    case 3:
            //        Console.WriteLine("Three");
            //        break;
            //    case 4:
            //        Console.WriteLine("Four");
            //        break;
            //    case 5:
            //        Console.WriteLine("Five");
            //        break;




            //}




            #endregion
        }
    }
}