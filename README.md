## **Weierstrass Function**

In mathematics, the Weierstrass function is an
example of a real-valued function that is continuous 
everywhere but differentiable nowhere. It is an example
of a fractal curve. It is named after its discoverer 
Karl Weierstrass.

### _Visualisation_

Visualization done with integration Python in C#

```cs
Environment.SetEnvironmentVariable("PYTHONNET_PYDLL",
                                    @"path to python39.dll or another version",
                                    EnvironmentVariableTarget.Process);
```

Then the library "matplotlib" was imported

```cs
using (Py.GIL())
{
    dynamic mpl = Py.Import("matplotlib");
    dynamic plt = Py.Import("matplotlib.pyplot");

    plt.plot(XValues, YValues);
    plt.show();
}
```

Plot of Weierstrass function over the interval [−2; 2]

![image1](https://raw.githubusercontent.com/evabronskayaa/WFunction/master/image1.png)

### _Function_
In Weierstrass's original paper, the function was defined as a Fourier series:

![image2](https://wikimedia.org/api/rest_v1/media/math/render/svg/da584736d393e241fa5fa265cd17c06bc73f316e)

```cs
float res = 0;
for (int n = 0; n < size; n++) 
{
    res += (float) (Math.Cos(Math.Pow(3, n) * Math.PI * x) / Math.Pow(2, n));
}
```