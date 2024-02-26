﻿namespace ImageService.App;

public class Program
{
    private static List<string> imageEncodingExtensions = new List<string>()
    {
        ".jpeg",
        ".jpg",
        ".png",
    };

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to ImageResizer");
        Console.WriteLine("Please provide a path to a directory containing images: ");

        DirectoryInfo inputDir;
        do
        {
            Console.Write("> ");
            inputDir = new DirectoryInfo(Console.ReadLine());
        } while (!inputDir.Exists);
        
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("Press [1] to resize image with a max pixel width");
        Console.WriteLine("Press [2] to resize image with a scale");

        string userCommand;
        do
        {
            Console.Write("> ");
            userCommand = Console.ReadLine();
        } while (!new string[] {"1", "2"}.Contains(userCommand));

        switch (userCommand)
        {
            case "1":
                Console.WriteLine("What is the max pixel width?");
                Console.Write("> ");
                int maxPixelWidth = int.Parse(Console.ReadLine());
                ProcessAllImagesInDirectory(inputDir, "ResizeToMaxPixelWidth", maxPixelWidth);
                break;
            case "2":
                Console.WriteLine("What is the scale?");
                Console.Write("> ");
                int scale = (int) (double.Parse(Console.ReadLine()) * 100);
                Console.WriteLine($"Scale: {scale}");
                ProcessAllImagesInDirectory(inputDir, "ResizeWithScale", scale);
                break;
        }
    }
    
    private static void ProcessAllImagesInDirectory(DirectoryInfo inputDir, string operation, int argument)
    {
        foreach (FileInfo file in inputDir.GetFiles())
        {
            if (!imageEncodingExtensions.Contains(file.Extension)) continue;
            Console.WriteLine($"Processing {file.Name}");
            
            switch (operation)
            {
                case "ResizeToMaxPixelWidth":
                    ResizeImage.ResizeToMaxPixelWidth(argument, file);
                    break;
                case "ResizeWithScale":
                    ResizeImage.ResizeWithScale(argument, file);
                    break;
            }
        }
    }
}