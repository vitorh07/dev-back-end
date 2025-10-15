namespace Models.BaseShapes;

public abstract class Shape
{
    // Atributos
    protected int X;
    protected int Y;
    protected int Width;
    protected int Height;
    protected int SpeedX;
    protected int SpeedY;
    protected Color ColorShape;

    // Construtores
    public Shape(int x, int y, Color color, int width, int height)
    {
        X = x;
        Y = y;
        SpeedX = 10;
        SpeedY = 10;
        ColorShape = color;
        Width = width;
        Height = height;
    }

    // Métodos

    public void Move(int xLimit, int yLimit)
    {
            Y += SpeedY;
            X += SpeedX;

        if (X >= xLimit - Width || X < 0)
        {
            SpeedX = -SpeedX;
            X += SpeedX;
        }
        
        if (Y >= yLimit - Height || Y < 0)
        {
            SpeedY = -SpeedY;
            Y += SpeedY;
        }
    }

    // ToString    
    public override string ToString()
    {
        return $"Pos X: {X}, Pos Y: {Y}, Color: {ColorShape}, Width: {Width}, Height: {Height}";
    }
}