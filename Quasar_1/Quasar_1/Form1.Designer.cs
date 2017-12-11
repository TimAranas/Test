namespace Quasar_1
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
            this.SuspendLayout();
            // 
            // b_die1
            // 
            this.b_die1.Location = new System.Drawing.Point(42, 107);
            this.b_die1.Name = "b_die1";
            this.b_die1.Size = new System.Drawing.Size(75, 23);
            this.b_die1.TabIndex = 0;
            this.b_die1.Text = "1-8";
            this.b_die1.UseVisualStyleBackColor = true;
            this.b_die1.Click += new System.EventHandler(this.b_die1_Click);
            // 
            // b_die2
            // 
            this.b_die2.Location = new System.Drawing.Point(166, 107);
            this.b_die2.Name = "b_die2";
            this.b_die2.Size = new System.Drawing.Size(75, 23);
            this.b_die2.TabIndex = 1;
            this.b_die2.Text = "4-7";
            this.b_die2.UseVisualStyleBackColor = true;
            this.b_die2.Click += new System.EventHandler(this.b_die2_Click);
            // 
            // b_fold
            // 
            this.b_fold.Location = new System.Drawing.Point(105, 136);
            this.b_fold.Name = "b_fold";
            this.b_fold.Size = new System.Drawing.Size(75, 23);
            this.b_fold.TabIndex = 2;
            this.b_fold.Text = "Fold";
            this.b_fold.UseVisualStyleBackColor = true;
            this.b_fold.Visible = false;
            this.b_fold.Click += new System.EventHandler(this.b_fold_Click);
            // 
            // tb_roll
            // 
            this.tb_roll.Location = new System.Drawing.Point(126, 165);
            this.tb_roll.Name = "tb_roll";
            this.tb_roll.Size = new System.Drawing.Size(32, 20);
            this.tb_roll.TabIndex = 3;
            // 
            // l_total
            // 
            this.l_total.AutoSize = true;
            this.l_total.Location = new System.Drawing.Point(123, 199);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(34, 13);
            this.l_total.TabIndex = 4;
            this.l_total.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.l_total);
            this.Controls.Add(this.tb_roll);
            this.Controls.Add(this.b_fold);
            this.Controls.Add(this.b_die2);
            this.Controls.Add(this.b_die1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_die1;
        private System.Windows.Forms.Button b_die2;
        private System.Windows.Forms.Button b_fold;
        private System.Windows.Forms.TextBox tb_roll;
        private System.Windows.Forms.Label l_total;
    }
}

