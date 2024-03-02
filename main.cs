using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter activity number (1-5) or 0 to exit: ");
            string input = Console.ReadLine();
            if (input == "0")
                break;

            if (int.TryParse(input, out int activityNumber))
            {
                switch (activityNumber)
                {
                    case 1:
                        Activity1();
                        break;
                    case 2:
                        Activity2();
                        break;
                    case 3:
                        Activity3();
                        break;
                    case 4:
                        Activity4();
                        break;
                    case 5:
                        Activity5();
                        break;
                    default:
                        Console.WriteLine("Activity does not exist.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }

    static void Activity1()
    {
        Console.WriteLine("Activity 1 - PH Money Denomination");
      using System;

      class Program
      {
          static void Main()
          {
              Console.WriteLine("Enter the denomination of the Philippine Bank Note (Bills and Coins): ");
              string input = Console.ReadLine();

              if (double.TryParse(input, out double denomination))
              {
                  string personality = GetPersonality(denomination);
                  if (personality != "No Person is found")
                  {
                      Console.WriteLine($"Personality found in {denomination}: {personality}");
                  }
                  else
                  {
                      Console.WriteLine($"No Person is found for denomination {denomination}");
                  }
              }
              else
              {
                  Console.WriteLine($"Invalid Input: '{input}' is not a valid number.");
              }
          }

          static string GetPersonality(double denomination)
          {
              string personality = "No Person is found";

              if (denomination == 0.01 || denomination == 0.05 || denomination == 0.25)
              {
                  return personality; 
              }

              if (denomination % 1 == 0) 
              {
                  switch (denomination)
                  {
                      case 1:
                          personality = "Jose Rizal";
                          break;
                      case 5:
                          personality = "Emilio Aguinaldo";
                          break;
                      case 10:
                          personality = "Andres Bonifacio, Apolinario Mabini";
                          break;
                      case 20:
                          personality = "Manuel L. Quezon";
                          break;
                      case 50:
                          personality = "Sergio Osmena";
                          break;
                      case 100:
                          personality = "Manuel Roxas";
                          break;
                      case 200:
                          personality = "Diosdado Macapagal";
                          break;
                      case 500:
                          personality = "Benigno Sr. and Corazon Aquino";
                          break;
                      case 1000:
                          personality = "Jose Abad Santos, Vincent Lim, Josefa Llanes Escoda";
                          break;
                      default:
                          personality = "Invalid Denomination"; 
                          break;
                  }
              }
              else
              {
                  personality = "Invalid Denomination";
              }

              return personality;
          }
      }
    }

    static void Activity2()
    {
        Console.WriteLine("Activity 2 - Number Divisibility by 3 and 5");
using System;

class Program {
public static void Main(string [] args)
    {
        int X = 30;

        for (int i = 1; i <= X; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
               Console.WriteLine($"{i} - FooBar");
            }
            else if (i % 3 == 0)
            {
Console.WriteLine($"{i} - Foo");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine($"{i} - Bar");

            }
            else
            {
              Console.WriteLine(i);
            }
        }
    }
}

    }

    static void Activity3()
    {
        Console.WriteLine("Activity 3 - Input Message");
using System;

class Program {
static void Main(string[] args)
    {
        string output = "";

        Console.WriteLine("Enter Something or type 'exit' to quit:");

        string input = "";
        do
        {
            Console.Write("Enter Something: ");
            input = Console.ReadLine();

            if (input.ToLower() != "exit")
            {
                output += input + " ";
                Console.WriteLine(output);
            }
        } while (input.ToLower() != "exit");
        Console.WriteLine("\nClosing program...");
    }
}
    }

    static void Activity4()
    {
        Console.WriteLine("Activity 4 - Build Pyramid");
using System;
class Program {
    static void Main(string[] args) {
        while (true) {
            Console.Write("Enter a positive number: ");
            string input = Console.ReadLine();

            if (input == "0") {
                Console.WriteLine("Closing program...");
                break;
            }

            if (int.TryParse(input, out int numput) && numput > 0) {
                for (int i = 1; i <= numput; ++i) {
                    for (int j = 1; j <= numput - i; ++j) {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 2 * i - 1; ++k) {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else {
                Console.WriteLine("Invalid value: " + input);
            }
        }
    }
  }
    }

    static void Activity5()
    {
        Console.WriteLine("Activity 5 - Sum vs. Append");
using System;

class Program
{
    static void Main(string[] args)
    {
        int total = 0;
        string message = "";

        while (true)
        {
            Console.Write("Enter something: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            if (int.TryParse(input, out int number))
            {
                total += number;
                Console.WriteLine($"Adding {number} to {total - number} = {total}");
            }
            else
            {
                message += input;
                Console.WriteLine($"Current Message is: {message}");
            }
        }

        Console.WriteLine("Closing Program...");
    }
}
    }
}
