using System;
using System.Drawing;
using System.Runtime.InteropServices;

//https://www.pinvoke.net/default.aspx/gdi32/CreateEllipticRgn.html
[DllImport("gdi32.dll")]
static extern IntPtr CreateEllipticRgn(int nLeftRect, int nTopRect,int nRightRect, int nBottomRect);

[DllImport("gdi32.dll")]
private static extern bool PatBlt(IntPtr hdc, int nXLeft, int nYLeft, int nWidth, int nHeight, CopyPixelOperation dwRop);

[DllImport("user32.dll", SetLastError = true)]
private static extern IntPtr GetDC(IntPtr hWnd);

private static void Main()
{
    IntPtr hdc = GetDC(IntPtr.Zero);
    Random random = new Random
    IntPtr hd = CreateEllipticRgn(random.Next(screenW), random.Next(screenH), random.Next(screenW), random.Next(screenH));
    SelectObject(hdc, hd);
    PatBlt(hdc, 0, 0, screenW, screenH, CopyPixelOperation.PatInvert);
}
