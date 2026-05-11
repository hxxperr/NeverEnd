namespace NeverEnd
{
    partial class NeverEnd
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picloc = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMonster = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnBuyPotion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picloc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Location = new System.Drawing.Point(14, 536);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.RowHeadersWidth = 51;
            this.dgvQuests.RowTemplate.Height = 24;
            this.dgvQuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuests.Size = new System.Drawing.Size(338, 184);
            this.dgvQuests.TabIndex = 50;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Location = new System.Drawing.Point(14, 286);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(338, 210);
            this.dgvInventory.TabIndex = 49;
            // 
            // rtbMessages
            // 
            this.rtbMessages.BackColor = System.Drawing.Color.White;
            this.rtbMessages.Location = new System.Drawing.Point(966, 241);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(390, 257);
            this.rtbMessages.TabIndex = 48;
            this.rtbMessages.Text = "";
            this.rtbMessages.TextChanged += new System.EventHandler(this.rtbMessages_TextChanged);
            // 
            // rtbLocation
            // 
            this.rtbLocation.BackColor = System.Drawing.Color.White;
            this.rtbLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbLocation.Location = new System.Drawing.Point(966, 54);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(390, 140);
            this.rtbLocation.TabIndex = 47;
            this.rtbLocation.Text = "";
            // 
            // btnWest
            // 
            this.btnWest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWest.Location = new System.Drawing.Point(1050, 564);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(88, 34);
            this.btnWest.TabIndex = 46;
            this.btnWest.Text = "Запад";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSouth.Location = new System.Drawing.Point(1144, 604);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(88, 34);
            this.btnSouth.TabIndex = 45;
            this.btnSouth.Text = "Юг";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnEast
            // 
            this.btnEast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEast.Location = new System.Drawing.Point(1238, 564);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(88, 34);
            this.btnEast.TabIndex = 44;
            this.btnEast.Text = "Восток";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNorth.Location = new System.Drawing.Point(1144, 524);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(88, 34);
            this.btnNorth.TabIndex = 43;
            this.btnNorth.Text = "Север";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsePotion.Location = new System.Drawing.Point(1238, 703);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(118, 32);
            this.btnUsePotion.TabIndex = 42;
            this.btnUsePotion.Text = "Выпить";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUseWeapon.Location = new System.Drawing.Point(1238, 660);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(118, 32);
            this.btnUseWeapon.TabIndex = 41;
            this.btnUseWeapon.Text = "Атаковать";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // cboPotions
            // 
            this.cboPotions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(1042, 706);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(186, 28);
            this.cboPotions.TabIndex = 40;
            this.cboPotions.SelectedIndexChanged += new System.EventHandler(this.cboPotions_SelectedIndexChanged);
            // 
            // cboWeapons
            // 
            this.cboWeapons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(1042, 663);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(186, 28);
            this.cboWeapons.TabIndex = 39;
            this.cboWeapons.SelectedIndexChanged += new System.EventHandler(this.cboWeapons_SelectedIndexChanged);
            // 
            // lblLevel
            // 
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblLevel.Location = new System.Drawing.Point(190, 146);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(160, 34);
            this.lblLevel.TabIndex = 37;
            // 
            // lblExperience
            // 
            this.lblExperience.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblExperience.Location = new System.Drawing.Point(190, 105);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(160, 34);
            this.lblExperience.TabIndex = 36;
            // 
            // lblGold
            // 
            this.lblGold.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblGold.Location = new System.Drawing.Point(190, 64);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(160, 34);
            this.lblGold.TabIndex = 35;
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblHitPoints.Location = new System.Drawing.Point(190, 23);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(160, 34);
            this.lblHitPoints.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(14, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 32);
            this.label4.TabIndex = 33;
            this.label4.Text = "Уровень";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 32);
            this.label3.TabIndex = 32;
            this.label3.Text = "Опыт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "Золото";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Здоровье";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(14, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 30);
            this.label6.TabIndex = 51;
            this.label6.Text = "Инвентарь";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(966, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 30);
            this.label7.TabIndex = 57;
            this.label7.Text = "События";
            // 
            // picloc
            // 
            this.picloc.BackColor = System.Drawing.Color.Black;
            this.picloc.Image = global::NeverEnd.ImageAssets.LoadImage("pichome.jpg");
            this.picloc.Location = new System.Drawing.Point(372, 23);
            this.picloc.Name = "picloc";
            this.picloc.Size = new System.Drawing.Size(570, 697);
            this.picloc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picloc.TabIndex = 56;
            this.picloc.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::NeverEnd.ImageAssets.LoadImage("lvl.png");
            this.pictureBox4.Location = new System.Drawing.Point(138, 145);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 55;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::NeverEnd.ImageAssets.LoadImage("exp.png");
            this.pictureBox3.Location = new System.Drawing.Point(138, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NeverEnd.ImageAssets.LoadImage("gold.png");
            this.pictureBox2.Location = new System.Drawing.Point(138, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NeverEnd.ImageAssets.LoadImage("heart.png");
            this.pictureBox1.Location = new System.Drawing.Point(138, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(14, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 30);
            this.label8.TabIndex = 58;
            this.label8.Text = "Квесты";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(966, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 30);
            this.label9.TabIndex = 59;
            this.label9.Text = "Локация";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(966, 666);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 60;
            this.label10.Text = "Оружие";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(966, 710);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 61;
            this.label11.Text = "Зелье";
            // 
            // lblMonster
            // 
            this.lblMonster.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMonster.Location = new System.Drawing.Point(966, 621);
            this.lblMonster.Name = "lblMonster";
            this.lblMonster.Size = new System.Drawing.Size(390, 28);
            this.lblMonster.TabIndex = 62;
            // 
            // lblGoal
            // 
            this.lblGoal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGoal.Location = new System.Drawing.Point(14, 194);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(338, 48);
            this.lblGoal.TabIndex = 63;
            this.lblGoal.Text = "Цель: найти Анну и вернуться домой.";
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveGame.Location = new System.Drawing.Point(14, 726);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(162, 34);
            this.btnSaveGame.TabIndex = 64;
            this.btnSaveGame.Text = "Сохранить";
            this.btnSaveGame.UseVisualStyleBackColor = true;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.Location = new System.Drawing.Point(190, 726);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(162, 34);
            this.btnNewGame.TabIndex = 65;
            this.btnNewGame.Text = "Новая игра";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnBuyPotion
            // 
            this.btnBuyPotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyPotion.Location = new System.Drawing.Point(966, 524);
            this.btnBuyPotion.Name = "btnBuyPotion";
            this.btnBuyPotion.Size = new System.Drawing.Size(170, 34);
            this.btnBuyPotion.TabIndex = 66;
            this.btnBuyPotion.Text = "Купить зелье (8)";
            this.btnBuyPotion.UseVisualStyleBackColor = true;
            this.btnBuyPotion.Click += new System.EventHandler(this.btnBuyPotion_Click);
            // 
            // NeverEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1374, 779);
            this.Controls.Add(this.btnBuyPotion);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnSaveGame);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.lblMonster);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picloc);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NeverEnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Never End";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NeverEnd_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picloc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvQuests;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.ComboBox cboPotions;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picloc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMonster;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Button btnSaveGame;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnBuyPotion;
    }
}
