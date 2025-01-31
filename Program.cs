using static Collections.ArraySumAverages;
using static Collections.Colors;
using static Collections.Frequencies;
using static Collections.GradeBooks;
using static Collections.Lists;
using static Collections.Products;


    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Method 1 (Loop)
        (int sum1, double avg1) = ArrayOperations.CalculateSumAndAverage(numbers);
        Console.WriteLine("Method 1 (Loop):");
        Console.WriteLine($"Sum: {sum1}");
        Console.WriteLine($"Average: {avg1}");

        // Method 2 (LINQ)
        (int sum2, double avg2) = ArrayOperations.CalculateSumAndAverageLinq(numbers);
        Console.WriteLine("\nMethod 2 (LINQ):");
        Console.WriteLine($"Sum: {sum2}");
        Console.WriteLine($"Average: {avg2}");

        // Method 3 (User Input)
        Console.WriteLine("\nEnter the numbers separated by spaces (e.g., 10 20 30):");
        string input = Console.ReadLine();

        (int sum3, double avg3) = ArrayOperations.CalculateSumAndAverageFromInput(input);
        Console.WriteLine("\nMethod 3 (User Input):");
        Console.WriteLine($"Sum: {sum3}");
        Console.WriteLine($"Average: {avg3}");

        Console.ReadKey();
    }


    {
        List<int> numbers = new List<int>() { 5, 15, 2, 25, 8, 12, 3, 18, 9, 11 };

        // Method 1 (Loop)
        int sum1 = ListOperations.SumGreaterThan10(numbers);
        Console.WriteLine("Method 1 (Loop):");
        Console.WriteLine($"Sum of numbers greater than 10: {sum1}");

        // Method 2 (LINQ)
        int sum2 = ListOperations.SumGreaterThan10Linq(numbers);
        Console.WriteLine("\nMethod 2 (LINQ):");
        Console.WriteLine($"Sum of numbers greater than 10: {sum2}");

        Console.ReadKey();
    }


    {
        GradeBook gradeBook = new GradeBook(); // Create an instance of the GradeBook

        // Add some student names and grades
        gradeBook.AddStudentGrade("James Harden", "A");
        gradeBook.AddStudentGrade("Lebron James", "B");
        gradeBook.AddStudentGrade("Kawhi Leonard", "C");
        gradeBook.AddStudentGrade("Shaquille O'neal", "A+");

        // Retrieve and display the grade (Method 1: Direct access)
        string studentName = "Lebron James";
        string grade = gradeBook.GetGrade(studentName);

        if (grade != null)
        {
            Console.WriteLine($"{studentName}'s grade is: {grade}");
        }
        else
        {
            Console.WriteLine($"{studentName} not found in the records.");
        }

        // Retrieve and display the grade (Method 2: Using TryGetValue)
        string anotherStudent = "Eve";
        string theGrade = gradeBook.GetGradeSafe(anotherStudent); // Using the safe method

        if (theGrade != null)
        {
            Console.WriteLine($"{anotherStudent}'s grade is: {theGrade}");
        }
        else
        {
            Console.WriteLine($"{anotherStudent} not found in the records.");
        }

        // Display all students and grades
        gradeBook.DisplayAllGrades();

        Console.ReadKey();
    }


    {
        List<int> numbers = new List<int>() { 1, 2, 2, 3, 1, 4, 2, 5, 1, 3, 3 };

        // Method 1 (Loop)
        Dictionary<int, int> freqMap1 = FrequencyCounter.CountFrequencies(numbers);
        Console.WriteLine("Method 1 (Loop):");
        FrequencyCounter.PrintFrequencyMap(freqMap1);

        // Method 2 (LINQ)
        Dictionary<int, int> freqMap2 = FrequencyCounter.CountFrequenciesLinq(numbers);
        Console.WriteLine("\nMethod 2 (LINQ):");
        FrequencyCounter.PrintFrequencyMap(freqMap2);

        // Method 3 (User Input)
        Console.WriteLine("\nEnter integers separated by spaces (e.g., 1 2 2 3):");
        string input = Console.ReadLine();
        Dictionary<int, int> userFreqMap = FrequencyCounter.CountFrequenciesFromInput(input);
        Console.WriteLine("\nUser Input Frequency:");
        FrequencyCounter.PrintFrequencyMap(userFreqMap);


        Console.ReadKey();
    }

    {
        // 1. Create and initialize the List<string> of colors (example)
        List<string> colors = new List<string>() { "Red", "Green", "Blue", "Yellow", "Purple" };

        // 2. Print the colors using the method
        ColorPrinter.PrintColors(colors);

        // 3. Get colors from user and print them:
        List<string> userColors = ColorPrinter.GetColorsFromUser();
        Console.WriteLine("\nColors you entered:");
        ColorPrinter.PrintColors(userColors);


        Console.ReadKey();
    }


    {
        ProductCatalog catalog = new ProductCatalog(); // Create an instance of the ProductCatalog

        // Add some products to the catalog
        catalog.AddProduct("BMW", 125000.50);
        catalog.AddProduct("BRABUS MERCEDES", 300000.30);
        catalog.AddProduct("MANSORY", 400000.50);
        catalog.AddProduct("NISSAN PATROL LIMITED EDITION", 200000.00);

        // Print the product prices
        catalog.PrintProductPrices();

        Console.ReadKey();
    }
