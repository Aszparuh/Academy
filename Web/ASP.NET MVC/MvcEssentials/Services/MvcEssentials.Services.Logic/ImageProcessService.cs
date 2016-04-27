namespace MvcEssentials.Services.Logic
{
    using System.IO;
    using System.Drawing;

    using ImageProcessor;
    using ImageProcessor.Imaging;
    using ImageProcessor.Imaging.Formats;
    using Common;

    public class ImageProcessService
    {
        public byte[] Resize(byte[] originalImage, int width)
        {
            using (var originalImageStream = new MemoryStream(originalImage))
            {
                using (var resultImage = new MemoryStream())
                {
                    using (var imageFactory = new ImageFactory())
                    {
                        var createdImage = imageFactory
                                .Load(originalImageStream);

                        if (createdImage.Image.Width > width)
                        {
                            createdImage = createdImage
                                .Resize(new ResizeLayer(new Size(width, 0), ResizeMode.Max));
                        }

                        createdImage
                            .Format(new JpegFormat { Quality = Constants.ImageQuality })
                            .Save(resultImage);
                    }

                    return resultImage.GetBuffer();
                }
            }
        }
    }
}
