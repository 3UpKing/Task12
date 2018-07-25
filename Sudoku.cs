using Library;
using System;
using System.Collections;

class Sudoku
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Started");
        //Validate Args were provided
        if (args.Length != 1)
        {
            Console.WriteLine("missing args");
            System.Environment.Exit(1);
        }

        //open data file 
        InFile puzzleData = new InFile(args[0]);
        Console.WriteLine("File read.");
        //exit program if data file unreadable
        if (puzzleData.OpenError())
        {
            Console.WriteLine("Failed to open " + args[0]);
            System.Environment.Exit(1);
        }

        //process data file
        string[] data = new string[9];
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = puzzleData.ReadLine();
        }
        
        for (int i = 0; i < data.Length; i++)
        {            
            Console.WriteLine(data[i]);
        }

    }
}