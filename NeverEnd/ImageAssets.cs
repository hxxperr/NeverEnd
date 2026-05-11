using System;
using System.Drawing;
using System.IO;

namespace NeverEnd
{
    internal static class ImageAssets
    {
        private static readonly string ResourcesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

        public static Image LoadImage(string fileName)
        {
            string path = Path.Combine(ResourcesPath, fileName);

            if (!File.Exists(path))
            {
                return null;
            }

            using (Image image = Image.FromFile(path))
            {
                return new Bitmap(image);
            }
        }
    }
}
