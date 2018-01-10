using System;

namespace Exam70483_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageFileHandler = new ImageFileHandler();
            byte[] imageData = ImageLoader.DownloadImageStream(@"http://s3-eu-west-1.amazonaws.com/pravdasevera/9bhucv08/w45p.jpg");

            imageFileHandler.DeleteOldImageFiles();

            //save this image as bytes in file
            imageFileHandler.SaveImageInBinary(imageData, @"D:/ImageInBinary.dat");

            //now reads the bytes of an image from file
            byte[] readFileData = imageFileHandler.GetFileBytes(@"D:/ImageInBinary.dat");

            //Now Save Image Bytes as Image File
            imageFileHandler.SaveImage(readFileData, @"D:/Image.jpg");
            Console.WriteLine("Done Challenge.");       
        }
    }
}



