namespace GameGUI;

public partial class Form1 : Form
{
    private Map map;
    private Player player;
    private Graphics g;
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        map = new Map("C:\\Users\\sarap\\Desktop\\Game\\GameGUI\\GameGUI\\map.txt");
        player = new Player(map);
        g = DrowPanel.CreateGraphics();

    }

    private void ControlPaint(object sender, PaintEventArgs e)
    {
        map.Display(e);
    }
    
    private void MoveUp(object sender, EventArgs e)
    {
        player.MakeMove(Player.Direction.Up);
        map.Update(player.CurrentCoordinates, g);
    }

    private void MoveDown(object sender, EventArgs e)
    {
        player.MakeMove(Player.Direction.Down);
        map.Update(player.CurrentCoordinates, g);
    }

    private void MoveRight(object sender, EventArgs e)
    {
        player.MakeMove(Player.Direction.Right);
        map.Update(player.CurrentCoordinates, g);
    }

    private void MoveLeft(object sender, EventArgs e)
    {
        player.MakeMove(Player.Direction.Left);
        map.Update(player.CurrentCoordinates, g);
    }
}
