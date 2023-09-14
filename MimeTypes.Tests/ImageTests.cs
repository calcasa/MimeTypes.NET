using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests;

[TestFixture]
public class ImageTests
{
    [TestCase(MimeType.Image.Avif, "image/avif")]
    [TestCase(MimeType.Image.Bmp, "image/bmp")]
    [TestCase(MimeType.Image.Gif, "image/gif")]
    [TestCase(MimeType.Image.Heic, "image/heic")]
    [TestCase(MimeType.Image.Heif, "image/heif")]
    [TestCase(MimeType.Image.Jpeg, "image/jpeg")]
    [TestCase(MimeType.Image.JpegXl, "image/jxl")]
    [TestCase(MimeType.Image.Png, "image/png")]
    [TestCase(MimeType.Image.SvgXml, "image/svg+xml")]
    [TestCase(MimeType.Image.Tiff, "image/tiff")]
    [TestCase(MimeType.Image.VndMicrosoftIcon, "image/vnd.microsoft.icon")]
    [TestCase(MimeType.Image.Webp, "image/webp")]
    public void AssertImageMimeTypeValue(string valueUnderTest, string expectedValue)
    {
        Assert.That(valueUnderTest, Is.EqualTo(expectedValue));
    }
}
