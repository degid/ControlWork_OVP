using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public int X { get; set; }
        public int Y { get; set; }
        public System.Exception exception { get; set; }
    }

    public class MatrixPlus
    {
        public double Min { get; private set; }
        public double Max { get; private set; }
        public double[][] Matrix { get; private set; }
        public List<Err> errs { get; private set; }

        public void New(int x, int y, double kor)
        {
            Min = double.MaxValue;
            Max = double.MinValue;
            Matrix = new double[x][];
            errs = new List<Err>();

            for (int i = 0; i < x; i++)
            {
                Matrix[i] = new double[y];
                for (int j = 0; j < y; j++)
                {
                    try
                    {
                        Matrix[i][j] = (Data.A / (Data.B + i * i) - Data.C * i * j) / kor;
                    }
                    catch (System.Exception ex)
                    {
                        Err err = new Err { X = i, Y = j, exception = ex };
                        errs.Add(err);
                    }
                }

                if (Min > Matrix[i].Min())
                    Min = Matrix[i].Min();

                if (Max < Matrix[i].Max())
                    Max = Matrix[i].Max();
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