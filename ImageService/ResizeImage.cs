using System.Reflection;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace ImageService;

public static class ResizeImage
{
    public static void ResizeWithScale(double scale)
    {
        using Image image = Image.Load("input/group.jpg");

        int newWidth = (int)(image.Width * scale);
        
        image.Mutate(x => x
            .Resize(newWidth, 0));

        image.Save("output/Stockholm_out.png");
    }
}
