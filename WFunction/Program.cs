using System;
using System.Collections.Generic;
using NumSharp;

namespace WFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //python integration
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", @"C:\Users\Ева\AppData\Local\Programs\Python\Python39\python39.dll", EnvironmentVariableTarget.Process);
            
            int size = 1000;
            int startX = -1;
            int stopX = 1;

            List<float> xValues = new List<float>();

            for (float i = startX; i < stopX; i += (float)(stopX - startX) / size)
            {
                xValues.Add(i);
            } 
            
            /// <summary>
            /// var xValues = np.arange(startX,stopX,(float)(stopX-startX)/size);
            /// 
            /// It's the analogue NumPy in C# (NumSharp)
            /// </summary>
            
            float[] x = xValues.ToArray();
            
            var y = new List<float>();
            foreach (var floatX in x) 
            {
                y.Add(GetValue(500, floatX));
            }
            CreatePlot(x, y.ToArray());
        }

        private static float GetValue(int size, float x)
        {
            float res = 0;
            for (int n = 0; n < size; n++)
            {
                res += (float) (Math.Cos(Math.Pow(3, n) * Math.PI * x) / Math.Pow(2, n));
            }

            return res;
        }
        
        private static void CreatePlot(float[] x, float[] y)
        {
            PyPlot plt = new PyPlot();

            plt.X(x); 
            plt.Y(y);
            plt.Show();
        }
    }
}