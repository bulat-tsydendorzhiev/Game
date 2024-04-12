namespace GameGUI;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        LayoutDrowAndButtons = new TableLayoutPanel();
        LayoutButtons = new TableLayoutPanel();
        ButtonMoveUp = new Button();
        ButtonMoveLeft = new Button();
        ButtonMoveRight = new Button();
        ButtonMoveDown = new Button();
        DrowPanel = new Panel();
        label2 = new Label();
        label1 = new Label();
        LayoutDrowAndButtons.SuspendLayout();
        LayoutButtons.SuspendLayout();
        DrowPanel.SuspendLayout();
        SuspendLayout();
        // 
        // LayoutDrowAndButtons
        // 
        LayoutDrowAndButtons.ColumnCount = 2;
        LayoutDrowAndButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.66F));
        LayoutDrowAndButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
        LayoutDrowAndButtons.Controls.Add(LayoutButtons, 1, 0);
        LayoutDrowAndButtons.Controls.Add(DrowPanel, 0, 0);
        LayoutDrowAndButtons.Dock = DockStyle.Fill;
        LayoutDrowAndButtons.Location = new Point(0, 0);
        LayoutDrowAndButtons.Margin = new Padding(2);
        LayoutDrowAndButtons.Name = "LayoutDrowAndButtons";
        LayoutDrowAndButtons.RowCount = 1;
        LayoutDrowAndButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        LayoutDrowAndButtons.Size = new Size(699, 408);
        LayoutDrowAndButtons.TabIndex = 2;
        // 
        // LayoutButtons
        // 
        LayoutButtons.ColumnCount = 2;
        LayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        LayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        LayoutButtons.Controls.Add(ButtonMoveUp, 0, 0);
        LayoutButtons.Controls.Add(ButtonMoveLeft, 0, 1);
        LayoutButtons.Controls.Add(ButtonMoveRight, 1, 1);
        LayoutButtons.Controls.Add(ButtonMoveDown, 0, 2);
        LayoutButtons.Dock = DockStyle.Fill;
        LayoutButtons.Location = new Point(467, 2);
        LayoutButtons.Margin = new Padding(2);
        LayoutButtons.Name = "LayoutButtons";
        LayoutButtons.RowCount = 3;
        LayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
        LayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
        LayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
        LayoutButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
        LayoutButtons.Size = new Size(230, 404);
        LayoutButtons.TabIndex = 2;
        // 
        // ButtonMoveUp
        // 
        LayoutButtons.SetColumnSpan(ButtonMoveUp, 2);
        ButtonMoveUp.Dock = DockStyle.Fill;
        ButtonMoveUp.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
        ButtonMoveUp.Location = new Point(2, 2);
        ButtonMoveUp.Margin = new Padding(2);
        ButtonMoveUp.Name = "ButtonMoveUp";
        ButtonMoveUp.Size = new Size(226, 130);
        ButtonMoveUp.TabIndex = 0;
        ButtonMoveUp.Text = "↑";
        ButtonMoveUp.UseVisualStyleBackColor = true;
        ButtonMoveUp.Click += MoveUp;
        // 
        // ButtonMoveLeft
        // 
        ButtonMoveLeft.Dock = DockStyle.Fill;
        ButtonMoveLeft.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
        ButtonMoveLeft.Location = new Point(2, 136);
        ButtonMoveLeft.Margin = new Padding(2);
        ButtonMoveLeft.Name = "ButtonMoveLeft";
        ButtonMoveLeft.Size = new Size(111, 130);
        ButtonMoveLeft.TabIndex = 1;
        ButtonMoveLeft.Text = "←";
        ButtonMoveLeft.UseVisualStyleBackColor = true;
        ButtonMoveLeft.Click += MoveLeft;
        // 
        // ButtonMoveRight
        // 
        ButtonMoveRight.Dock = DockStyle.Fill;
        ButtonMoveRight.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
        ButtonMoveRight.Location = new Point(117, 136);
        ButtonMoveRight.Margin = new Padding(2);
        ButtonMoveRight.Name = "ButtonMoveRight";
        ButtonMoveRight.Size = new Size(111, 130);
        ButtonMoveRight.TabIndex = 2;
        ButtonMoveRight.Text = "→";
        ButtonMoveRight.UseVisualStyleBackColor = true;
        ButtonMoveRight.Click += MoveRight;
        // 
        // ButtonMoveDown
        // 
        LayoutButtons.SetColumnSpan(ButtonMoveDown, 2);
        ButtonMoveDown.Dock = DockStyle.Fill;
        ButtonMoveDown.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
        ButtonMoveDown.Location = new Point(2, 270);
        ButtonMoveDown.Margin = new Padding(2);
        ButtonMoveDown.Name = "ButtonMoveDown";
        ButtonMoveDown.Size = new Size(226, 132);
        ButtonMoveDown.TabIndex = 3;
        ButtonMoveDown.Text = "↓";
        ButtonMoveDown.UseVisualStyleBackColor = true;
        ButtonMoveDown.Click += MoveDown;
        // 
        // DrowPanel
        // 
        DrowPanel.AllowDrop = true;
        DrowPanel.BackgroundImageLayout = ImageLayout.Center;
        DrowPanel.Controls.Add(label2);
        DrowPanel.Controls.Add(label1);
        DrowPanel.Dock = DockStyle.Fill;
        DrowPanel.Location = new Point(2, 2);
        DrowPanel.Margin = new Padding(2);
        DrowPanel.Name = "DrowPanel";
        DrowPanel.Size = new Size(461, 404);
        DrowPanel.TabIndex = 3;
        DrowPanel.Paint += ControlPaint;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 30F);
        label2.ForeColor = Color.Red;
        label2.Location = new Point(183, 178);
        label2.Name = "label2";
        label2.Size = new Size(0, 54);
        label2.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Font = new Font("Segoe UI", 20F);
        label1.Location = new Point(0, 0);
        label1.Name = "label1";
        label1.Size = new Size(64, 37);
        label1.TabIndex = 0;
        label1.Text = "HP: ";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(699, 408);
        Controls.Add(LayoutDrowAndButtons);
        Margin = new Padding(2);
        Name = "Form1";
        Text = "Game";
        Load += Form1_Load;
        LayoutDrowAndButtons.ResumeLayout(false);
        LayoutButtons.ResumeLayout(false);
        DrowPanel.ResumeLayout(false);
        DrowPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private TableLayoutPanel LayoutDrowAndButtons;
    private TableLayoutPanel LayoutButtons;
    private Button ButtonMoveUp;
    private Button ButtonMoveLeft;
    private Button ButtonMoveRight;
    private Button ButtonMoveDown;
    private Panel DrowPanel;
    private Label label1;
    private Label label2;
}
