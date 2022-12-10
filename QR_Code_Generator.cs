Here is a simple console application in C# that generates a QR code:

```csharp
using System;
using QRCoder;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the text to generate QR Code:");
        string qrText = Console.ReadLine();
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);
        Bitmap qrCodeImage = qrCode.GetGraphic(20);
        qrCodeImage.Save("QRCode.png", System.Drawing.Imaging.ImageFormat.Png);
        Console.WriteLine("QR Code generated and saved as QRCode.png");
    }
}
```

Please note that this code requires the QRCoder library. You can install it via NuGet package manager in Visual Studio.