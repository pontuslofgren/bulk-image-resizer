using System.Reflection;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace ImageService;

public static class ResizeImage
{
    private static readonly string _executionDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
    private static readonly string _filePath = Path.Combine(_executionDirectory, "input");

    public static void ResizeWithScale(int scale)
    {
        using Image image = Image.Load(Path.Combine(_filePath, "stockholm.jpeg"));
        image.Mutate(x => x
            .Resize(image.Width / 2, image.Height / 2));

        image.Save(Path.Combine(_filePath, "output", "stockholm.jpeg"));
    }
}
