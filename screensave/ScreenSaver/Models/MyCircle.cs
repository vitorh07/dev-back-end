namespace Models.BaseShapes;

public class MyCircle : MyEllipse
{
    public MyCircle(int screenHeight, int screenWidth)
        : base(screenHeight, screenWidth)
    {
        Width = Height;
    }

    public void Draw(Graphics g)
    {
        using var brush = new SolidBrush(ColorShape);
        g.FillEllipse(brush, X, Y, Width, Height);
    }
}