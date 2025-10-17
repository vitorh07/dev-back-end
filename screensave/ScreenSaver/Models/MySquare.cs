namespace Models.BaseShapes;

public class MySquare : Shape
{
    // Atributos

    // Construtores
    public MySquare(int screenHeight, int screenWidth)
    : base(screenHeight, screenWidth)
    {
        Width = Height;
    }

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