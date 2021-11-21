using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Класс для обработки изображений используемых в формах
    /// </summary>
    static class ImageHandler
    {
        /// <summary>
        /// Получить изображение по указанному пути, кесли по указанному пути изображение отсутствует, вернуть null
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Image GetImage(string path)
        {
            try
            {
                return Image.FromFile(path);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Заполнение pictureBox переданным изображением
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="image"></param>
        public static void FillPictureBox(PictureBox pictureBox, Image image)
        {
            if (pictureBox == null)
                throw new ArgumentNullException("PictureBox pictureBox не может быть null");

            pictureBox.Image = image ?? throw new ArgumentNullException("Image image не может быть null");

            int width = pictureBox.Width;
            int height = pictureBox.Height;

            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;


            if ((pictureBox.Image.Width > width) || (pictureBox.Image.Height > height))
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                double mh = (double)height / (double)pictureBox.Image.Height;
                double mw = (double)width / (double)pictureBox.Image.Width;

                if (mh < mw)
                {
                    pictureBox.Width = Convert.ToInt16(pictureBox.Image.Width * mh);
                    pictureBox.Height = height;
                }
                else
                {
                    pictureBox.Width = width;
                    pictureBox.Height = Convert.ToInt16(pictureBox.Image.Height * mw);
                }
            }

            pictureBox.Left = pictureBox.Location.X + (width - pictureBox.Width) / 2;
            pictureBox.Top = pictureBox.Location.Y + (height - pictureBox.Height) / 2;
        }

        /// <summary>
        /// Создание копии переданного изображения с указанными размерами, с сохранением пропорций
        /// </summary>
        /// <param name="image"></param>
        /// <param name="newWidth"></param>
        /// <param name="newHeight"></param>
        /// <returns></returns>
        public static Image ResizeImage(Image image, int newWidth, int newHeight)
        {
            if (image == null)
                throw new ArgumentNullException("Image image не может быть null");

            int sourceWidth = image.Width;
            int sourceHeight = image.Height;

            if (sourceWidth < sourceHeight)
            {
                int buff = newWidth;

                newWidth = newHeight;
                newHeight = buff;
            }

            int sourceX = 0, sourceY = 0, destX = 0, destY = 0;
            float nPercent = 0, nPercentW = 0, nPercentH = 0;

            nPercentW = ((float)newWidth / (float)sourceWidth);
            nPercentH = ((float)newHeight / (float)sourceHeight);

            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((newWidth - (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((newHeight - (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);


            Bitmap bmPhoto = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);

            bmPhoto.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.White);
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(image, new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight), GraphicsUnit.Pixel);

            grPhoto.Dispose();
            image.Dispose();

            return bmPhoto;
        }
    }
}
