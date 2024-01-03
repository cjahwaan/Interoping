using System;
using System.Runtime.InteropServices;
using System.Numerics;
using System.Security;

namespace Interop;

[StructLayout(LayoutKind.Sequential)]
public class Point
{
    public int x, y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"[x: {x}, y: {y}]";
    }
}

[StructLayout(LayoutKind.Sequential)]
public class Rect
{
    public int x, y;
    public int width, height;

    public Rect(int x, int y, int width, int height)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    public override string ToString()
    {
        return $"[x: {x}, y: {y}, width: {width}, height: {height}]";
    }
}

public class Functions
{
    public const string NativeLibName = "Interop_cpp";

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void Print();

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int Add(int a, int b);

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int Addf(float a, float b);

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern bool CheckcollisionPoint(Point a, Rect b);

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern bool CheckcollisionRect(Rect a, Rect b);

}