namespace Models;

using System.Drawing;

public class LoveRectangle{

    public Point BottomLeft{ get; private set; }
    public Point TopLeft{ get; private set;}
    public Point TopRight{ get; private set;}
    public Point BottomRight{ get; private set;}
   

    public LoveRectangle(int leftX, int bottomY, int width, int height)
    {
        BottomLeft = new Point(leftX, bottomY);
        TopLeft = new Point(leftX, bottomY+height);
        TopRight = new Point(leftX+width, bottomY+height);
        BottomRight = new Point(leftX+width, bottomY);
    }
    public LoveRectangle(Point bottomLeft, Point topLeft, Point topRight, Point bottomRight)
    {
        BottomLeft = new Point(bottomLeft.X, bottomLeft.Y);
        BottomRight = new Point(bottomRight.X, bottomRight.Y);
        TopLeft = new Point(topLeft.X, topLeft.Y);
        TopRight = new Point(topRight.X, topRight.Y);
    }

    public LoveRectangle Intersect(LoveRectangle rectangle){
        var bl = new Point();
        var br = new Point();
        var tl = new Point();
        var tr = new Point();
        tl.X = bl.X = BottomLeft.X < rectangle.BottomLeft.X ? rectangle.BottomLeft.X : BottomLeft.X;
        tr.X = br.X = BottomRight.X < rectangle.BottomRight.X ? BottomRight.X : rectangle.BottomRight.X;
        bl.Y = br.Y = BottomLeft.Y < rectangle.BottomLeft.Y ? rectangle.BottomLeft.Y : BottomLeft.Y;
        tl.Y = tr.Y = TopRight.Y < rectangle.TopRight.Y ? TopRight.Y :rectangle.TopRight.Y ;

        return new LoveRectangle(bl,tl,tr,br);

    }

}