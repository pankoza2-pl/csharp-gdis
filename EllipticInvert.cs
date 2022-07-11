using System;
using System.Drawing;
using System.Runtime.InteropServices;
[DllImport("gdi32.dll")]
static extern IntPtr CreateEllipticRgn(int nLeftRect, int nTopRect,int nRightRect, int nBottomRect);

[DllImport("gdi32.dll")]
private static extern bool PatBlt(IntPtr hdc, int nXLeft, int nYLeft, int nWidth, int nHeight, CopyPixelOperation dwRop);

private static void Main()
{
    Random random = new Random
    IntPtr hd = CreateEllipticRgn(random.Next(screenW), random.Next(screenH), random.Next(screenW), random.Next(screenH));
    SelectObject(hdc, hd);
    PatBlt(hdc, 0, 0, screenW, screenH, CopyPixelOperation.PatInvert);
}
