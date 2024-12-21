namespace RPGCharacterGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCharacterDetails;
        private System.Windows.Forms.Button btnChooseWarrior;
        private System.Windows.Forms.Button btnChooseMage;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnLevelUp;
        private System.Windows.Forms.RichTextBox battleLog;

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
            this.lblCharacterDetails = new System.Windows.Forms.Label();
            this.btnChooseWarrior = new System.Windows.Forms.Button();
            this.btnChooseMage = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnLevelUp = new System.Windows.Forms.Button();
            this.battleLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblCharacterDetails
            // 
            this.lblCharacterDetails.AutoSize = true;
            this.lblCharacterDetails.Location = new System.Drawing.Point(12, 90);
            this.lblCharacterDetails.Name = "lblCharacterDetails";
            this.lblCharacterDetails.Size = new System.Drawing.Size(100, 20);
            this.lblCharacterDetails.TabIndex = 0;
            this.lblCharacterDetails.Text = "Character Details";
            // 
            // btnChooseWarrior
            // 
            this.btnChooseWarrior.Location = new System.Drawing.Point(12, 12);
            this.btnChooseWarrior.Name = "btnChooseWarrior";
            this.btnChooseWarrior.Size = new System.Drawing.Size(150, 40);
            this.btnChooseWarrior.TabIndex = 1;
            this.btnChooseWarrior.Text = "Choose Warrior";
            this.btnChooseWarrior.UseVisualStyleBackColor = true;
            this.btnChooseWarrior.Click += new System.EventHandler(this.btnChooseWarrior_Click);
            // 
            // btnChooseMage
            // 
            this.btnChooseMage.Location = new System.Drawing.Point(170, 12);
            this.btnChooseMage.Name = "btnChooseMage";
            this.btnChooseMage.Size = new System.Drawing.Size(150, 40);
            this.btnChooseMage.TabIndex = 2;
            this.btnChooseMage.Text = "Choose Mage";
            this.btnChooseMage.UseVisualStyleBackColor = true;
            this.btnChooseMage.Click += new System.EventHandler(this.btnChooseMage_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(12, 200);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(150, 40);
            this.btnAttack.TabIndex = 3;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnLevelUp
            // 
            this.btnLevelUp.Location = new System.Drawing.Point(170, 200);
            this.btnLevelUp.Name = "btnLevelUp";
            this.btnLevelUp.Size = new System.Drawing.Size(150, 40);
            this.btnLevelUp.TabIndex = 4;
            this.btnLevelUp.Text = "Level Up";
            this.btnLevelUp.UseVisualStyleBackColor = true;
            this.btnLevelUp.Click += new System.EventHandler(this.btnLevelUp_Click);
            // 
            // battleLog
            // 
            this.battleLog.Location = new System.Drawing.Point(12, 260);
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(308, 150);
            this.battleLog.TabIndex = 5;
            this.battleLog.Text = "Battle Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 430);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.btnLevelUp);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnChooseMage);
            this.Controls.Add(this.btnChooseWarrior);
            this.Controls.Add(this.lblCharacterDetails);
            this.Name = "Form1";
            this.Text = "RPG Character Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
