using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace ImageService;

public static class ResizeImage
{
    public static void ResizeToMaxPixelWidth(int maxWidth, FileInfo file)
    {
        Image image = Image.Load(file.FullName);
        if (image.Width < maxWidth)
        {
            Console.WriteLine("Image width within bound.");
            return;
        }
        
        Console.WriteLine($"{image.Width}px ==> {maxWidth}px");
        
        image.Mutate(x => x
            .Resize(maxWidth, 0));

        image.Save($"output/resized_{file.Name}");
    }
    
    public static void ResizeWithScale(int scale, FileInfo file)
    {
        Image image = Image.Load(file.FullName);
        
        int newWidth = (int)(image.Width * (scale / 100.0));
        
        Console.WriteLine($"{image.Width}px ==> {newWidth}px");
        
        image.Mutate(x => x
            .Resize(newWidth, 0));

        image.Save($"output/resized_{file.Name}");
    }
}
    
