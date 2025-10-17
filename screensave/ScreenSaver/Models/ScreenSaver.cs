namespace Models.Screens;

using Models.BaseShapes;
using System.Drawing;
using System.Windows.Forms;

public class ScreenSaver : Form
{
    // ******* Declare suas formas geométricas aqui (escopo global) *******
    MyRectangle r;
    MyRectangle r1;
    MyRectangle r2;
    MyEllipse el;
    MyEllipse el2;
    MyCircle c;
    MySquare sq;
    // ********************************************************************
    private Timer ControlTimer;

    public ScreenSaver()
    {
        this.DoubleBuffered = true;                     // evita flickering
        this.WindowState = FormWindowState.Maximized;   // Maximiza a janela
        // Define a cor de background
        this.BackColor = Color.Black;                   
        // Inicializa o temporizador de controle
        ControlTimer = new Timer();
        ControlTimer.Interval = 16;                     // 16 ms = ~60 fps
        // Controle da animação
        ControlTimer.Tick += (s, e) =>
        {
            // ****** Mova suas formas geométricas aqui ******
            r.Move(ClientSize.Width, ClientSize.Height);
            r1.Move(ClientSize.Width, ClientSize.Height);
            r2.Move(ClientSize.Width, ClientSize.Height);
            sq.Move(ClientSize.Width, ClientSize.Height);
            el.Move(ClientSize.Width, ClientSize.Height);
            el2.Move(ClientSize.Width, ClientSize.Height);
            c.Move(ClientSize.Width, ClientSize.Height);
            
            // ***********************************************
            Invalidate(); // Foça a tela a ser redesenhada.
        }; // Função anônima disparada pelo ControlTimer a cada Interval (ms)
        ControlTimer.Start();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        // ****** Instancie suas formas geométricas aqui ******
        r = new MyRectangle(ClientSize.Height, ClientSize.Width);
        r1 = new MyRectangle(ClientSize.Height, ClientSize.Width);
        r2 = new MyRectangle(ClientSize.Height, ClientSize.Width);
        sq = new MySquare(ClientSize.Height, ClientSize.Width);
        el = new MyEllipse(ClientSize.Height, ClientSize.Width);
        el2 = new MyEllipse(ClientSize.Height, ClientSize.Width);
        c = new MyCircle(ClientSize.Height, ClientSize.Width);
        // ****************************************************
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        // ****** Desenhe suas formas geométricas aqui *******
        r.Draw(e.Graphics);
        r1.Draw(e.Graphics);
        r2.Draw(e.Graphics);
        sq.Draw(e.Graphics);
        el.Draw(e.Graphics);
        el2.Draw(e.Graphics);
        c.Draw(e.Graphics);
        // ***************************************************

    }

    
}