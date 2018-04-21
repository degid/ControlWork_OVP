using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace ControlWork
{
    public struct Data
    {
        public static int X { get; set; }
        public static int Y { get; set; }
        public static double A { get; set; }
        public static double B { get; set; }
        public static double C { get; set; }
        public static bool Add { get; set; }
    }

    public class Err
    {
        public Point point { get; set; }
        public System.Exception exception { get; set; }
    }

    public class MatrixPlus
    {
        public double Min { get; private set; }
        public double Max { get; private set; }
        public double[,] Matrix { get; private set; }
        public List<Err> errs { get; private set; }

        public void New(int x, int y, double kor)
        {
            Min = double.MaxValue;
            Max = double.MinValue;
            Matrix = new double[x, y];
            errs = new List<Err>();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    try
                    {
                        Matrix[i, j] = (Data.A / (Data.B + i * i) - Data.C * i * j) / kor;

                        if (Min > Matrix[i, j])
                            Min = Matrix[i, j];

                        if (Max < Matrix[i, j])
                            Max = Matrix[i, j];
                    }
                    catch (System.Exception ex)
                    {
                        Err err = new Err { exception = ex, point = new Point(i, j)};
                        errs.Add(err);
                    }
                }
            }
        }

        public void New(double kor = 1)
        {
            New(Data.X, Data.Y, kor);
        }

        public static MatrixPlus operator /(MatrixPlus matrixPlus, double razn)
        {
            MatrixPlus matrix = new MatrixPlus { Matrix = matrixPlus.Matrix };
            matrix.New(razn);
            return matrix;
        }
    }
}