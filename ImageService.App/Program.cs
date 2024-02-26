namespace ImageService.App;

public class Program
{

    static void Main(string[] args)
    {
        // TODO: wrap in loop. Validate that filepath exists.
        Console.WriteLine("Welcome to ImageResizer");
        Console.WriteLine("Please provide a path to a directory containing images: ");
        Console.Write("> ");
        string InputDirectoryPath = Console.ReadLine();

        var resizer = new ResizeImage(InputDirectoryPath);

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
                break;
            case "2":
                Console.WriteLine("What is the scale?");
                Console.Write("> ");
                int scale = int.Parse(Console.ReadLine());
                break;
        }
    }
}