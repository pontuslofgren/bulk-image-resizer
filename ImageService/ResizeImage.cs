using System.Reflection;
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
        
        image.Mutate(x => x
            .Resize(maxWidth, 0));

        image.Save($"output/resized_{file.Name}");
    }
    
    public static void ResizeWithScale(double scale, FileInfo file)
    {
        Image image = Image.Load(file.FullName);
        int newWidth = (int)(image.Width * scale);
        
        image.Mutate(x => x
            .Resize(newWidth, 0));

        image.Save($"output/resized_{file.Name}");
    }
}
    
