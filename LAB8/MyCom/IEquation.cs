using System;
using System.Runtime.InteropServices;

namespace MyCom
{
    [Guid("364C5E66-4412-48E3-8BD8-7B2BF09E8922")]
    [ComVisible(true)]
    public interface IEquation
    {
        double LinearEq(int a, int b);
        string SqrEq(int a, int b, int c);

    }
}