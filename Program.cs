string menu;
bool running_main = true;

while (running_main)
{
  Console.WriteLine("Choose function");
  Console.WriteLine("A: Loop Arrays -- B: Input to Array -- C: Input to List -- D: Echo from file");
  menu = Console.ReadLine().ToLower();
  switch (menu)
  {
    case "a":
    {
      int[] numbers = new int[10];

      for (int i = 0; i < 11; i++)
      {
        Console.WriteLine($"{i}");
      }

      Console.WriteLine();

      for (int i = 1; i < 11; i++)
      {
        Console.WriteLine($"{i}");
      }

      Console.WriteLine();

      for (int i = 0; i < 10; i++)
      {
        numbers[i] = i + 1;
      }

      Console.WriteLine();

      int[] even_numbers = new int[50];
      int array_counter = 0;
      for (int i = 0; i < 100; i++)
      {
        if ((i + 1) % 2 == 0)
        {
          even_numbers[array_counter] = i + 1;
          array_counter++;
        }
        else
        {
          continue;
        }
      }
    }
    break;

    case "q":
    {
      running_main = false;
    }
    break;


  }
}      