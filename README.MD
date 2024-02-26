# Bulk image resizer

This program was developed as part of a 4-hour exercise where the goal was to create a utility leveraging a NuGet package. Below you'll find information on how to use the application, its features, and what I learned during its creation.

## Application overview

The Bulk Image Resizer is a console application designed to simplify the process of resizing and converting image files. It takes a directory containing images and offers the following functionalities:

* **Resize Images:** Users can specify a maximum width in pixels to resize images while maintaining aspect ratio.
* **Scale Images:** Additionally, images can be resized using a scaler factor.
* **Change Image Format:** The application supports converting images to the .webp format, which is optimized for the web.

This tool is particularly useful for webmasters and developers who need to optimize image file sizes before uploading them to websites or web applications.

## How to use
1) Clone the repo to your local machine
2) Navigate to `./ImageService.App`
3) Execute `dotnet run` and follow the prompts
4) Converted images will be located in `./ImageService.App/output` 


## What I learned
* Importance of planning before typing down code
* Adding NuGet packages to projects
* Challenges in TDD/unit-testing in new areas (what should I expect)
 