//Refactor the following code to use proper variable naming and simplified expressions:
//public class Size
//{
//  public double wIdTh, Viso4ina;
//  public Size(double w, double h)
//  {
//    this.wIdTh = w;
//    this.Viso4ina = h;
//  }
//}

//public static Size GetRotatedSize(
//  Size s, double angleOfTheFigureThatWillBeRotaed)
//{
//  return new Size(
//    Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh + 
//      Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina,
//    Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh + 
//      Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina);
//}

namespace VariablesDataExpressionsConstants
{
    using System;

    class Excercise01
    {
        public class Size2D
        {
            private double width;
            private double height;
            public Size2D(double width, double height)
            {
                this.Width = width;
                this.Height = height;
            }

            public double Width
            {
                get
                {
                    return this.width;
                }

                private set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("the width cannot be less or equal to 0!");
                    }

                    this.width = value;
                }
            }

            public double Height
            {
                get
                {
                    return this.height;
                }

                private set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("the height cannot be less or equal to 0!");
                    }

                    this.height = value;
                }
            }
        }

        public static Size2D GetRotatedSize(Size2D size, double angleOfRotation)
        {
            double cosOfAngleOfRotation = Math.Cos(angleOfRotation);
            double sinOfAngleOfRotation = Math.Sin(angleOfRotation);
            double rotatedWidth = Math.Abs(cosOfAngleOfRotation) * size.Width + Math.Abs(sinOfAngleOfRotation) * size.Height;
            double rotatedHeight = Math.Abs(sinOfAngleOfRotation) * size.Width + Math.Abs(cosOfAngleOfRotation) * size.Height;

            return new Size2D(rotatedWidth, rotatedHeight);
        }
    }
}
