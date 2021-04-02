namespace TheQuestt
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.HitPointPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PlayerHitPointsCaption = new System.Windows.Forms.Label();
            this.BatHitPointsCaption = new System.Windows.Forms.Label();
            this.GhostHitPointsCaption = new System.Windows.Forms.Label();
            this.GhoulHitPointsCaption = new System.Windows.Forms.Label();
            this.BatHitPoints = new System.Windows.Forms.Label();
            this.GhostHitPoints = new System.Windows.Forms.Label();
            this.GhoulHitPoints = new System.Windows.Forms.Label();
            this.PlayerHitPoints = new System.Windows.Forms.Label();
            this.AttackPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AttackPanelCaption = new System.Windows.Forms.Label();
            this.AttackUp = new System.Windows.Forms.Button();
            this.AttackLeft = new System.Windows.Forms.Button();
            this.AttackRight = new System.Windows.Forms.Button();
            this.AttackDown = new System.Windows.Forms.Button();
            this.MovePanel = new System.Windows.Forms.TableLayoutPanel();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.MovePanelCaption = new System.Windows.Forms.Label();
            this.MoveRight = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MaceInvSprite = new System.Windows.Forms.PictureBox();
            this.BowInvSprite = new System.Windows.Forms.PictureBox();
            this.BluePotionInvSprite = new System.Windows.Forms.PictureBox();
            this.RedPotionInvSprite = new System.Windows.Forms.PictureBox();
            this.SwordInvSprite = new System.Windows.Forms.PictureBox();
            this.PlayerSprite = new System.Windows.Forms.PictureBox();
            this.GhostSprite = new System.Windows.Forms.PictureBox();
            this.GhoulSprite = new System.Windows.Forms.PictureBox();
            this.BatSprite = new System.Windows.Forms.PictureBox();
            this.MaceSprite = new System.Windows.Forms.PictureBox();
            this.BluePotionSprite = new System.Windows.Forms.PictureBox();
            this.RedPotionSprite = new System.Windows.Forms.PictureBox();
            this.BowSprite = new System.Windows.Forms.PictureBox();
            this.SwordSprite = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HitPointPanel.SuspendLayout();
            this.AttackPanel.SuspendLayout();
            this.MovePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaceInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhostSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhoulSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // HitPointPanel
            // 
            this.HitPointPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.HitPointPanel.ColumnCount = 2;
            this.HitPointPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.83459F));
            this.HitPointPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.16541F));
            this.HitPointPanel.Controls.Add(this.PlayerHitPointsCaption, 0, 0);
            this.HitPointPanel.Controls.Add(this.BatHitPointsCaption, 0, 1);
            this.HitPointPanel.Controls.Add(this.GhostHitPointsCaption, 0, 2);
            this.HitPointPanel.Controls.Add(this.GhoulHitPointsCaption, 0, 3);
            this.HitPointPanel.Controls.Add(this.BatHitPoints, 1, 1);
            this.HitPointPanel.Controls.Add(this.GhostHitPoints, 1, 2);
            this.HitPointPanel.Controls.Add(this.GhoulHitPoints, 1, 3);
            this.HitPointPanel.Controls.Add(this.PlayerHitPoints, 1, 0);
            this.HitPointPanel.Location = new System.Drawing.Point(611, 292);
            this.HitPointPanel.Name = "HitPointPanel";
            this.HitPointPanel.RowCount = 4;
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.Size = new System.Drawing.Size(134, 95);
            this.HitPointPanel.TabIndex = 44;
            // 
            // PlayerHitPointsCaption
            // 
            this.PlayerHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PlayerHitPointsCaption.AutoSize = true;
            this.PlayerHitPointsCaption.Location = new System.Drawing.Point(4, 5);
            this.PlayerHitPointsCaption.Name = "PlayerHitPointsCaption";
            this.PlayerHitPointsCaption.Size = new System.Drawing.Size(36, 13);
            this.PlayerHitPointsCaption.TabIndex = 0;
            this.PlayerHitPointsCaption.Text = "Player";
            // 
            // BatHitPointsCaption
            // 
            this.BatHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BatHitPointsCaption.AutoSize = true;
            this.BatHitPointsCaption.Location = new System.Drawing.Point(4, 28);
            this.BatHitPointsCaption.Name = "BatHitPointsCaption";
            this.BatHitPointsCaption.Size = new System.Drawing.Size(23, 13);
            this.BatHitPointsCaption.TabIndex = 1;
            this.BatHitPointsCaption.Text = "Bat";
            // 
            // GhostHitPointsCaption
            // 
            this.GhostHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhostHitPointsCaption.AutoSize = true;
            this.GhostHitPointsCaption.Location = new System.Drawing.Point(4, 51);
            this.GhostHitPointsCaption.Name = "GhostHitPointsCaption";
            this.GhostHitPointsCaption.Size = new System.Drawing.Size(35, 13);
            this.GhostHitPointsCaption.TabIndex = 2;
            this.GhostHitPointsCaption.Text = "Ghost";
            // 
            // GhoulHitPointsCaption
            // 
            this.GhoulHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhoulHitPointsCaption.AutoSize = true;
            this.GhoulHitPointsCaption.Location = new System.Drawing.Point(4, 75);
            this.GhoulHitPointsCaption.Name = "GhoulHitPointsCaption";
            this.GhoulHitPointsCaption.Size = new System.Drawing.Size(35, 13);
            this.GhoulHitPointsCaption.TabIndex = 3;
            this.GhoulHitPointsCaption.Text = "Ghoul";
            // 
            // BatHitPoints
            // 
            this.BatHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BatHitPoints.AutoSize = true;
            this.BatHitPoints.Location = new System.Drawing.Point(49, 28);
            this.BatHitPoints.Name = "BatHitPoints";
            this.BatHitPoints.Size = new System.Drawing.Size(65, 13);
            this.BatHitPoints.TabIndex = 5;
            this.BatHitPoints.Text = "BatHitPoints";
            // 
            // GhostHitPoints
            // 
            this.GhostHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhostHitPoints.AutoSize = true;
            this.GhostHitPoints.Location = new System.Drawing.Point(49, 51);
            this.GhostHitPoints.Name = "GhostHitPoints";
            this.GhostHitPoints.Size = new System.Drawing.Size(77, 13);
            this.GhostHitPoints.TabIndex = 6;
            this.GhostHitPoints.Text = "GhostHitPoints";
            // 
            // GhoulHitPoints
            // 
            this.GhoulHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhoulHitPoints.AutoSize = true;
            this.GhoulHitPoints.Location = new System.Drawing.Point(49, 75);
            this.GhoulHitPoints.Name = "GhoulHitPoints";
            this.GhoulHitPoints.Size = new System.Drawing.Size(77, 13);
            this.GhoulHitPoints.TabIndex = 7;
            this.GhoulHitPoints.Text = "GhoulHitPoints";
            // 
            // PlayerHitPoints
            // 
            this.PlayerHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PlayerHitPoints.AutoSize = true;
            this.PlayerHitPoints.Location = new System.Drawing.Point(49, 5);
            this.PlayerHitPoints.Name = "PlayerHitPoints";
            this.PlayerHitPoints.Size = new System.Drawing.Size(78, 13);
            this.PlayerHitPoints.TabIndex = 4;
            this.PlayerHitPoints.Text = "PlayerHitPoints";
            // 
            // AttackPanel
            // 
            this.AttackPanel.ColumnCount = 2;
            this.AttackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AttackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AttackPanel.Controls.Add(this.AttackPanelCaption, 0, 0);
            this.AttackPanel.Controls.Add(this.AttackUp, 0, 1);
            this.AttackPanel.Controls.Add(this.AttackLeft, 0, 2);
            this.AttackPanel.Controls.Add(this.AttackRight, 1, 2);
            this.AttackPanel.Controls.Add(this.AttackDown, 0, 3);
            this.AttackPanel.Location = new System.Drawing.Point(611, 153);
            this.AttackPanel.Name = "AttackPanel";
            this.AttackPanel.RowCount = 4;
            this.AttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.AttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.AttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.AttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.AttackPanel.Size = new System.Drawing.Size(134, 117);
            this.AttackPanel.TabIndex = 43;
            // 
            // AttackPanelCaption
            // 
            this.AttackPanelCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AttackPanelCaption.AutoSize = true;
            this.AttackPanelCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackPanelCaption.Location = new System.Drawing.Point(3, 3);
            this.AttackPanelCaption.Name = "AttackPanelCaption";
            this.AttackPanelCaption.Size = new System.Drawing.Size(55, 18);
            this.AttackPanelCaption.TabIndex = 0;
            this.AttackPanelCaption.Text = "Attack";
            // 
            // AttackUp
            // 
            this.AttackUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackPanel.SetColumnSpan(this.AttackUp, 2);
            this.AttackUp.Location = new System.Drawing.Point(36, 28);
            this.AttackUp.Name = "AttackUp";
            this.AttackUp.Size = new System.Drawing.Size(61, 24);
            this.AttackUp.TabIndex = 1;
            this.AttackUp.Text = "Up";
            this.AttackUp.UseVisualStyleBackColor = true;
            this.AttackUp.Click += new System.EventHandler(this.AttackUp_Click);
            // 
            // AttackLeft
            // 
            this.AttackLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackLeft.Location = new System.Drawing.Point(3, 58);
            this.AttackLeft.Name = "AttackLeft";
            this.AttackLeft.Size = new System.Drawing.Size(61, 24);
            this.AttackLeft.TabIndex = 2;
            this.AttackLeft.Text = "Left";
            this.AttackLeft.UseVisualStyleBackColor = true;
            this.AttackLeft.Click += new System.EventHandler(this.AttackLeft_Click);
            // 
            // AttackRight
            // 
            this.AttackRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackRight.Location = new System.Drawing.Point(70, 58);
            this.AttackRight.Name = "AttackRight";
            this.AttackRight.Size = new System.Drawing.Size(61, 24);
            this.AttackRight.TabIndex = 3;
            this.AttackRight.Text = "Right";
            this.AttackRight.UseVisualStyleBackColor = true;
            this.AttackRight.Click += new System.EventHandler(this.AttackRight_Click);
            // 
            // AttackDown
            // 
            this.AttackDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackPanel.SetColumnSpan(this.AttackDown, 2);
            this.AttackDown.Location = new System.Drawing.Point(36, 89);
            this.AttackDown.Name = "AttackDown";
            this.AttackDown.Size = new System.Drawing.Size(61, 24);
            this.AttackDown.TabIndex = 4;
            this.AttackDown.Text = "Down";
            this.AttackDown.UseVisualStyleBackColor = true;
            this.AttackDown.Click += new System.EventHandler(this.AttackDown_Click);
            // 
            // MovePanel
            // 
            this.MovePanel.ColumnCount = 2;
            this.MovePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MovePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MovePanel.Controls.Add(this.MoveUp, 0, 1);
            this.MovePanel.Controls.Add(this.MoveLeft, 0, 2);
            this.MovePanel.Controls.Add(this.MoveDown, 0, 3);
            this.MovePanel.Controls.Add(this.MovePanelCaption, 0, 0);
            this.MovePanel.Controls.Add(this.MoveRight, 1, 2);
            this.MovePanel.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.MovePanel.Location = new System.Drawing.Point(611, 12);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.RowCount = 4;
            this.MovePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.MovePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.MovePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.MovePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.MovePanel.Size = new System.Drawing.Size(134, 117);
            this.MovePanel.TabIndex = 42;
            // 
            // MoveUp
            // 
            this.MoveUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MovePanel.SetColumnSpan(this.MoveUp, 2);
            this.MoveUp.Location = new System.Drawing.Point(36, 28);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(61, 24);
            this.MoveUp.TabIndex = 0;
            this.MoveUp.Text = "Up";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // MoveLeft
            // 
            this.MoveLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MoveLeft.Location = new System.Drawing.Point(3, 58);
            this.MoveLeft.Name = "MoveLeft";
            this.MoveLeft.Size = new System.Drawing.Size(61, 24);
            this.MoveLeft.TabIndex = 1;
            this.MoveLeft.Text = "Left";
            this.MoveLeft.UseVisualStyleBackColor = true;
            this.MoveLeft.Click += new System.EventHandler(this.MoveLeft_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MovePanel.SetColumnSpan(this.MoveDown, 2);
            this.MoveDown.Location = new System.Drawing.Point(36, 89);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(61, 24);
            this.MoveDown.TabIndex = 3;
            this.MoveDown.Text = "Down";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // MovePanelCaption
            // 
            this.MovePanelCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MovePanelCaption.AutoSize = true;
            this.MovePanelCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovePanelCaption.Location = new System.Drawing.Point(3, 3);
            this.MovePanelCaption.Name = "MovePanelCaption";
            this.MovePanelCaption.Size = new System.Drawing.Size(49, 18);
            this.MovePanelCaption.TabIndex = 4;
            this.MovePanelCaption.Text = "Move";
            // 
            // MoveRight
            // 
            this.MoveRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MoveRight.Location = new System.Drawing.Point(70, 58);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(61, 24);
            this.MoveRight.TabIndex = 2;
            this.MoveRight.Text = "Right";
            this.MoveRight.UseVisualStyleBackColor = true;
            this.MoveRight.Click += new System.EventHandler(this.MoveRight_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(70, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(61, 19);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // MaceInvSprite
            // 
            this.MaceInvSprite.BackColor = System.Drawing.Color.Transparent;
            this.MaceInvSprite.Image = global::TheQuestt.Properties.Resources.mace1;
            this.MaceInvSprite.Location = new System.Drawing.Point(342, 321);
            this.MaceInvSprite.Name = "MaceInvSprite";
            this.MaceInvSprite.Size = new System.Drawing.Size(50, 50);
            this.MaceInvSprite.TabIndex = 41;
            this.MaceInvSprite.TabStop = false;
            this.MaceInvSprite.Visible = false;
            this.MaceInvSprite.Click += new System.EventHandler(this.MaceInvSprite_Click);
            // 
            // BowInvSprite
            // 
            this.BowInvSprite.BackColor = System.Drawing.Color.Transparent;
            this.BowInvSprite.Image = global::TheQuestt.Properties.Resources.bow1;
            this.BowInvSprite.Location = new System.Drawing.Point(218, 321);
            this.BowInvSprite.Name = "BowInvSprite";
            this.BowInvSprite.Size = new System.Drawing.Size(50, 50);
            this.BowInvSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BowInvSprite.TabIndex = 40;
            this.BowInvSprite.TabStop = false;
            this.BowInvSprite.Visible = false;
            this.BowInvSprite.Click += new System.EventHandler(this.BowInvSprite_Click);
            // 
            // BluePotionInvSprite
            // 
            this.BluePotionInvSprite.BackColor = System.Drawing.Color.Transparent;
            this.BluePotionInvSprite.Image = global::TheQuestt.Properties.Resources.potion_blue1;
            this.BluePotionInvSprite.Location = new System.Drawing.Point(280, 321);
            this.BluePotionInvSprite.Name = "BluePotionInvSprite";
            this.BluePotionInvSprite.Size = new System.Drawing.Size(50, 50);
            this.BluePotionInvSprite.TabIndex = 39;
            this.BluePotionInvSprite.TabStop = false;
            this.BluePotionInvSprite.Visible = false;
            this.BluePotionInvSprite.Click += new System.EventHandler(this.BluePotionInvSprite_Click);
            // 
            // RedPotionInvSprite
            // 
            this.RedPotionInvSprite.BackColor = System.Drawing.Color.Transparent;
            this.RedPotionInvSprite.Image = global::TheQuestt.Properties.Resources.potion_red1;
            this.RedPotionInvSprite.Location = new System.Drawing.Point(156, 321);
            this.RedPotionInvSprite.Name = "RedPotionInvSprite";
            this.RedPotionInvSprite.Size = new System.Drawing.Size(50, 50);
            this.RedPotionInvSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedPotionInvSprite.TabIndex = 38;
            this.RedPotionInvSprite.TabStop = false;
            this.RedPotionInvSprite.Visible = false;
            this.RedPotionInvSprite.Click += new System.EventHandler(this.RedPotionInvSprite_Click);
            // 
            // SwordInvSprite
            // 
            this.SwordInvSprite.BackColor = System.Drawing.Color.Transparent;
            this.SwordInvSprite.Image = global::TheQuestt.Properties.Resources.sword1;
            this.SwordInvSprite.Location = new System.Drawing.Point(94, 321);
            this.SwordInvSprite.Name = "SwordInvSprite";
            this.SwordInvSprite.Size = new System.Drawing.Size(50, 50);
            this.SwordInvSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SwordInvSprite.TabIndex = 37;
            this.SwordInvSprite.TabStop = false;
            this.SwordInvSprite.Visible = false;
            this.SwordInvSprite.Click += new System.EventHandler(this.SwordInvSprite_Click);
            // 
            // PlayerSprite
            // 
            this.PlayerSprite.BackColor = System.Drawing.Color.Transparent;
            this.PlayerSprite.Image = global::TheQuestt.Properties.Resources.player;
            this.PlayerSprite.Location = new System.Drawing.Point(78, 62);
            this.PlayerSprite.Name = "PlayerSprite";
            this.PlayerSprite.Size = new System.Drawing.Size(30, 30);
            this.PlayerSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerSprite.TabIndex = 28;
            this.PlayerSprite.TabStop = false;
            // 
            // GhostSprite
            // 
            this.GhostSprite.BackColor = System.Drawing.Color.Transparent;
            this.GhostSprite.Image = global::TheQuestt.Properties.Resources.ghost;
            this.GhostSprite.Location = new System.Drawing.Point(222, 62);
            this.GhostSprite.Name = "GhostSprite";
            this.GhostSprite.Size = new System.Drawing.Size(30, 30);
            this.GhostSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GhostSprite.TabIndex = 32;
            this.GhostSprite.TabStop = false;
            this.GhostSprite.Visible = false;
            // 
            // GhoulSprite
            // 
            this.GhoulSprite.BackColor = System.Drawing.Color.Transparent;
            this.GhoulSprite.Image = global::TheQuestt.Properties.Resources.ghoul;
            this.GhoulSprite.Location = new System.Drawing.Point(186, 62);
            this.GhoulSprite.Name = "GhoulSprite";
            this.GhoulSprite.Size = new System.Drawing.Size(30, 30);
            this.GhoulSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GhoulSprite.TabIndex = 31;
            this.GhoulSprite.TabStop = false;
            this.GhoulSprite.Visible = false;
            // 
            // BatSprite
            // 
            this.BatSprite.BackColor = System.Drawing.Color.Transparent;
            this.BatSprite.Image = global::TheQuestt.Properties.Resources.bat;
            this.BatSprite.Location = new System.Drawing.Point(150, 62);
            this.BatSprite.Name = "BatSprite";
            this.BatSprite.Size = new System.Drawing.Size(30, 30);
            this.BatSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BatSprite.TabIndex = 30;
            this.BatSprite.TabStop = false;
            this.BatSprite.Visible = false;
            // 
            // MaceSprite
            // 
            this.MaceSprite.BackColor = System.Drawing.Color.Transparent;
            this.MaceSprite.Image = global::TheQuestt.Properties.Resources.mace;
            this.MaceSprite.Location = new System.Drawing.Point(366, 62);
            this.MaceSprite.Name = "MaceSprite";
            this.MaceSprite.Size = new System.Drawing.Size(30, 30);
            this.MaceSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaceSprite.TabIndex = 36;
            this.MaceSprite.TabStop = false;
            this.MaceSprite.Visible = false;
            // 
            // BluePotionSprite
            // 
            this.BluePotionSprite.BackColor = System.Drawing.Color.Transparent;
            this.BluePotionSprite.Image = global::TheQuestt.Properties.Resources.potion_blue;
            this.BluePotionSprite.Location = new System.Drawing.Point(330, 62);
            this.BluePotionSprite.Name = "BluePotionSprite";
            this.BluePotionSprite.Size = new System.Drawing.Size(30, 30);
            this.BluePotionSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BluePotionSprite.TabIndex = 35;
            this.BluePotionSprite.TabStop = false;
            this.BluePotionSprite.Visible = false;
            // 
            // RedPotionSprite
            // 
            this.RedPotionSprite.BackColor = System.Drawing.Color.Transparent;
            this.RedPotionSprite.Image = global::TheQuestt.Properties.Resources.potion_red;
            this.RedPotionSprite.Location = new System.Drawing.Point(294, 62);
            this.RedPotionSprite.Name = "RedPotionSprite";
            this.RedPotionSprite.Size = new System.Drawing.Size(30, 30);
            this.RedPotionSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedPotionSprite.TabIndex = 34;
            this.RedPotionSprite.TabStop = false;
            this.RedPotionSprite.Visible = false;
            // 
            // BowSprite
            // 
            this.BowSprite.BackColor = System.Drawing.Color.Transparent;
            this.BowSprite.Image = global::TheQuestt.Properties.Resources.bow;
            this.BowSprite.Location = new System.Drawing.Point(258, 62);
            this.BowSprite.Name = "BowSprite";
            this.BowSprite.Size = new System.Drawing.Size(30, 30);
            this.BowSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BowSprite.TabIndex = 33;
            this.BowSprite.TabStop = false;
            this.BowSprite.Visible = false;
            // 
            // SwordSprite
            // 
            this.SwordSprite.BackColor = System.Drawing.Color.Transparent;
            this.SwordSprite.Image = global::TheQuestt.Properties.Resources.sword;
            this.SwordSprite.Location = new System.Drawing.Point(114, 62);
            this.SwordSprite.Name = "SwordSprite";
            this.SwordSprite.Size = new System.Drawing.Size(30, 30);
            this.SwordSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SwordSprite.TabIndex = 29;
            this.SwordSprite.TabStop = false;
            this.SwordSprite.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(598, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 401);
            this.panel1.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TheQuestt.Properties.Resources.bacground;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 299);
            this.panel2.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheQuestt.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(772, 403);
            this.Controls.Add(this.HitPointPanel);
            this.Controls.Add(this.AttackPanel);
            this.Controls.Add(this.MovePanel);
            this.Controls.Add(this.MaceInvSprite);
            this.Controls.Add(this.BowInvSprite);
            this.Controls.Add(this.BluePotionInvSprite);
            this.Controls.Add(this.RedPotionInvSprite);
            this.Controls.Add(this.SwordInvSprite);
            this.Controls.Add(this.PlayerSprite);
            this.Controls.Add(this.GhostSprite);
            this.Controls.Add(this.GhoulSprite);
            this.Controls.Add(this.BatSprite);
            this.Controls.Add(this.MaceSprite);
            this.Controls.Add(this.BluePotionSprite);
            this.Controls.Add(this.RedPotionSprite);
            this.Controls.Add(this.BowSprite);
            this.Controls.Add(this.SwordSprite);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HitPointPanel.ResumeLayout(false);
            this.HitPointPanel.PerformLayout();
            this.AttackPanel.ResumeLayout(false);
            this.AttackPanel.PerformLayout();
            this.MovePanel.ResumeLayout(false);
            this.MovePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaceInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhostSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhoulSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordSprite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HitPointPanel;
        private System.Windows.Forms.Label PlayerHitPointsCaption;
        private System.Windows.Forms.Label BatHitPointsCaption;
        private System.Windows.Forms.Label GhostHitPointsCaption;
        private System.Windows.Forms.Label GhoulHitPointsCaption;
        private System.Windows.Forms.Label BatHitPoints;
        private System.Windows.Forms.Label GhostHitPoints;
        private System.Windows.Forms.Label GhoulHitPoints;
        private System.Windows.Forms.Label PlayerHitPoints;
        private System.Windows.Forms.TableLayoutPanel AttackPanel;
        private System.Windows.Forms.Label AttackPanelCaption;
        private System.Windows.Forms.Button AttackUp;
        private System.Windows.Forms.Button AttackLeft;
        private System.Windows.Forms.Button AttackRight;
        private System.Windows.Forms.Button AttackDown;
        private System.Windows.Forms.TableLayoutPanel MovePanel;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button MoveLeft;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Label MovePanelCaption;
        private System.Windows.Forms.Button MoveRight;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox MaceInvSprite;
        private System.Windows.Forms.PictureBox BowInvSprite;
        private System.Windows.Forms.PictureBox BluePotionInvSprite;
        private System.Windows.Forms.PictureBox RedPotionInvSprite;
        private System.Windows.Forms.PictureBox SwordInvSprite;
        private System.Windows.Forms.PictureBox PlayerSprite;
        private System.Windows.Forms.PictureBox GhostSprite;
        private System.Windows.Forms.PictureBox GhoulSprite;
        private System.Windows.Forms.PictureBox BatSprite;
        private System.Windows.Forms.PictureBox MaceSprite;
        private System.Windows.Forms.PictureBox BluePotionSprite;
        private System.Windows.Forms.PictureBox RedPotionSprite;
        private System.Windows.Forms.PictureBox BowSprite;
        private System.Windows.Forms.PictureBox SwordSprite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

