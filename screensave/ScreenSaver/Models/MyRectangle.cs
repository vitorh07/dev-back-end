namespace Models.BaseShapes;

public class MyRectangle : Shape
{
    // Atributos

    // Construtores
    public MyRectangle(int x, int y, Color color, int width, int height)
        : base(x, y, color, width, height){}

    // Métodos

    public void Draw(Graphics g)
    {
        using var brush = new SolidBrush(ColorShape);
        g.FillRectangle(brush, X, Y, Width, Height);
    }

    // ToString    
    public override string ToString()
    {
        return base.ToString() + $", Width: {Width}, Height: {Height}";
    }
}