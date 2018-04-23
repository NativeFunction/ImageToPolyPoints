using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

namespace Classes.ImageToPolyPoints
{
    internal class PolyPointGenerator
    {
        public Bitmap Image;

        private Pass _pass = new Pass();

        public PolyPointGenerator(Bitmap image)
        {
            Image = image;
            LoadData();
        }

        public void Close()
        {
            Image.Dispose();
        }

        public List<Point> GenerateAsList(float accuracy, Size pointOrigin = default(Size))
        {
            if (accuracy > 1f)
                accuracy = 1f;
            else if (accuracy <= 0f)
                accuracy = 0.1f;

            accuracy = 1 / accuracy;

            List<Point> finalPoints = new List<Point>();

            finalPoints.AddRange(Pass.GenerateLOD(accuracy, _pass.Top, pointOrigin));
            finalPoints.AddRange(Pass.GenerateLOD(accuracy, _pass.Right, pointOrigin));
            finalPoints.AddRange(Pass.GenerateLOD(accuracy, _pass.Bottom, pointOrigin));
            finalPoints.AddRange(Pass.GenerateLOD(accuracy, _pass.Left, pointOrigin));

            return finalPoints;
        }

        private void LoadData()
        {
            BitmapData data = Image.LockBits(new Rectangle(0, 0, Image.Size.Width, Image.Size.Height),
                ImageLockMode.ReadOnly, Image.PixelFormat);

            unsafe
            {
                int* ptr = (int*)data.Scan0;
                int bytesPerPixel = ((int)Image.PixelFormat) >> 11 & 31;

                //top
                for (int x = 0; x < data.Width; x++)
                {
                    for (int y = 0; y < data.Height; y++)
                    {
                        int* sel = ptr + (y * data.Width + x);

                        Color pixel = Color.FromArgb(*sel);
                        if (pixel.A != 0 && !_pass.Contains(new Point(x, y)))
                        {
                            _pass.Top.Add(new Point(x, y));
                            break;
                        }
                    }
                }

                //bottom
                for (int x = 0; x < data.Width; x++)
                {
                    for (int y = data.Height - 1; y >= 0; y--)
                    {
                        int* sel = ptr + (y * data.Width + x);

                        Color pixel = Color.FromArgb(*sel);
                        if (pixel.A != 0 && !_pass.Contains(new Point(x, y)))
                        {
                            _pass.Bottom.Add(new Point(x, y));
                            break;
                        }
                    }
                }

                //left
                for (int y = 0; y < data.Height; y++)
                {
                    int* row = ptr + (y * data.Width);

                    for (int x = 0; x < data.Width; x++)
                    {
                        Color pixel = Color.FromArgb(*(row + x));
                        if (pixel.A != 0 && !_pass.Contains(new Point(x, y)))
                        {
                            _pass.Left.Add(new Point(x, y));
                            break;
                        }
                    }
                }

                //right
                for (int y = 0; y < data.Height; y++)
                {
                    int* row = ptr + (y * data.Width);

                    for (int x = data.Width - 1; x >= 0; x--)
                    {
                        Color pixel = Color.FromArgb(*(row + x));
                        if (pixel.A != 0 && !_pass.Contains(new Point(x, y)))
                        {
                            _pass.Right.Add(new Point(x, y));
                            break;
                        }
                    }
                }
            }

            Image.UnlockBits(data);
        }

        private class Pass
        {
            internal List<Point> Bottom;
            internal List<Point> Left;
            internal List<Point> Right;
            internal List<Point> Top;

            internal Pass()
            {
                Top = new List<Point>();
                Left = new List<Point>();
                Right = new List<Point>();
                Bottom = new List<Point>();
            }

            //parses passes by accuracy from pass side to center
            static internal List<Point> GenerateLOD(float accuracy, List<Point> src, Size offset = default(Size))
            {
                List<Point> finalPoints = new List<Point>();
                if (src.Count() >= 2)
                {
                    for (int i = 0; i < src.Count() / 2; i++)
                    {
                        if ((int)(i % accuracy) == 0)
                        {
                            //even left to mid
                            finalPoints.Add(src[i] - offset);
                        }
                    }

                    if ((src.Count() & 1) == 1)
                    {
                        finalPoints.Add(src[src.Count() / 2] - offset);
                    }

                    int rightToMidCount = finalPoints.Count();

                    for (int i = src.Count() - 1; i >= (int)Math.Ceiling((double)(src.Count() / 2)); i--)
                    {
                        if ((int)((src.Count() - 1 - i) % accuracy) == 0)
                        {
                            //even right to mid in left to right order
                            finalPoints.Add(src[i] - offset);
                        }
                    }

                    finalPoints.Reverse(rightToMidCount, finalPoints.Count() - rightToMidCount);
                }
                return finalPoints;
            }

            internal bool Contains(Point p)
            {
                return Top.Contains(p) || Left.Contains(p) || Right.Contains(p) || Bottom.Contains(p);
            }
        }
    }
}