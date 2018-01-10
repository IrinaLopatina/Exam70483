using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Exam70483_10
{
    public class ImageFileHandler
    {
        string imageInBinaryPath = @"D:/ImageInBinary.dat";
        string imagePath = @"D:/Image.jpg";

        public void DeleteOldImageFiles()
        {
            File.Delete(imageInBinaryPath);
            File.Delete(imagePath);
        }

        /// <summary>
        /// Save Image in given file path
        /// </summary>
        /// <param name="imageData">image stream bytes array</param>
        /// <param name="fileName">complete file path</param>
        public void SaveImageInBinary(byte[] imageData, string fileName = @"D:/ImageInBinary.dat")
        {
            FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            file.Write(imageData, 0, imageData.Length);
            file.Close();
        }

        /// <summary>
        /// Returns File Bytes Array at given path
        /// </summary>
        /// <param name="fileName">complete file path</param>
        /// <returns>byte array of given file</returns>
        public byte[] GetFileBytes(string fileName = @"D:/ImageInBinary.dat")
        {
            FileStream readFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            byte[] readImageData = new byte[readFile.Length];
            int bytes = readFile.Read(readImageData, 0, readImageData.Length);
            //int index = 0;
            //while (bytes < 0)
            //{
            //    readImageData[index] = (byte)readFile.ReadByte();
            //    index++;

            //}
            readFile.Close();

            return readImageData;
        }

        /// <summary>
        /// Save File Bytes at given path as an image
        /// </summary>
        /// <param name="fileName">complete file path</param>
        /// <param name="fileBytes">file bytes of the image</param>
        public void SaveImage(byte[] fileBytes, string fileName = @"D:/Image.jpg")
        {
            Image img = Image.FromStream(new MemoryStream(fileBytes));
            //save the image in local location
            img.Save(fileName);
        }
    }
}
