using System;
using System.Collections.Generic;
using System.Linq;
using NumSharp;

namespace WFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            ///     Weierstrass function
            ///     Like other fractals, the function exhibits self-similarity:
            ///                         every zoom  is similar to the global plot.
            /// 
            /// </summary>
            
            
            //python integration
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", 
                                            @"C:\Users\Ева\AppData\Local\Programs\Python\Python39\python39.dll", 
                                                EnvironmentVariableTarget.Process);
            int size = 10000;
            int startX = -2;
            int stopX = 2;

            var xValues = new List<float>();
            for (float i = startX; i < stopX; i += (float)(stopX - startX) / size) 
            {
                xValues.Add(i);
            } 
            
            /// <summary>
            /// <param name="xValues">
            ///     Also can look like:
            ///             var xValues = np.arange(startX,stopX,(float)(stopX-startX)/size);
            ///
            ///     It's the analogue NumPy in C# (NumSharp)
            /// </param>
            /// 
            /// </summary>
            
            float[] x = xValues.ToArray();
            CreatePlot(x, x.Select(floatX => GetValue(500, floatX)).ToArray());
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