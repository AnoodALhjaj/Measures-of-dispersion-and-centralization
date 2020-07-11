namespace DataMining_
{
    partial class RadForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            this.label1 = new System.Windows.Forms.Label();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yassin_ MagdySoliman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1056, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "أدخل القيم المراد حسابها";
            // 
            // radButton1
            // 
            this.radButton1.EnableTheming = false;
            this.radButton1.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radButton1.Location = new System.Drawing.Point(842, 99);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(174, 47);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "<html><span style=\"font-size: medium; font-family: yassin_ magdysoliman\">أضافة</s" +
    "pan></html>";
            this.radButton1.ThemeName = "FluentDark";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radTextBox1
            // 
            this.radTextBox1.AutoSize = false;
            this.radTextBox1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox1.Location = new System.Drawing.Point(743, 152);
            this.radTextBox1.Multiline = true;
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.ReadOnly = true;
            // 
            // 
            // 
            this.radTextBox1.RootElement.Enabled = false;
            this.radTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.radTextBox1.Size = new System.Drawing.Size(488, 336);
            this.radTextBox1.TabIndex = 3;
            this.radTextBox1.ThemeName = "EvalFormTheme";
            // 
            // radTextBox2
            // 
            this.radTextBox2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox2.Location = new System.Drawing.Point(1022, 104);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.Size = new System.Drawing.Size(209, 37);
            this.radTextBox2.TabIndex = 0;
            this.radTextBox2.ThemeName = "FluentDark";
            this.radTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radTextBox2_KeyPress);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.AutoScroll = true;
            this.radLabel1.AutoSize = false;
            this.radLabel1.BorderVisible = true;
            this.radLabel1.Font = new System.Drawing.Font("STV", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.AutoSize = true;
            this.radLabel1.RootElement.ScaleTransform = new System.Drawing.SizeF(0F, 0F);
            this.radLabel1.RootElement.UseDefaultDisabledPaint = true;
            this.radLabel1.Size = new System.Drawing.Size(724, 557);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "<html>النتائج عرض سيتم هنا</html>";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabel1.ThemeName = "FluentDark";
            // 
            // radButton2
            // 
            this.radButton2.EnableTheming = false;
            this.radButton2.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radButton2.Location = new System.Drawing.Point(743, 12);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(174, 47);
            this.radButton2.TabIndex = 2;
            this.radButton2.Text = "<html><span style=\"font-size: medium; font-family: yassin_ magdysoliman\">عرض النت" +
    "يجة</span></html>";
            this.radButton2.ThemeName = "FluentDark";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AlWatanHeadlines-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(858, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = " Enter لا تحتاج لضغط زر الأضافة في كل مرة يمكنك ضغط ";
            // 
            // radButton3
            // 
            this.radButton3.EnableTheming = false;
            this.radButton3.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radButton3.Location = new System.Drawing.Point(757, 99);
            this.radButton3.Name = "radButton3";
            // 
            // 
            // 
            this.radButton3.RootElement.BorderHighlightThickness = 1;
            this.radButton3.Size = new System.Drawing.Size(65, 47);
            this.radButton3.TabIndex = 3;
            this.radButton3.Text = "<html><span style=\"font-size: medium; font-family: yassin_ magdysoliman\">مسح</spa" +
    "n></html>";
            this.radButton3.ThemeName = "FluentDark";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("AlWatanHeadlines-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(994, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = " أَضافة ملف بيانات بصيغة ملف أكسل";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("AlWatanHeadlines-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(684, 640);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 46);
            this.label5.TabIndex = 8;
            this.label5.Text = "عند أختيار ملف أكسل يفضل وضع جميع القيم في عمود واحد ";
            // 
            // radButton4
            // 
            this.radButton4.EnableTheming = false;
            this.radButton4.Font = new System.Drawing.Font("STV", 11.25F, System.Drawing.FontStyle.Bold);
            this.radButton4.Location = new System.Drawing.Point(504, 585);
            this.radButton4.Name = "radButton4";
            this.radButton4.Size = new System.Drawing.Size(174, 62);
            this.radButton4.TabIndex = 3;
            this.radButton4.Text = resources.GetString("radButton4.Text");
            this.radButton4.ThemeName = "FluentDark";
            this.radButton4.Click += new System.EventHandler(this.radButton4_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("STV", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(705, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = " Xslx.أسم الملف";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 662);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Made By Anood Alhjaj";
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 695);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radButton4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radTextBox2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حساب مقاييس التشتت والنزعة المركزية";
            this.ThemeName = "FluentDark";
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadButton radButton4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}