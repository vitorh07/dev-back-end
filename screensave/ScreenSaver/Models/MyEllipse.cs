namespace Models.BaseShapes;

public class MyEllipse : Shape
{
    public MyEllipse(int x, int y, Color color, int width, int height)
        : base(x, y, color, width, height) { }

    public void Draw(Graphics g)
    {
        using var brush = new SolidBrush(ColorShape);
        g.FillEllipse(brush, X, Y, Width, Height);
    }
}