namespace WindowsFormsApp16
{
    partial class MainView
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
            this.oilStationGb = new System.Windows.Forms.GroupBox();
            this.priceTxtb = new System.Windows.Forms.MaskedTextBox();
            this.sumTxtb = new System.Windows.Forms.TextBox();
            this.sumRbtn = new System.Windows.Forms.RadioButton();
            this.litrTxtb = new System.Windows.Forms.TextBox();
            this.litrRbtn = new System.Windows.Forms.RadioButton();
            this.benzinComboBox = new System.Windows.Forms.ComboBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.benzinLbl = new System.Windows.Forms.Label();
            this.calculationGb = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sumLbl = new System.Windows.Forms.Label();
            this.executeBtn = new System.Windows.Forms.Button();
            this.oilStationGb.SuspendLayout();
            this.calculationGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // oilStationGb
            // 
            this.oilStationGb.BackColor = System.Drawing.Color.Transparent;
            this.oilStationGb.Controls.Add(this.priceTxtb);
            this.oilStationGb.Controls.Add(this.sumTxtb);
            this.oilStationGb.Controls.Add(this.sumRbtn);
            this.oilStationGb.Controls.Add(this.litrTxtb);
            this.oilStationGb.Controls.Add(this.litrRbtn);
            this.oilStationGb.Controls.Add(this.benzinComboBox);
            this.oilStationGb.Controls.Add(this.priceLbl);
            this.oilStationGb.Controls.Add(this.benzinLbl);
            this.oilStationGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oilStationGb.ForeColor = System.Drawing.Color.NavajoWhite;
            this.oilStationGb.Location = new System.Drawing.Point(25, 12);
            this.oilStationGb.Name = "oilStationGb";
            this.oilStationGb.Size = new System.Drawing.Size(512, 377);
            this.oilStationGb.TabIndex = 0;
            this.oilStationGb.TabStop = false;
            this.oilStationGb.Text = "Oil-Station";
            // 
            // priceTxtb
            // 
            this.priceTxtb.BackColor = System.Drawing.Color.NavajoWhite;
            this.priceTxtb.Location = new System.Drawing.Point(258, 140);
            this.priceTxtb.Name = "priceTxtb";
            this.priceTxtb.Size = new System.Drawing.Size(148, 29);
            this.priceTxtb.TabIndex = 8;
            // 
            // sumTxtb
            // 
            this.sumTxtb.BackColor = System.Drawing.Color.NavajoWhite;
            this.sumTxtb.Location = new System.Drawing.Point(258, 258);
            this.sumTxtb.Name = "sumTxtb";
            this.sumTxtb.Size = new System.Drawing.Size(148, 29);
            this.sumTxtb.TabIndex = 7;
            // 
            // sumRbtn
            // 
            this.sumRbtn.AutoSize = true;
            this.sumRbtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumRbtn.Location = new System.Drawing.Point(69, 258);
            this.sumRbtn.Name = "sumRbtn";
            this.sumRbtn.Size = new System.Drawing.Size(73, 34);
            this.sumRbtn.TabIndex = 6;
            this.sumRbtn.TabStop = true;
            this.sumRbtn.Text = "Sum";
            this.sumRbtn.UseVisualStyleBackColor = true;
            this.sumRbtn.CheckedChanged += new System.EventHandler(this.sumRbtn_CheckedChanged);
            // 
            // litrTxtb
            // 
            this.litrTxtb.BackColor = System.Drawing.Color.NavajoWhite;
            this.litrTxtb.Location = new System.Drawing.Point(258, 202);
            this.litrTxtb.Name = "litrTxtb";
            this.litrTxtb.Size = new System.Drawing.Size(148, 29);
            this.litrTxtb.TabIndex = 5;
            // 
            // litrRbtn
            // 
            this.litrRbtn.AutoSize = true;
            this.litrRbtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.litrRbtn.Location = new System.Drawing.Point(69, 202);
            this.litrRbtn.Name = "litrRbtn";
            this.litrRbtn.Size = new System.Drawing.Size(148, 34);
            this.litrRbtn.TabIndex = 3;
            this.litrRbtn.TabStop = true;
            this.litrRbtn.Text = "Pay for litr";
            this.litrRbtn.UseVisualStyleBackColor = true;
            this.litrRbtn.CheckedChanged += new System.EventHandler(this.litrRbtn_CheckedChanged);
            // 
            // benzinComboBox
            // 
            this.benzinComboBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.benzinComboBox.ForeColor = System.Drawing.Color.Black;
            this.benzinComboBox.FormattingEnabled = true;
            this.benzinComboBox.Location = new System.Drawing.Point(258, 67);
            this.benzinComboBox.Name = "benzinComboBox";
            this.benzinComboBox.Size = new System.Drawing.Size(148, 32);
            this.benzinComboBox.TabIndex = 1;
            this.benzinComboBox.SelectedIndexChanged += new System.EventHandler(this.benzinComboBox_SelectedIndexChanged);
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLbl.Location = new System.Drawing.Point(64, 139);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(63, 30);
            this.priceLbl.TabIndex = 0;
            this.priceLbl.Text = "Price";
            // 
            // benzinLbl
            // 
            this.benzinLbl.AutoSize = true;
            this.benzinLbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.benzinLbl.Location = new System.Drawing.Point(64, 66);
            this.benzinLbl.Name = "benzinLbl";
            this.benzinLbl.Size = new System.Drawing.Size(77, 30);
            this.benzinLbl.TabIndex = 0;
            this.benzinLbl.Text = "Benzin";
            // 
            // calculationGb
            // 
            this.calculationGb.BackColor = System.Drawing.Color.Transparent;
            this.calculationGb.Controls.Add(this.pictureBox1);
            this.calculationGb.Controls.Add(this.sumLbl);
            this.calculationGb.Controls.Add(this.executeBtn);
            this.calculationGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculationGb.ForeColor = System.Drawing.Color.NavajoWhite;
            this.calculationGb.Location = new System.Drawing.Point(25, 412);
            this.calculationGb.Name = "calculationGb";
            this.calculationGb.Size = new System.Drawing.Size(512, 200);
            this.calculationGb.TabIndex = 1;
            this.calculationGb.TabStop = false;
            this.calculationGb.Text = "Calculation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp16.Properties.Resources.money;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(59, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // sumLbl
            // 
            this.sumLbl.AutoSize = true;
            this.sumLbl.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumLbl.Location = new System.Drawing.Point(270, 72);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(0, 40);
            this.sumLbl.TabIndex = 1;
            // 
            // executeBtn
            // 
            this.executeBtn.AutoSize = true;
            this.executeBtn.BackColor = System.Drawing.Color.NavajoWhite;
            this.executeBtn.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeBtn.ForeColor = System.Drawing.Color.Black;
            this.executeBtn.Location = new System.Drawing.Point(111, 67);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(153, 50);
            this.executeBtn.TabIndex = 0;
            this.executeBtn.Text = "Execute";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp16.Properties.Resources.oilStationImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 647);
            this.Controls.Add(this.calculationGb);
            this.Controls.Add(this.oilStationGb);
            this.Name = "MainView";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.IndianRed;
            this.oilStationGb.ResumeLayout(false);
            this.oilStationGb.PerformLayout();
            this.calculationGb.ResumeLayout(false);
            this.calculationGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilStationGb;
        private System.Windows.Forms.GroupBox calculationGb;
        private System.Windows.Forms.ComboBox benzinComboBox;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label benzinLbl;
        private System.Windows.Forms.TextBox sumTxtb;
        private System.Windows.Forms.RadioButton sumRbtn;
        private System.Windows.Forms.TextBox litrTxtb;
        private System.Windows.Forms.RadioButton litrRbtn;
        private System.Windows.Forms.MaskedTextBox priceTxtb;
        private System.Windows.Forms.Label sumLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button executeBtn;
    }
}

