using System.Drawing;
using System.Drawing.Drawing2D;

public static class ResimBoyutlandirici
{
    public static System.Drawing.Image
                   ResimBoyutlandir(System.Drawing.Image img, Size boyut)
    {
        int kaynakEn = img.Width;
        int KaynakBoy = img.Height;
        float nPercent = 0;
        float nPercentW = 0;
        float nPercentH = 0;
        nPercentW = ((float)boyut.Width / (float)kaynakEn);
        nPercentH = ((float)boyut.Height / (float)KaynakBoy);
        if (nPercentH < nPercentW)
        {
            nPercent = nPercentH;
        }
        else
        {
            nPercent = nPercentW;
        }
        int HedefEn = (int)(kaynakEn * nPercent);
        int HedefBoy = (int)(KaynakBoy * nPercent);
        Bitmap b = new Bitmap(HedefEn, HedefBoy);
        Graphics g = Graphics.FromImage((System.Drawing.Image)b);
        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        g.DrawImage(img, 0, 0, HedefEn, HedefBoy);
        g.Dispose();
        return (System.Drawing.Image)b;
    }
}
