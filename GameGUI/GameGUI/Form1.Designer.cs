namespace GameGUI
{
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
            LayoutDrowAndButtons.SuspendLayout();
            LayoutButtons.SuspendLayout();
            SuspendLayout();
            // 
            // LayoutDrowAndButtons
            // 
            LayoutDrowAndButtons.ColumnCount = 2;
            LayoutDrowAndButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.13995F));
            LayoutDrowAndButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.8600464F));
            LayoutDrowAndButtons.Controls.Add(LayoutButtons, 1, 0);
            LayoutDrowAndButtons.Controls.Add(DrowPanel, 0, 0);
            LayoutDrowAndButtons.Dock = DockStyle.Fill;
            LayoutDrowAndButtons.Location = new Point(0, 0);
            LayoutDrowAndButtons.Name = "LayoutDrowAndButtons";
            LayoutDrowAndButtons.RowCount = 1;
            LayoutDrowAndButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 52.6666679F));
            LayoutDrowAndButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 47.3333321F));
            LayoutDrowAndButtons.Size = new Size(1329, 702);
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
            LayoutButtons.Location = new Point(882, 3);
            LayoutButtons.Name = "LayoutButtons";
            LayoutButtons.RowCount = 3;
            LayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            LayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            LayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
            LayoutButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LayoutButtons.Size = new Size(444, 696);
            LayoutButtons.TabIndex = 2;
            // 
            // ButtonMoveUp
            // 
            LayoutButtons.SetColumnSpan(ButtonMoveUp, 2);
            ButtonMoveUp.Dock = DockStyle.Fill;
            ButtonMoveUp.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonMoveUp.Location = new Point(3, 3);
            ButtonMoveUp.Name = "ButtonMoveUp";
            ButtonMoveUp.Size = new Size(438, 225);
            ButtonMoveUp.TabIndex = 0;
            ButtonMoveUp.Text = "↑";
            ButtonMoveUp.UseVisualStyleBackColor = true;
            ButtonMoveUp.Click += MoveUp;
            // 
            // ButtonMoveLeft
            // 
            ButtonMoveLeft.Dock = DockStyle.Fill;
            ButtonMoveLeft.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonMoveLeft.Location = new Point(3, 234);
            ButtonMoveLeft.Name = "ButtonMoveLeft";
            ButtonMoveLeft.Size = new Size(216, 225);
            ButtonMoveLeft.TabIndex = 1;
            ButtonMoveLeft.Text = "←";
            ButtonMoveLeft.UseVisualStyleBackColor = true;
            ButtonMoveLeft.Click += MoveLeft;
            // 
            // ButtonMoveRight
            // 
            ButtonMoveRight.Dock = DockStyle.Fill;
            ButtonMoveRight.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonMoveRight.Location = new Point(225, 234);
            ButtonMoveRight.Name = "ButtonMoveRight";
            ButtonMoveRight.Size = new Size(216, 225);
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
            ButtonMoveDown.Location = new Point(3, 465);
            ButtonMoveDown.Name = "ButtonMoveDown";
            ButtonMoveDown.Size = new Size(438, 228);
            ButtonMoveDown.TabIndex = 3;
            ButtonMoveDown.Text = "↓";
            ButtonMoveDown.UseVisualStyleBackColor = true;
            ButtonMoveDown.Click += MoveDown;
            // 
            // DrowPanel
            // 
            DrowPanel.Dock = DockStyle.Fill;
            DrowPanel.Location = new Point(3, 3);
            DrowPanel.Name = "DrowPanel";
            DrowPanel.Size = new Size(873, 696);
            DrowPanel.TabIndex = 3;
            DrowPanel.Paint += ControlPaint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 702);
            Controls.Add(LayoutDrowAndButtons);
            Name = "Form1";
            Text = "Game";
            Load += Form1_Load;
            LayoutDrowAndButtons.ResumeLayout(false);
            LayoutButtons.ResumeLayout(false);
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
    }
}
