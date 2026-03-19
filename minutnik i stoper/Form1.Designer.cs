namespace minutnik_i_stoper
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
            components = new System.ComponentModel.Container();
            bstart = new Button();
            bstop = new Button();
            lminuty = new Label();
            lsekundy = new Label();
            tminuty = new TextBox();
            tsekundy = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1 = new TabControl();
            zakladki = new TabPage();
            minutnik = new Label();
            tabPage2 = new TabPage();
            breset2 = new Button();
            bstop2 = new Button();
            bstart2 = new Button();
            stoper = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            zakladki.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // bstart
            // 
            bstart.Location = new Point(153, 122);
            bstart.Name = "bstart";
            bstart.Size = new Size(75, 23);
            bstart.TabIndex = 0;
            bstart.Text = "Start";
            bstart.UseVisualStyleBackColor = true;
            bstart.MouseClick += bstart_MouseClick;
            // 
            // bstop
            // 
            bstop.Location = new Point(328, 122);
            bstop.Name = "bstop";
            bstop.Size = new Size(75, 23);
            bstop.TabIndex = 1;
            bstop.Text = "Stop";
            bstop.UseVisualStyleBackColor = true;
            bstop.MouseClick += bstop_MouseClick;
            // 
            // lminuty
            // 
            lminuty.AutoSize = true;
            lminuty.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lminuty.Location = new Point(157, 43);
            lminuty.Name = "lminuty";
            lminuty.Size = new Size(71, 25);
            lminuty.TabIndex = 2;
            lminuty.Text = "Minuty";
            // 
            // lsekundy
            // 
            lsekundy.AutoSize = true;
            lsekundy.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lsekundy.Location = new Point(328, 43);
            lsekundy.Name = "lsekundy";
            lsekundy.Size = new Size(83, 25);
            lsekundy.TabIndex = 3;
            lsekundy.Text = "Sekundy";
            // 
            // tminuty
            // 
            tminuty.Location = new Point(142, 71);
            tminuty.Name = "tminuty";
            tminuty.Size = new Size(100, 23);
            tminuty.TabIndex = 4;
            tminuty.MouseClick += tminuty_MouseClick;
            // 
            // tsekundy
            // 
            tsekundy.Location = new Point(311, 71);
            tsekundy.Name = "tsekundy";
            tsekundy.Size = new Size(100, 23);
            tsekundy.TabIndex = 5;
            tsekundy.MouseClick += tsekundy_MouseClick;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(zakladki);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(575, 437);
            tabControl1.TabIndex = 6;
            // 
            // zakladki
            // 
            zakladki.Controls.Add(minutnik);
            zakladki.Controls.Add(bstop);
            zakladki.Controls.Add(tminuty);
            zakladki.Controls.Add(tsekundy);
            zakladki.Controls.Add(lminuty);
            zakladki.Controls.Add(lsekundy);
            zakladki.Controls.Add(bstart);
            zakladki.Location = new Point(4, 24);
            zakladki.Name = "zakladki";
            zakladki.Padding = new Padding(3);
            zakladki.Size = new Size(567, 409);
            zakladki.TabIndex = 0;
            zakladki.Text = "Minutnik";
            zakladki.UseVisualStyleBackColor = true;
            // 
            // minutnik
            // 
            minutnik.AutoSize = true;
            minutnik.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 238);
            minutnik.Location = new Point(142, 191);
            minutnik.Name = "minutnik";
            minutnik.Size = new Size(283, 128);
            minutnik.TabIndex = 6;
            minutnik.Text = "00:00";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(breset2);
            tabPage2.Controls.Add(bstop2);
            tabPage2.Controls.Add(bstart2);
            tabPage2.Controls.Add(stoper);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(567, 409);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Stoper";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // breset2
            // 
            breset2.Location = new Point(344, 238);
            breset2.Name = "breset2";
            breset2.Size = new Size(75, 23);
            breset2.TabIndex = 3;
            breset2.Text = "Reset";
            breset2.UseVisualStyleBackColor = true;
            breset2.MouseClick += breset2_MouseClick;
            // 
            // bstop2
            // 
            bstop2.Location = new Point(230, 238);
            bstop2.Name = "bstop2";
            bstop2.Size = new Size(75, 23);
            bstop2.TabIndex = 2;
            bstop2.Text = "Stop";
            bstop2.UseVisualStyleBackColor = true;
            bstop2.MouseClick += bstop2_MouseClick;
            // 
            // bstart2
            // 
            bstart2.Location = new Point(119, 238);
            bstart2.Name = "bstart2";
            bstart2.Size = new Size(75, 23);
            bstart2.TabIndex = 1;
            bstart2.Text = "Start";
            bstart2.UseVisualStyleBackColor = true;
            bstart2.MouseClick += bstart2_MouseClick;
            // 
            // stoper
            // 
            stoper.AutoSize = true;
            stoper.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 238);
            stoper.Location = new Point(136, 56);
            stoper.Name = "stoper";
            stoper.Size = new Size(283, 128);
            stoper.TabIndex = 0;
            stoper.Text = "00:00";
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 461);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "minutnik/stoper";
            tabControl1.ResumeLayout(false);
            zakladki.ResumeLayout(false);
            zakladki.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button bstart;
        private Button bstop;
        private Label lminuty;
        private Label lsekundy;
        private TextBox tminuty;
        private TextBox tsekundy;
        private System.Windows.Forms.Timer timer1;
        private TabControl tabControl1;
        private TabPage zakladki;
        private TabPage tabPage2;
        private Label minutnik;
        private Button breset2;
        private Button bstop2;
        private Button bstart2;
        private Label stoper;
        private System.Windows.Forms.Timer timer2;
    }
}
