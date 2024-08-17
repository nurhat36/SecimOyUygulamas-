namespace secim2019
{
    partial class frmGRAFIKLER
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblextrasuper = new System.Windows.Forms.Label();
            this.lblekstra = new System.Windows.Forms.Label();
            this.lblultrasuper = new System.Windows.Forms.Label();
            this.lblsuper = new System.Windows.Forms.Label();
            this.lblhiper = new System.Windows.Forms.Label();
            this.pb4 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.pb3 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.pb5 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.pb2 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(111, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1144, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 28);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "partiler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1136, 247);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "grafikler";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Tomato;
            this.groupBox2.Controls.Add(this.lblextrasuper);
            this.groupBox2.Controls.Add(this.lblekstra);
            this.groupBox2.Controls.Add(this.lblultrasuper);
            this.groupBox2.Controls.Add(this.lblsuper);
            this.groupBox2.Controls.Add(this.lblhiper);
            this.groupBox2.Controls.Add(this.pb4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pb3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pb5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pb1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pb2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(111, 359);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1144, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblextrasuper
            // 
            this.lblextrasuper.AutoSize = true;
            this.lblextrasuper.Location = new System.Drawing.Point(426, 223);
            this.lblextrasuper.Name = "lblextrasuper";
            this.lblextrasuper.Size = new System.Drawing.Size(23, 25);
            this.lblextrasuper.TabIndex = 10;
            this.lblextrasuper.Text = "0";
            // 
            // lblekstra
            // 
            this.lblekstra.AutoSize = true;
            this.lblekstra.Location = new System.Drawing.Point(426, 194);
            this.lblekstra.Name = "lblekstra";
            this.lblekstra.Size = new System.Drawing.Size(23, 25);
            this.lblekstra.TabIndex = 10;
            this.lblekstra.Text = "0";
            // 
            // lblultrasuper
            // 
            this.lblultrasuper.AutoSize = true;
            this.lblultrasuper.Location = new System.Drawing.Point(426, 160);
            this.lblultrasuper.Name = "lblultrasuper";
            this.lblultrasuper.Size = new System.Drawing.Size(23, 25);
            this.lblultrasuper.TabIndex = 10;
            this.lblultrasuper.Text = "0";
            // 
            // lblsuper
            // 
            this.lblsuper.AutoSize = true;
            this.lblsuper.Location = new System.Drawing.Point(426, 131);
            this.lblsuper.Name = "lblsuper";
            this.lblsuper.Size = new System.Drawing.Size(23, 25);
            this.lblsuper.TabIndex = 10;
            this.lblsuper.Text = "0";
            // 
            // lblhiper
            // 
            this.lblhiper.AutoSize = true;
            this.lblhiper.Location = new System.Drawing.Point(426, 102);
            this.lblhiper.Name = "lblhiper";
            this.lblhiper.Size = new System.Drawing.Size(23, 25);
            this.lblhiper.TabIndex = 10;
            this.lblhiper.Text = "0";
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(157, 194);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(262, 23);
            this.pb4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "extra parti:";
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(158, 160);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(262, 23);
            this.pb3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "ultrasuper parti:";
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(158, 223);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(262, 23);
            this.pb5.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "extrasuper parti:";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(158, 102);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(262, 23);
            this.pb1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "hiper parti:";
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(158, 131);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(262, 23);
            this.pb2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "super parti:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ilçe seçin:";
            // 
            // frmGRAFIKLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1279, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGRAFIKLER";
            this.Load += new System.EventHandler(this.frmGRAFIKLER_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pb4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pb3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pb5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar pb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblextrasuper;
        private System.Windows.Forms.Label lblekstra;
        private System.Windows.Forms.Label lblultrasuper;
        private System.Windows.Forms.Label lblsuper;
        private System.Windows.Forms.Label lblhiper;
    }
}