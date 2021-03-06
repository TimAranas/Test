﻿namespace Quasar_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_die1 = new System.Windows.Forms.Button();
            this.b_die2 = new System.Windows.Forms.Button();
            this.b_fold = new System.Windows.Forms.Button();
            this.tb_roll = new System.Windows.Forms.TextBox();
            this.l_total = new System.Windows.Forms.Label();
            this.nu_bet = new System.Windows.Forms.NumericUpDown();
            this.l_bet = new System.Windows.Forms.Label();
            this.nu_playrNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.l_profit = new System.Windows.Forms.Label();
            this.l_playerTurn = new System.Windows.Forms.Label();
            this.l_numTurns = new System.Windows.Forms.Label();
            this.b_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nu_bet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_playrNum)).BeginInit();
            this.SuspendLayout();
            // 
            // b_die1
            // 
            this.b_die1.Enabled = false;
            this.b_die1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_die1.Location = new System.Drawing.Point(53, 161);
            this.b_die1.Name = "b_die1";
            this.b_die1.Size = new System.Drawing.Size(72, 42);
            this.b_die1.TabIndex = 0;
            this.b_die1.Text = "1-8";
            this.b_die1.UseVisualStyleBackColor = true;
            this.b_die1.Click += new System.EventHandler(this.b_die1_Click);
            // 
            // b_die2
            // 
            this.b_die2.Enabled = false;
            this.b_die2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_die2.Location = new System.Drawing.Point(144, 161);
            this.b_die2.Name = "b_die2";
            this.b_die2.Size = new System.Drawing.Size(71, 42);
            this.b_die2.TabIndex = 1;
            this.b_die2.Text = "4-7";
            this.b_die2.UseVisualStyleBackColor = true;
            this.b_die2.Click += new System.EventHandler(this.b_die2_Click);
            // 
            // b_fold
            // 
            this.b_fold.Enabled = false;
            this.b_fold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_fold.Location = new System.Drawing.Point(95, 209);
            this.b_fold.Name = "b_fold";
            this.b_fold.Size = new System.Drawing.Size(76, 30);
            this.b_fold.TabIndex = 2;
            this.b_fold.Text = "Fold";
            this.b_fold.UseVisualStyleBackColor = true;
            this.b_fold.Visible = false;
            this.b_fold.Click += new System.EventHandler(this.b_fold_Click);
            // 
            // tb_roll
            // 
            this.tb_roll.Location = new System.Drawing.Point(112, 261);
            this.tb_roll.Name = "tb_roll";
            this.tb_roll.Size = new System.Drawing.Size(32, 20);
            this.tb_roll.TabIndex = 3;
            // 
            // l_total
            // 
            this.l_total.AutoSize = true;
            this.l_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_total.Location = new System.Drawing.Point(109, 299);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(42, 16);
            this.l_total.TabIndex = 4;
            this.l_total.Text = "Total:";
            // 
            // nu_bet
            // 
            this.nu_bet.Enabled = false;
            this.nu_bet.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nu_bet.Location = new System.Drawing.Point(257, 261);
            this.nu_bet.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nu_bet.Name = "nu_bet";
            this.nu_bet.Size = new System.Drawing.Size(120, 20);
            this.nu_bet.TabIndex = 5;
            this.nu_bet.ValueChanged += new System.EventHandler(this.nu_bet_ValueChanged);
            // 
            // l_bet
            // 
            this.l_bet.AutoSize = true;
            this.l_bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_bet.Location = new System.Drawing.Point(276, 232);
            this.l_bet.Name = "l_bet";
            this.l_bet.Size = new System.Drawing.Size(66, 16);
            this.l_bet.TabIndex = 6;
            this.l_bet.Text = "Place Bet";
            // 
            // nu_playrNum
            // 
            this.nu_playrNum.Location = new System.Drawing.Point(86, 59);
            this.nu_playrNum.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nu_playrNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nu_playrNum.Name = "nu_playrNum";
            this.nu_playrNum.Size = new System.Drawing.Size(120, 20);
            this.nu_playrNum.TabIndex = 7;
            this.nu_playrNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nu_playrNum.ValueChanged += new System.EventHandler(this.nu_playrNum_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of Players";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_profit
            // 
            this.l_profit.AutoSize = true;
            this.l_profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_profit.Location = new System.Drawing.Point(109, 348);
            this.l_profit.Name = "l_profit";
            this.l_profit.Size = new System.Drawing.Size(41, 16);
            this.l_profit.TabIndex = 9;
            this.l_profit.Text = "Profit:";
            // 
            // l_playerTurn
            // 
            this.l_playerTurn.AutoSize = true;
            this.l_playerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_playerTurn.Location = new System.Drawing.Point(257, 179);
            this.l_playerTurn.Name = "l_playerTurn";
            this.l_playerTurn.Size = new System.Drawing.Size(130, 24);
            this.l_playerTurn.TabIndex = 10;
            this.l_playerTurn.Text = "Player  \'s Turn";
            // 
            // l_numTurns
            // 
            this.l_numTurns.AutoSize = true;
            this.l_numTurns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_numTurns.Location = new System.Drawing.Point(254, 299);
            this.l_numTurns.Name = "l_numTurns";
            this.l_numTurns.Size = new System.Drawing.Size(113, 16);
            this.l_numTurns.TabIndex = 11;
            this.l_numTurns.Text = "Number of Turns: ";
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(267, 56);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(75, 23);
            this.b_start.TabIndex = 12;
            this.b_start.Text = "Start";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Visible = false;
            this.b_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 426);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.l_numTurns);
            this.Controls.Add(this.l_playerTurn);
            this.Controls.Add(this.l_profit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nu_playrNum);
            this.Controls.Add(this.l_bet);
            this.Controls.Add(this.nu_bet);
            this.Controls.Add(this.l_total);
            this.Controls.Add(this.tb_roll);
            this.Controls.Add(this.b_fold);
            this.Controls.Add(this.b_die2);
            this.Controls.Add(this.b_die1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nu_bet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_playrNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_die1;
        private System.Windows.Forms.Button b_die2;
        private System.Windows.Forms.Button b_fold;
        private System.Windows.Forms.TextBox tb_roll;
        private System.Windows.Forms.Label l_total;
        private System.Windows.Forms.NumericUpDown nu_bet;
        private System.Windows.Forms.Label l_bet;
        private System.Windows.Forms.NumericUpDown nu_playrNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_profit;
        private System.Windows.Forms.Label l_playerTurn;
        private System.Windows.Forms.Label l_numTurns;
        private System.Windows.Forms.Button b_start;
    }
}

