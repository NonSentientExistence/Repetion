string? menu;
bool running_main = true;

while (running_main)
{
  ConsoleClear();
  Console.WriteLine("Choose function");
  Console.WriteLine("A: Loop Arrays -- B: Input to Array -- C: Input to List -- D: Echo from file -- E: Grid");
  menu = Console.ReadLine()?.ToLower();
  switch (menu)
  {
    case "a": //Looping arrays
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
        string? show_even = Console.ReadLine()?.ToLower();

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

    case "b": //Save input, loop through and display
      {
        string[] user_input_array = new string[10];
        string? user_input;
        int string_count = 0;
        bool running = true;

        //On quit, echo from most recent -> last input. 
        while (running)
        {
          Console.WriteLine("(Quit to stop)Input: ");
          user_input = Console.ReadLine();

          if (user_input?.ToLower() == "quit")
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

    case "c": //Adds to list, displays in quit
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

    case "d": // Read from file. If !Exists, create. 
    //Creates file and dir
      {
        if (!File.Exists(Path.Combine("Data", "Extra.CSV")))
        {
          if (!Directory.Exists("Data"))
          {
            Directory.CreateDirectory("Data");
          }
          File.Create(Path.Combine("Data", "Extra.CSV")).Close();
        }

        string? line;
        //Read from file. If empty, populate the file
        try
        {
          using (StreamReader Reader = new StreamReader(Path.Combine("Data", "Extra.CSV")))
          {
            string? firstline = Reader.ReadLine();
            if (firstline == null || firstline == "")
            {
              Reader.Close();
              string[] LinesAdd = new string[10];

              for (int i = 0; i < 10; i++)
              {
                LinesAdd[i] = $"This is the {(i + 1)} senctence";
              }

              using (StreamWriter Writer = new StreamWriter(Path.Combine("Data", "Extra.CSV")))
              {
                foreach (string LineAdd in LinesAdd)
                {
                  Writer.WriteLine(LineAdd);
                }
              }
            }

          }
        }

        catch { Console.WriteLine("File could not be read!"); }
        //Echos file lines
        try
        {
          using (StreamReader Reader = new StreamReader(Path.Combine("Data", "Extra.CSV")))
          {
            while ((line = Reader.ReadLine()) != null)
            {
              Console.WriteLine(line);
            }
          }
        }
        catch { Console.WriteLine("File could not be read!"); }

        Console.WriteLine("\nEvery other line\n");
        //Echos every other line. Uses a bool in loop to just echo every other line
        try
        {
          bool changeling = true; 

          using (StreamReader Reader = new StreamReader(Path.Combine("Data", "Extra.CSV")))
          {
            while ((line = Reader.ReadLine()) != null)
            {
              if (changeling)
              {
                Console.WriteLine(line);
                changeling = false;
              }
              else if(!changeling)
              {
                changeling = true;
              }
            }
          }
        }
        catch { Console.WriteLine("File could not be read!"); }

        Console.ReadLine();
      }
      break;

    case "e":
      {
        int width = 9;
        int lenght = 9;
        int array_lenght = width * lenght;

        string[] grid = new string[array_lenght];

        for (int i = width; i > 0; i--)
        {
          Console.Write("|");
          for (int j = lenght; j > 0; j--)
          {
            Console.Write("_|");
          }
          Console.WriteLine("");
        }
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

void ConsoleClear()
{
  try { Console.Clear(); }
  catch { }
}