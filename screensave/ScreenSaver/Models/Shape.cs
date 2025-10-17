using System.Drawing;

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
    protected Color ColorShape { get; set; }
    private Random rand = new Random();

    // Construtores
    public Shape(int screenHeight, int screenWidth)
    {
        X = rand.Next(screenWidth - 100);
        Y = rand.Next(screenHeight - 100);
        do{
            SpeedX = rand.Next(-10, 11);
        } while (SpeedX == 0);
        do{
            SpeedY = rand.Next(-10, 11);
        } while (SpeedY == 0);
        ColorShape = colorGenerater();
        Width = rand.Next(50, 251);
        Height = rand.Next(50, 251);
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
            ColorShape = colorGenerater();
        }

        if (Y >= yLimit - Height || Y < 0)
        {
            SpeedY = -SpeedY;
            Y += SpeedY;
            ColorShape = colorGenerater();
        }
    }

    private Color colorGenerater()
    {
        return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
    }


    // ToString    
    public override string ToString()
    {
        return $"Pos X: {X}, Pos Y: {Y}, Color: {ColorShape}, Width: {Width}, Height: {Height}";
    }
}