namespace ImageService.App;

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
        // TODO: wrap in loop. Validate that filepath exists.
        Console.WriteLine("Welcome to ImageResizer");
        Console.WriteLine("Please provide a path to a directory containing images: ");
        Console.Write("> ");
        var inputDir = new DirectoryInfo(Console.ReadLine());

        // TODO: wrap in loop. Validate correct input. Add exit.
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("Press [1] to resize image with a max pixel width");
        Console.WriteLine("Press [2] to resize image with a scale");
        Console.Write("> ");
        string userCommand = Console.ReadLine();

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
                int scale = int.Parse(Console.ReadLine());
                break;
        }
    }
    
    // TODO: consider using enum for operations
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
                case "ResizeWithScale"
                    ResizeImage.ResizeWithScale(argument, file);
                    break;
            }
        }
    }
}