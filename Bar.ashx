<%@ WebHandler Language="C#" Class="Bar" %>

using System;
using System.Web;
using System.Drawing.Imaging;
using System.Drawing;

public class Bar : IHttpHandler {
    
    public void ProcessRequest (HttpContext context)
    { 
            string  val1 = context.Request.QueryString["val1"];
            string[] num = val1.Split(',');
                       
            displayImage(num);
            context.Response.ContentType = "image/gif";
            bmp.Save(context.Response.OutputStream, ImageFormat.Gif);
        
        
    }
    Bitmap bmp;
    public void displayImage(string []num)
    {
        
        bmp = new Bitmap(500, 500);
        Graphics graphic = Graphics.FromImage(bmp);
        
        SolidBrush whitebrush = new SolidBrush(Color.White);
        SolidBrush BlackBrush = new SolidBrush(Color.Black);
        Pen blackPen = new Pen(Color.Black, 2);

        graphic.FillRectangle(whitebrush, 0, 0, 500, 500);

        graphic.DrawLine(blackPen, new Point(20, 480), new Point(480, 480));
        graphic.DrawLine(blackPen, new Point(20, 20), new Point(20, 480));
        
        float Heighestval=float.Parse(num[0]);
        for (int i = 1; i < num.Length; i++)
        {
            if (Heighestval < float.Parse(num[i]))
                Heighestval = float.Parse(num[i]);
        }
       if (Heighestval == 0)
           Heighestval = 1;
       Random rnd = new Random();

       int thickness = Convert.ToInt32((440 / num.Length) - ((30.0 / 100) * (440 / num.Length)));
       int gap = Convert.ToInt32 ((30.0 / 100) * (440 / num.Length));
       if (num.Length <  6)
       {
           thickness = 60;
           gap = 20;
       }
       float[] val = new float[num.Length];
       for (int i = 0; i < val.Length; i++)
       {           
           val[i] = (float.Parse(num[i]) / Heighestval) * 450;
           
           graphic.FillRectangle(new SolidBrush(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))), (i*(gap+thickness))+40, 478 - val[i], thickness, val[i]);
           //graphic.DrawString(num[i], new Font("Arial", 8), BlackBrush, new Point(0, Convert.ToInt32(465 - val[i])));
           //graphic.DrawString("--", new Font("Arial", 8), BlackBrush, new Point(15, Convert.ToInt32(470 - val[i])));
           //// For 1..2..3
          // graphic.DrawString((i + 1).ToString(), new Font("Arial", 8), BlackBrush, new Point((((i * (gap + thickness)) + 40) + Convert.ToInt32((thickness / 2))), Convert.ToInt32(485)));
           graphic.DrawString(num[i], new Font("Arial", 8), BlackBrush, new Point(((i * (gap + thickness)) + 40), Convert.ToInt32(465 - val[i])));
       }
        
    }
 
    public bool IsReusable 
    {
        get 
        {
            return false;
        }
    }

}