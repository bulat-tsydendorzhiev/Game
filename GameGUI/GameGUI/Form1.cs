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
        map = new Map("..\\..\\..\\map.txt", DrowPanel);
        player = new Player(map);
        label1.Text = $"HP: {player.Health}";
    }

    private void ControlPaint(object sender, PaintEventArgs e)
    {
        g = DrowPanel.CreateGraphics();
        map.Display(g, DrowPanel);
    }

    private void MoveUp(object sender, EventArgs e)
    {
        player.MakeMove(Player.Direction.Up);
        UpdatePlayerState();
    }

    private void MoveDown(object sender, EventArgs e)
    {
        player.MakeMove(Player.Direction.Down);
        UpdatePlayerState();
    }

    private void MoveRight(object sender, EventArgs e)
    {
        player.MakeMove(Player.Direction.Right);
        UpdatePlayerState();
    }

    private void MoveLeft(object sender, EventArgs e)
    {
        player.MakeMove(Player.Direction.Left);
        UpdatePlayerState();
    }

    private void UpdatePlayerState()
    {
        var damageValue = map.Update(player.CurrentCoordinates, g);
        var playerHasHp = player.LoseHealth(damageValue);
        label1.Text = $"HP: {player.Health}";
        if (!playerHasHp)
        {
            ButtonMoveUp.Click -= MoveUp;
            ButtonMoveLeft.Click -= MoveLeft;
            ButtonMoveRight.Click -= MoveRight;
            ButtonMoveDown.Click -= MoveDown;
            label2.Text = "Game over";
        }
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.W:
                player.MakeMove(Player.Direction.Up);
                map.Update(player.CurrentCoordinates, g);
                break;
            case Keys.A:
                player.MakeMove(Player.Direction.Left);
                map.Update(player.CurrentCoordinates, g);
                break;
            case Keys.D:
                player.MakeMove(Player.Direction.Right);
                map.Update(player.CurrentCoordinates, g);
                break;
            case Keys.S:
                player.MakeMove(Player.Direction.Down);
                map.Update(player.CurrentCoordinates, g);
                break;
            case Keys.Escape:
                Application.Exit();
                break;
        }
    }
}
