namespace Models.BaseShapes;

public class MyEllipse : Shape
{
    public MyEllipse(int screenHeight, int screenWidth)
    : base(screenHeight, screenWidth){}

    public void Draw(Graphics g)
    {
        using var brush = new SolidBrush(ColorShape);
        g.FillEllipse(brush, X, Y, Width, Height);
    }
}