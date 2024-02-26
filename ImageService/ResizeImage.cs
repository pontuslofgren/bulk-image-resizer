using System.Reflection;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace ImageService;

public static class ResizeImage
{
    public static void ResizeWithScale(int scale)
    {
        using Image image = Image.Load("input/group.jpg");
        image.Mutate(x => x
            .Resize(image.Width / scale, image.Height / scale));

        image.Save("output/Stockholm_out.png");
    }
}
