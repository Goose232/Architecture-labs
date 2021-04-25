using System;
using System.Runtime.InteropServices;

[Guid("8C034F6A-1D3F-4DB8-BC99-B73873D8C297")]
[ClassInterface(ClassInterfaceType.None)]
[ComVisible(true)]
public class Equation : MyCom.IEquation
{
    public double LinearEq(int a, int b)
    {

        return (double)-b / a;
    }

    public string SqrEq(int a, int b, int c)
    {
        string result = "";
        double D = b * b - 4 * a * c;
        if (D > 0)
        {
            double sqrtD = Math.Sqrt(D);
            double x1 = (-b + sqrtD) / 2 * a;
            double x2 = (-b - sqrtD) / 2 * a;
            x1 = Math.Truncate(x1 * 100) / 100;
            x2 = Math.Truncate(x2 * 100) / 100;
            result = "x1=" + x1.ToString() + " " + "x2=" + x2.ToString();
            return result;
        }
        if (D == 0)
        {
            double sqrtD = Math.Sqrt(D);
            double x1 = (-b + sqrtD) / 2 * a;
            x1 = Math.Truncate(x1 * 100) / 100;
            result = "x1=" + x1.ToString();
            return result;
        }
        if (D < 0)
        {
            result = "Дискриминант меньше 0";
            return result;
        }
        return result;
    }
}
