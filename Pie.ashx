<%@ WebHandler Language="C#" Class="Pie" %>

using System;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
public class Pie : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) 
    {

        string val1 = context.Request.QueryString["val1"];
        string[] num = val1.Split(',');
        displayImage(num);
        context.Response.ContentType = "image/gif";
        bmp.Save(context.Response.OutputStream, ImageFormat.Gif);
    }
    Bitmap bmp;
    public void displayImage(string []num)
    {
        bmp = new Bitmap(500, 200);
        Graphics graphic = Graphics.FromImage(bmp);       
        SolidBrush whitebrush = new SolidBrush(Color.White);
        SolidBrush BlackBrush = new SolidBrush(Color.Black);
        Pen blackPen = new Pen(Color.Black, 2);
        graphic.FillRectangle(whitebrush, 0, 0, 500, 500);

        float tot = 0;
        for (int i = 0; i < num.Length; i++)
        {
            tot += float.Parse(num[i]);
        }
        Random rnd = new Random();

        float[] val = new float[num.Length];
        if (tot == 0)
            tot = 1;

        int gap = Convert.ToInt32((30 / 100) * (440 / num.Length));
        int thickness = Convert.ToInt32((440 / num.Length) - ((60 / 100) * (440 / num.Length)));
        if (num.Length < 16)
        {
            gap = 20;
            thickness = 10;            
        }
        
        float start = 0;
        for (int i = 0; i < val.Length; i++)
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));
            val[i] = (float.Parse(num[i]) / tot) * 360;
            graphic.FillPie(brush, 0, 0, 200, 200, start, val[i]);
            graphic.FillRectangle(brush, 410, ((i * (gap + thickness)) + 40), thickness, thickness);
            graphic.DrawString(num[i], new Font("Arial", 8), BlackBrush, 420+thickness, ((i * (gap + thickness)) + 38));
            start += val[i];
        }
        

        //graphic.FillPie(redbrush, 0,0, 200, 200, 0, val1);
        //graphic.FillPie(bluebrush, 0, 0, 200, 200, val1, val2);
        //graphic.FillPie(Yellowbrush, 0, 0, 200, 200, val1+val2, val3);

        //graphic.FillRectangle(redbrush, 190, 190, 8, 8);
        //graphic.FillRectangle(bluebrush, 190, 205, 8, 8);
        //graphic.FillRectangle(Yellowbrush,190, 220, 8, 8);           

        //graphic.DrawString(v1.ToString(), new Font("Arial", 8), BlackBrush, 200,185);
        //graphic.DrawString(v2.ToString(), new Font("Arial", 8), BlackBrush, 200,200);
        //graphic.DrawString(v3.ToString(), new Font("Arial", 8), BlackBrush, 200,215);

        //graphic.DrawString("KKD", new Font("Arial", 8), BlackBrush, new Point(30, Convert.ToInt32(235)));
        //graphic.DrawString("Outcuts", new Font("Arial", 8), BlackBrush, new Point(85, Convert.ToInt32(235)));
        //graphic.DrawString("Others", new Font("Arial", 8), BlackBrush, new Point(145, Convert.ToInt32(235)));

    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}