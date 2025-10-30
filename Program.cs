string? menu;
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

      Console.WriteLine("Show even number array?(y)");
      string? show_even = Console.ReadLine().ToLower();

      if (show_even == "y")
      {
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
    }
    break;

    case "b":
    {
      string[] user_input_array = new string[10];
      string? user_input;
      int string_count = 0;
      bool running = true;

      //Sparar user input into array. On quit, echo from most recent -> last input. 
      while (running)
      {
        Console.WriteLine("(Quit to stop)Input: ");
        user_input = Console.ReadLine();

        if (user_input.ToLower() == "quit")
        {
          for (int i = 10; i > 0; i--)
          {
            if (string_count > 0)
            {
              string_count--;
            }

            Console.WriteLine($"{user_input_array[string_count]}");
            if (string_count <= 0)
            {
              string_count = 10;
            }
          }
          Console.ReadLine();
          running = false;
        }
        else
        {
          if (string_count == 10)
          {
            string_count = 0;
          }
          user_input_array[string_count] = user_input;
          string_count++;
        }
      }
    }
      break;

    case "c":
      {
        List<string> user_input_list = new List<string>();
        bool running = true;
        string? user_input;
        while (running)
        {

          Console.WriteLine("(Quit to stop)Input: ");
          user_input = Console.ReadLine();

          if (user_input?.ToLower() == "quit")
          {
            foreach (string line in user_input_list)
            {
              Console.WriteLine(line);
            }
            running = false;
          }

          if (user_input != "" && user_input != null)
          {
            user_input_list.Add(user_input);
          }
        }
        Console.WriteLine("\nPress enter to return to main...");
        Console.ReadLine();
      }
      break;

    case "q":
    {
      running_main = false;
    }
    break;


  }
}