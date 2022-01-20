namespace SPOLECNY_PROJECTITICEK
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mocninaBox = new System.Windows.Forms.CheckBox();
            this.faktorialBox = new System.Windows.Forms.CheckBox();
            this.mocninaLabel = new System.Windows.Forms.Label();
            this.faktorialLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 74);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "zmackni me ked jsou cisla zadane";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cislo - N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cislo - A";
            // 
            // mocninaBox
            // 
            this.mocninaBox.AutoSize = true;
            this.mocninaBox.Location = new System.Drawing.Point(95, 119);
            this.mocninaBox.Name = "mocninaBox";
            this.mocninaBox.Size = new System.Drawing.Size(102, 21);
            this.mocninaBox.TabIndex = 11;
            this.mocninaBox.Text = "A na N- tou";
            this.mocninaBox.UseVisualStyleBackColor = true;
            // 
            // faktorialBox
            // 
            this.faktorialBox.AutoSize = true;
            this.faktorialBox.Location = new System.Drawing.Point(95, 146);
            this.faktorialBox.Name = "faktorialBox";
            this.faktorialBox.Size = new System.Drawing.Size(43, 21);
            this.faktorialBox.TabIndex = 12;
            this.faktorialBox.Text = "N!";
            this.faktorialBox.UseVisualStyleBackColor = true;
            // 
            // mocninaLabel
            // 
            this.mocninaLabel.AutoSize = true;
            this.mocninaLabel.Location = new System.Drawing.Point(76, 225);
            this.mocninaLabel.Name = "mocninaLabel";
            this.mocninaLabel.Size = new System.Drawing.Size(61, 17);
            this.mocninaLabel.TabIndex = 13;
            this.mocninaLabel.Text = "mocnina";
            // 
            // faktorialLabel
            // 
            this.faktorialLabel.AutoSize = true;
            this.faktorialLabel.Location = new System.Drawing.Point(76, 259);
            this.faktorialLabel.Name = "faktorialLabel";
            this.faktorialLabel.Size = new System.Drawing.Size(58, 17);
            this.faktorialLabel.TabIndex = 14;
            this.faktorialLabel.Text = "faktorial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SPOLECNY_PROJECTITICEK.Properties.Resources.rarity_my_little_pony_wallpaper_hd_1920x1080_154698__1_;
            this.ClientSize = new System.Drawing.Size(308, 282);
            this.Controls.Add(this.faktorialLabel);
            this.Controls.Add(this.mocninaLabel);
            this.Controls.Add(this.faktorialBox);
            this.Controls.Add(this.mocninaBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox mocninaBox;
        private System.Windows.Forms.CheckBox faktorialBox;
        private System.Windows.Forms.Label mocninaLabel;
        private System.Windows.Forms.Label faktorialLabel;
    }
}

