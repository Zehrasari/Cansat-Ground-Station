using System;
using System.Windows.Forms;

namespace Grizu_263_Yer_İstasyonu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.glControl1 = new OpenTK.GLControl();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.button14.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button14.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.Location = new System.Drawing.Point(237, 58);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(155, 29);
            this.button14.TabIndex = 2;
            this.button14.Text = "CX OFF";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Paint += new System.Windows.Forms.PaintEventHandler(this.button14_Paint);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.button13.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button13.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.Location = new System.Drawing.Point(237, 18);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(155, 28);
            this.button13.TabIndex = 1;
            this.button13.Text = "CX ON";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Paint += new System.Windows.Forms.PaintEventHandler(this.button13_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.button14);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button13);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel5.Location = new System.Drawing.Point(468, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(428, 182);
            this.panel5.TabIndex = 33;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.button5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(39, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 28);
            this.button5.TabIndex = 18;
            this.button5.Text = " MEC";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.Paint += new System.Windows.Forms.PaintEventHandler(this.button5_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.button4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(237, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "SIM.P.";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.Paint += new System.Windows.Forms.PaintEventHandler(this.button4_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(237, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "SIMULATION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(38, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 29);
            this.button3.TabIndex = 16;
            this.button3.Text = "TIME";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.Paint += new System.Windows.Forms.PaintEventHandler(this.button3_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(39, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "CALIBRATION";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Paint += new System.Windows.Forms.PaintEventHandler(this.button2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(34, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Commands";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(172, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 30);
            this.label8.TabIndex = 9;
            this.label8.Text = "Location";
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(16, 34);
            this.glControl1.Margin = new System.Windows.Forms.Padding(7);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(391, 218);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(142, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 30);
            this.label6.TabIndex = 24;
            this.label6.Text = "Satellite View";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnDurdur);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.btnBaslat);
            this.panel2.Controls.Add(this.btnYenile);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(12, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 182);
            this.panel2.TabIndex = 29;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(92, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Grizu-263 Team #3159";
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.btnDurdur.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDurdur.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDurdur.Location = new System.Drawing.Point(257, 97);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(144, 29);
            this.btnDurdur.TabIndex = 6;
            this.btnDurdur.Text = "STOP";
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            this.btnDurdur.Paint += new System.Windows.Forms.PaintEventHandler(this.btnDurdur_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(15, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAUTRATE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grizu_263_Yer_İstasyonu.Properties.Resources.Grizu_263_Uzay_Takımı;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 37);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "54600"});
            this.comboBox2.Location = new System.Drawing.Point(122, 125);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 37);
            this.comboBox2.TabIndex = 4;
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.btnBaslat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBaslat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBaslat.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaslat.Location = new System.Drawing.Point(257, 58);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(144, 29);
            this.btnBaslat.TabIndex = 5;
            this.btnBaslat.Text = "START";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            this.btnBaslat.Paint += new System.Windows.Forms.PaintEventHandler(this.btnBaslat_Paint);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.btnYenile.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYenile.Location = new System.Drawing.Point(257, 140);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(144, 28);
            this.btnYenile.TabIndex = 7;
            this.btnYenile.Text = "REFRESH";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            this.btnYenile.Paint += new System.Windows.Forms.PaintEventHandler(this.btnYenile_Paint);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AutoArrange = false;
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 480);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(1510, 151);
            this.listView1.TabIndex = 35;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Team ID";
            this.columnHeader24.Width = 115;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Time";
            this.columnHeader25.Width = 115;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Packet Count";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mode";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "State";
            this.columnHeader4.Width = 125;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Altitude";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Temperature";
            this.columnHeader6.Width = 168;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Pressure";
            this.columnHeader7.Width = 135;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Voltage";
            this.columnHeader8.Width = 105;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Gyro_R";
            this.columnHeader9.Width = 95;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Gyro_P";
            this.columnHeader10.Width = 95;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Gyro_Y";
            this.columnHeader11.Width = 95;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Accel_R";
            this.columnHeader12.Width = 100;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart4
            // 
            this.chart4.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea5);
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend5.Name = "Legend1";
            this.chart4.Legends.Add(legend5);
            this.chart4.Location = new System.Drawing.Point(307, 242);
            this.chart4.Name = "chart4";
            this.chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "ALTITUDE (m)";
            this.chart4.Series.Add(series5);
            this.chart4.Size = new System.Drawing.Size(277, 201);
            this.chart4.TabIndex = 28;
            this.chart4.Text = "chart4";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea6);
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend6.Name = "Legend1";
            this.chart3.Legends.Add(legend6);
            this.chart3.Location = new System.Drawing.Point(14, 242);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "VOLTAGE (V)";
            this.chart3.Series.Add(series6);
            this.chart3.Size = new System.Drawing.Size(277, 201);
            this.chart3.TabIndex = 29;
            this.chart3.Text = "chart3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(225, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "Graphics";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(307, 47);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series7.Name = "TEMPERATURE (°C)";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(277, 201);
            this.chart1.TabIndex = 26;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend8.Name = "Legend1";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(14, 47);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series8.Name = "PRESSURE (Pa)";
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(277, 201);
            this.chart2.TabIndex = 27;
            this.chart2.Text = "chart2";
            // 
            // listView2
            // 
            this.listView2.AutoArrange = false;
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader2,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23});
            this.listView2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(11, 637);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1510, 147);
            this.listView2.TabIndex = 37;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Accel_P";
            this.columnHeader13.Width = 105;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Accel_Y";
            this.columnHeader14.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mag_R";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Mag_P";
            this.columnHeader15.Width = 100;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Mag_Y";
            this.columnHeader16.Width = 100;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Auto Gyro Rotation Rate";
            this.columnHeader17.Width = 230;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "GpsTime";
            this.columnHeader18.Width = 160;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "GpsAlt";
            this.columnHeader19.Width = 120;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "GpsLat";
            this.columnHeader20.Width = 120;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "GpsLong";
            this.columnHeader21.Width = 120;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "GpsSats";
            this.columnHeader22.Width = 120;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "CmdEcho";
            this.columnHeader23.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.chart3);
            this.panel3.Controls.Add(this.chart4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Controls.Add(this.chart2);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel3.Location = new System.Drawing.Point(918, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 454);
            this.panel3.TabIndex = 39;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.gMapControl);
            this.panel4.Location = new System.Drawing.Point(19, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(393, 218);
            this.panel4.TabIndex = 40;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemory = 5;
            this.gMapControl.Location = new System.Drawing.Point(87, 33);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 9;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(204, 128);
            this.gMapControl.TabIndex = 10;
            this.gMapControl.Zoom = 0D;
            this.gMapControl.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl_MouseClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.glControl1);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel6.Location = new System.Drawing.Point(468, 197);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(428, 263);
            this.panel6.TabIndex = 41;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(13, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 263);
            this.panel1.TabIndex = 42;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grizu-263 Ground Station";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnYenile;
        private OpenTK.GLControl glControl1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        internal System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ListView listView1;
        private Label label3;
        private ColumnHeader columnHeader13;
        private Panel panel3;
        private Panel panel4;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private Panel panel6;
        private Panel panel1;
    }
}

