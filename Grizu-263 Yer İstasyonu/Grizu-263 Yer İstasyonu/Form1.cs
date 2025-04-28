using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Windows.Forms.DataVisualization.Charting;
using System.Security.Permissions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Reflection.Emit;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Drawing.Drawing2D;


namespace Grizu_263_Yer_İstasyonu
{
    public partial class Form1 : Form
    {
        private string payloadAddress = "0013A20012345678"; // Payload için XBee adresi
        
        float x = 0, y = 0, z = 0;
        bool cx = false, cy = false, cz = false;
        public Form1()
        {
            InitializeComponent();
        }

        string veri = "";
        int portsayisi = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var seriPort in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(seriPort);
                portsayisi++;
            }
            if (portsayisi > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

            //////tablo için kesintisiz veri aktarımı          
            listView1.View = View.Details; // Detaylı görünüm
            listView1.FullRowSelect = true; // Satırların tamamını seçilebilir yap

            //GL.ClearColor(Color.Blue);
            GL.ClearColor(Color.FromArgb(128, 216, 255));
            timer1.Interval = 1;


            //harita
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl.Dock = DockStyle.Fill;
            gMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;

            double lat, lon;
            lat = 41.4565;
            lon = 31.7980;

            gMapControl.Position = new PointLatLng(41.4565, 31.7980);
            gMapControl.Zoom = 9;

            GMapOverlay o = new GMapOverlay("o");
            GMapMarker m = new GMarkerGoogle(new PointLatLng(lat, lon), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);

            gMapControl.Overlays.Add(o);
            o.Markers.Add(m);
            gMapControl.Invalidate();
            gMapControl.Update();

            panel3.Paint += panel3_Paint;
            panel2.Paint += panel2_Paint;
            panel6.Paint += panel6_Paint;
            panel1.Paint += panel1_Paint;
            panel5.Paint += panel5_Paint;

            btnBaslat.Paint += btnBaslat_Paint;
            btnDurdur.Paint += btnDurdur_Paint;
            btnYenile.Paint += btnYenile_Paint;
            button3.Paint += button3_Paint;
            button2.Paint += button2_Paint;
            button5.Paint += button5_Paint;
            button13.Paint += button13_Paint;
            button14.Paint += button14_Paint;
            button1.Paint += button1_Paint;
            button4.Paint += button4_Paint;

            /////cvs kaydetme///////////////7
            string dosyaAdi = "veri.csv";
            File.WriteAllLines(dosyaAdi, new string[] { veri });
        }

        int sayac = 0;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            try
            {
                if (!serialPort1.IsOpen)
                {
                    MessageBox.Show("Port kapalı. Veri okunamıyor.");
                    return;
                }

                veri = serialPort1.ReadLine(); // Global değişkene oku// Seriden gelen veriyi oku
                sayac++;

                string[] bits = veri.Split(',');

                int packetNO = sayac;
                double altitude = double.Parse(bits[5]);
                double temperature = double.Parse(bits[6]);
                double pressure = double.Parse(bits[7]);
                double voltage = double.Parse(bits[8]);

                this.Invoke((MethodInvoker)delegate
                {
                    // ListView'e ekleme
                    ListViewItem newItem = new ListViewItem(bits[0]);
                    newItem.SubItems.Add(bits[1]);
                    newItem.SubItems.Add(packetNO.ToString());
                    newItem.SubItems.Add(bits[3]);
                    newItem.SubItems.Add(bits[4]);
                    newItem.SubItems.Add(bits[5]);
                    newItem.SubItems.Add(bits[6]);
                    newItem.SubItems.Add(bits[7]);
                    newItem.SubItems.Add(bits[8]);
                    newItem.SubItems.Add(bits[9]);
                    newItem.SubItems.Add(bits[10]);
                    newItem.SubItems.Add(bits[11]);
                    newItem.SubItems.Add(bits[12]);
                    
                    listView1.Items.Insert(0, newItem);// Yeni veriyi başa ekle

                    ListViewItem newItem1 = new ListViewItem(bits[13]);
                    newItem1.SubItems.Add(bits[14]);
                    newItem1.SubItems.Add(bits[15]);
                    newItem1.SubItems.Add(bits[16]);
                    newItem1.SubItems.Add(bits[17]);
                    newItem1.SubItems.Add(bits[18]);
                    newItem1.SubItems.Add(bits[19]);
                    newItem1.SubItems.Add(bits[20]);
                    newItem1.SubItems.Add(bits[21]);
                    newItem1.SubItems.Add(bits[22]);
                    newItem1.SubItems.Add(bits[23]);
                    newItem1.SubItems.Add(bits[24]);
                    listView2.Items.Insert(0, newItem1);// Yeni veriyi başa ekle

                    
                    // Grafiklere ekleme                   
                    chart1.Series["TEMPERATURE (°C)"].Points.AddXY(sayac, temperature);
                    chart2.Series["PRESSURE (Pa)"].Points.AddXY(sayac, pressure);
                    chart3.Series["VOLTAGE (V)"].Points.AddXY(sayac, voltage);
                    chart4.Series["ALTITUDE (m)"].Points.AddXY(sayac, altitude);

                });

            }

            //catch (Exception ex)
            //{
            //    MessageBox.Show("Veri işlenirken hata oluştu: " + ex.Message);
            //}

            catch
            {
                // Hatalı veriyi yoksay, işlemeye devam et
            }

        }

        private void csvkaydet(object sender, EventArgs e)
        {
            //veri kaydetme                       
            try
            {
                string csvFilePath = "veriler.csv"; // Dosya yolu
                if (!File.Exists(csvFilePath))
                {
                    File.WriteAllText(csvFilePath, "Tarih,Saat,Veri\n");
                }

                string csvLine = $"{DateTime.Now:yyyy-MM-dd},{DateTime.Now:HH:mm:ss},{veri}";
                File.AppendAllText(csvFilePath, csvLine + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Dosyaya yazılırken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                if (comboBox1.Items.Count > 0)
                {
                    serialPort1.PortName = comboBox1.Text;
                }

                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);

                try
                {
                    serialPort1.DataReceived += serialPort1_DataReceived;

                    serialPort1.Open();
                    MessageBox.Show("Port Açık: " + serialPort1.PortName + "-" + serialPort1.BaudRate);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Port açılırken bir hata oluştu: " + ex.Message);
                }
            }

            if (serialPort1.IsOpen)
            {
                btnBaslat.Enabled = false;
                btnDurdur.Enabled = true;
            }
            serialPort1.DiscardInBuffer(); // Tamponu temizle

            csvkaydet(sender, e); //csv kaydetme
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            MessageBox.Show("Port durduruldu.");
            if (!serialPort1.IsOpen)
            {
                btnBaslat.Enabled = true;
                btnDurdur.Enabled = false;
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            portsayisi = 0;
            if (!serialPort1.IsOpen)
            {
                foreach (var seriPort in SerialPort.GetPortNames())
                {
                    comboBox1.Items.Add(seriPort);
                    portsayisi++;
                }
                string mesaj = "Port girişleri yenilendi!";
                MessageBox.Show(mesaj);
                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
            }
            else
            {
                string mesaj = "Portu Kapattıktan Sonra Tekrar Deneyiniz!";
                MessageBox.Show(mesaj);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string calibration = "CALIBRATION";
                serialPort1.WriteLine(calibration);
                MessageBox.Show("Kalibrasyon komutu gönderildi.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);

            try
            {
                serialPort1.PortName = comboBox1.Text;
                if (!serialPort1.IsOpen)
                {
                    timer1.Start();
                    serialPort1.Open();

                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Bağlantı Kurulamadı!");

            }


            if (cx == false)
                cx = true;
            else
                cx = false;

            if (cy == false)
                cy = true;
            else
                cy = false;

            if (cz == false)
                cz = true;
            else
                cz = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string[] paket;
                paket = veri.Split(',');
                x = Convert.ToInt32(paket[9]);
                y = Convert.ToInt32(paket[10]);
                z = Convert.ToInt32(paket[11]);
                glControl1.Invalidate(); // yeniden çizim
            }
        }
        
        private void button5_Click(object sender, EventArgs e)  //ayrılma butonu
        {
            if (serialPort1.IsOpen)
            {
                string ayrilmaKomutu = "SEPARATION"; // Payload'a gönderilecek ayrılma komutu
                serialPort1.WriteLine(ayrilmaKomutu);
                MessageBox.Show("Ayrılma komutu gönderildi!");
            }
            else
            {
               
            }
        }

        [STAThread]
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Form kapatıldığında seri portu kapat
            if (serialPort1 != null && serialPort1.IsOpen)
            {
                serialPort1.Close();
                MessageBox.Show("Seri port kapatıldı.");                
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            GL.Enable(EnableCap.DepthTest);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
        
        private void gMapControl_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // UTC saatini al
                DateTime utcNow = DateTime.UtcNow;
                string utcString = utcNow.ToString("yyyy-MM-dd HH:mm:ss") + " UTC";               

                // Seri porta gönder
                serialPort1.WriteLine(utcString);
                MessageBox.Show("UTC Zamanı Gönderildi: " + utcString);
            }
            else
            {
                MessageBox.Show("Seri port açık değil!");
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int radius = 20; // Köşe yarıçapı

            // Yuvarlatılmış köşe oluştur
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Sol üst köşe
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90); // Sağ üst köşe
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90); // Sağ alt köşe
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90); // Sol alt köşe
            path.CloseFigure();

            // Panelin kenarlarını yuvarlat
            panel.Region = new Region(path);

            // (Opsiyonel) Kenarlık çiz
            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int radius = 30; // Köşe yarıçapı

            // Yuvarlatılmış köşe oluştur
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Sol üst köşe
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90); // Sağ üst köşe
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90); // Sağ alt köşe
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90); // Sol alt köşe
            path.CloseFigure();

            // Panelin kenarlarını yuvarlat
            panel.Region = new Region(path);

            // (Opsiyonel) Kenarlık çiz
            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int radius = 20; // Köşe yarıçapı

            // Yuvarlatılmış köşe oluştur
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Sol üst köşe
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90); // Sağ üst köşe
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90); // Sağ alt köşe
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90); // Sol alt köşe
            path.CloseFigure();

            // Panelin kenarlarını yuvarlat
            panel.Region = new Region(path);

            // (Opsiyonel) Kenarlık çiz
            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int radius = 20; // Köşe yarıçapı

            // Yuvarlatılmış köşe oluştur
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Sol üst köşe
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90); // Sağ üst köşe
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90); // Sağ alt köşe
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90); // Sol alt köşe
            path.CloseFigure();

            // Panelin kenarlarını yuvarlat
            panel.Region = new Region(path);

            // (Opsiyonel) Kenarlık çiz
            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int radius = 20; // Köşe yarıçapı

            // Yuvarlatılmış köşe oluştur
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Sol üst köşe
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90); // Sağ üst köşe
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90); // Sağ alt köşe
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90); // Sol alt köşe
            path.CloseFigure();

            // Panelin kenarlarını yuvarlat
            panel.Region = new Region(path);

            // (Opsiyonel) Kenarlık çiz
            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void btnBaslat_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (btn != null)
            {
                Graphics g = e.Graphics; 
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Yuvarlak köşe boyutu
                int cornerRadius = 20;

                // Yuvarlak dikdörtgen şekli oluştur
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(btn.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(btn.Width - cornerRadius, btn.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, btn.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Butonu yuvarlak şekle göre kes
                btn.Region = new Region(path);

                // Arka plan boyama
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Kenarlık boyama
                using (Pen pen = new Pen(btn.BackColor, 2))
                {
                    g.DrawPath(pen, path);
                }

                // Metni ortala
                TextRenderer.DrawText(
                    g,
                    btn.Text,
                    btn.Font,
                    btn.ClientRectangle,
                    btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void btnDurdur_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (btn != null)
            {
                Graphics g = e.Graphics; 
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Yuvarlak köşe boyutu
                int cornerRadius = 20;

                // Yuvarlak dikdörtgen şekli oluştur
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(btn.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(btn.Width - cornerRadius, btn.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, btn.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Butonu yuvarlak şekle göre kes
                btn.Region = new Region(path);

                // Arka plan boyama
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Kenarlık boyama
                using (Pen pen = new Pen(btn.BackColor, 2))
                {
                    g.DrawPath(pen, path);
                }

                // Metni ortala
                TextRenderer.DrawText(
                    g,
                    btn.Text,
                    btn.Font,
                    btn.ClientRectangle,
                    btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void btnYenile_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (btn != null)
            {
                Graphics g = e.Graphics; 
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Yuvarlak köşe boyutu
                int cornerRadius = 20;

                // Yuvarlak dikdörtgen şekli oluştur
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(btn.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(btn.Width - cornerRadius, btn.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, btn.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Butonu yuvarlak şekle göre kes
                btn.Region = new Region(path);

                // Arka plan boyama
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Kenarlık boyama
                using (Pen pen = new Pen(btn.BackColor, 2))
                {
                    g.DrawPath(pen, path);
                }

                // Metni ortala
                TextRenderer.DrawText(
                    g,
                    btn.Text,
                    btn.Font,
                    btn.ClientRectangle,
                    btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (btn != null)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Yuvarlak köşe boyutu
                int cornerRadius = 20;

                // Yuvarlak dikdörtgen şekli oluştur
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(btn.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(btn.Width - cornerRadius, btn.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, btn.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Butonu yuvarlak şekle göre kes
                btn.Region = new Region(path);

                // Arka plan boyama
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Kenarlık boyama
                using (Pen pen = new Pen(btn.BackColor, 2))
                {
                    g.DrawPath(pen, path);
                }

                // Metni ortala
                TextRenderer.DrawText(
                    g,
                    btn.Text,
                    btn.Font,
                    btn.ClientRectangle,
                    btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (btn != null)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Yuvarlak köşe boyutu
                int cornerRadius = 20;

                // Yuvarlak dikdörtgen şekli oluştur
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(btn.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(btn.Width - cornerRadius, btn.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, btn.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Butonu yuvarlak şekle göre kes
                btn.Region = new Region(path);

                // Arka plan boyama
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Kenarlık boyama
                using (Pen pen = new Pen(btn.BackColor, 2))
                {
                    g.DrawPath(pen, path);
                }

                // Metni ortala
                TextRenderer.DrawText(
                    g,
                    btn.Text,
                    btn.Font,
                    btn.ClientRectangle,
                    btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void button5_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (btn != null)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Yuvarlak köşe boyutu
                int cornerRadius = 20;

                // Yuvarlak dikdörtgen şekli oluştur
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(btn.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(btn.Width - cornerRadius, btn.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, btn.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Butonu yuvarlak şekle göre kes
                btn.Region = new Region(path);

                // Arka plan boyama
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Kenarlık boyama
                using (Pen pen = new Pen(btn.BackColor, 2))
                {
                    g.DrawPath(pen, path);
                }

                // Metni ortala
                TextRenderer.DrawText(
                    g,
                    btn.Text,
                    btn.Font,
                    btn.ClientRectangle,
                    btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void button13_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (btn != null)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Yuvarlak köşe boyutu
                int cornerRadius = 20;

                // Yuvarlak dikdörtgen şekli oluştur
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(btn.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(btn.Width - cornerRadius, btn.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, btn.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Butonu yuvarlak şekle göre kes
                btn.Region = new Region(path);

                // Arka plan boyama
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Kenarlık boyama
                using (Pen pen = new Pen(btn.BackColor, 2))
                {
                    g.DrawPath(pen, path);
                }

                // Metni ortala
                TextRenderer.DrawText(
                    g,
                    btn.Text,
                    btn.Font,
                    btn.ClientRectangle,
                    btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void button14_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (btn != null)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Yuvarlak köşe boyutu
                int cornerRadius = 20;

                // Yuvarlak dikdörtgen şekli oluştur
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(btn.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(btn.Width - cornerRadius, btn.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, btn.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Butonu yuvarlak şekle göre kes
                btn.Region = new Region(path);

                // Arka plan boyama
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Kenarlık boyama
                using (Pen pen = new Pen(btn.BackColor, 2))
                {
                    g.DrawPath(pen, path);
                }

                // Metni ortala
                TextRenderer.DrawText(
                    g,
                    btn.Text,
                    btn.Font,
                    btn.ClientRectangle,
                    btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (btn != null)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Yuvarlak köşe boyutu
                int cornerRadius = 20;

                // Yuvarlak dikdörtgen şekli oluştur
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(btn.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(btn.Width - cornerRadius, btn.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, btn.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Butonu yuvarlak şekle göre kes
                btn.Region = new Region(path);

                // Arka plan boyama
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Kenarlık boyama
                using (Pen pen = new Pen(btn.BackColor, 2))
                {
                    g.DrawPath(pen, path);
                }

                // Metni ortala
                TextRenderer.DrawText(
                    g,
                    btn.Text,
                    btn.Font,
                    btn.ClientRectangle,
                    btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void button4_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (btn != null)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Yuvarlak köşe boyutu
                int cornerRadius = 20;

                // Yuvarlak dikdörtgen şekli oluştur
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(btn.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(btn.Width - cornerRadius, btn.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, btn.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Butonu yuvarlak şekle göre kes
                btn.Region = new Region(path);

                // Arka plan boyama
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Kenarlık boyama
                using (Pen pen = new Pen(btn.BackColor, 2))
                {
                    g.DrawPath(pen, path);
                }

                // Metni ortala
                TextRenderer.DrawText(
                    g,
                    btn.Text,
                    btn.Font,
                    btn.ClientRectangle,
                    btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void glControl1_Paint_1(object sender, PaintEventArgs e)
        {
            float step = 1.0f;
            float topla = step;
            float radius = 4.0f;
            float dikey1 = radius, dikey2 = -radius;
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Clear(ClearBufferMask.DepthBufferBit);
            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(1.04f, 4 / 3, 1, 10000);
            Matrix4 lookat = Matrix4.LookAt(25, 0, 0, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.LoadMatrix(ref perspective);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.LoadMatrix(ref lookat);
            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);
            GL.Rotate(x, 1.0, 0.0, 0.0);//ÖNEMLİ
            GL.Rotate(z, 0.0, 1.0, 0.0);
            GL.Rotate(y, 0.0, 0.0, 1.0);

            silindir(step, topla, radius, 3, -5);
            silindir(0.01f, topla, 0.5f, 9, 9.7f);
            silindir(0.01f, topla, 0.1f, 5, dikey1 + 5);
            koni(0.01f, 0.01f, radius, 3.0f, 3, 5);
            koni(0.01f, 0.01f, radius, 2.0f, -5.0f, -10.0f);
            Pervane(9.0f, 8.0f, 0.2f, 0.5f);
            Pervane2(13.0f, 11.0f, 0.2f, 0.5f);

            GL.Begin(BeginMode.Lines);
            GL.Color3(Color.FromArgb(250, 0, 0));
            GL.Vertex3(-30.0, 0.0, 0.0);
            GL.Vertex3(30.0, 0.0, 0.0);
            GL.Color3(Color.FromArgb(0, 0, 0));
            GL.Vertex3(0.0, 30.0, 0.0);
            GL.Vertex3(0.0, -30.0, 0.0);
            GL.Color3(Color.FromArgb(0, 0, 250));
            GL.Vertex3(0.0, 0.0, 30.0);
            GL.Vertex3(0.0, 0.0, -30.0);
            GL.End();
            //GraphicsContext.CurrentContext.VSync = true;
            glControl1.SwapBuffers();
        }

        private void silindir(float step, float topla, float radius, float dikey1, float dikey2)
        {
            float eski_step = 0.1f;
            GL.Begin(BeginMode.Quads);//Y EKSEN CIZIM DAİRENİN
            while (step <= 360)
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 87, 0));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(255, 255, 255));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 87, 0));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(255, 255, 255));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 87, 0));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(255, 255, 255));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 87, 0));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(255, 255, 255));
                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);
                float ciz2_x = (float)(radius * Math.Cos((step + 2) * Math.PI / 180F));
                float ciz2_y = (float)(radius * Math.Sin((step + 2) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey1, ciz2_y);
                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();
            GL.Begin(BeginMode.Lines);
            step = eski_step;
            topla = step;
            while (step <= 180)// UST KAPAK
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 87, 0));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 87, 0));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 87, 0));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 87, 0));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);
                float ciz2_x = (float)(radius * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey1, ciz2_y);
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);
                GL.Vertex3(ciz2_x, dikey1, ciz2_y);
                step += topla;
            }
            step = eski_step;
            topla = step;
            while (step <= 180)//ALT KAPAK
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 87, 0));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 87, 0));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 87, 0));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 87, 0));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                float ciz2_x = (float)(radius * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();
        }
        private void koni(float step, float topla, float radius1, float radius2, float dikey1, float dikey2)
        {
            float eski_step = 0.1f;
            GL.Begin(BeginMode.Lines);//Y EKSEN CIZIM DAİRENİN
            while (step <= 360)
            {
                if (step < 45)
                    GL.Color3(1.0, 1.0, 1.0);
                else if (step < 90)
                    GL.Color3(1.0f, 0.341f, 0.0f);
                else if (step < 135)
                    GL.Color3(1.0, 1.0, 1.0);
                else if (step < 180)
                    GL.Color3(1.0f, 0.341f, 0.0f);
                else if (step < 225)
                    GL.Color3(1.0, 1.0, 1.0);
                else if (step < 270)
                    GL.Color3(1.0f, 0.341f, 0.0f);
                else if (step < 315)
                    GL.Color3(1.0, 1.0, 1.0);
                else if (step < 360)
                    GL.Color3(1.0f, 0.341f, 0.0f);
                float ciz1_x = (float)(radius1 * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius1 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);
                float ciz2_x = (float)(radius2 * Math.Cos(step * Math.PI / 180F));
                float ciz2_y = (float)(radius2 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();
            GL.Begin(BeginMode.Lines);
            step = eski_step;
            topla = step;
            while (step <= 180)// UST KAPAK
            {
                if (step < 45)
                    GL.Color3(Color.FromArgb(255, 87, 0));
                else if (step < 90)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 135)
                    GL.Color3(Color.FromArgb(255, 87, 0));
                else if (step < 180)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 225)
                    GL.Color3(Color.FromArgb(255, 87, 0));
                else if (step < 270)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                else if (step < 315)
                    GL.Color3(Color.FromArgb(255, 87, 0));
                else if (step < 360)
                    GL.Color3(Color.FromArgb(250, 250, 200));
                float ciz1_x = (float)(radius2 * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius2 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                float ciz2_x = (float)(radius2 * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius2 * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            step = eski_step;
            topla = step;
            GL.End();
        }
        private void Pervane(float yukseklik, float uzunluk, float kalinlik, float egiklik)
        {
            float radius = 10, angle = 45.0f;
            GL.Begin(BeginMode.Quads);
            GL.Color3(1.0f, 0.341f, 0.0f);
            GL.Vertex3(uzunluk, yukseklik, kalinlik);
            GL.Vertex3(uzunluk, yukseklik + egiklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik + egiklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik, kalinlik);
            GL.Color3(1.0f, 0.49f, 0.22f);
            GL.Vertex3(-uzunluk, yukseklik + egiklik, kalinlik);
            GL.Vertex3(-uzunluk, yukseklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik + egiklik, kalinlik);
            GL.Color3(1.0f, 0.49f, 0.22f);
            GL.Vertex3(kalinlik, yukseklik, -uzunluk);
            GL.Vertex3(-kalinlik, yukseklik + egiklik, -uzunluk);
            GL.Vertex3(-kalinlik, yukseklik + egiklik, 0.0);//+
            GL.Vertex3(kalinlik, yukseklik, 0.0);//-
            GL.Color3(Color.White);
            GL.Vertex3(kalinlik, yukseklik + egiklik, +uzunluk);
            GL.Vertex3(-kalinlik, yukseklik, +uzunluk);
            GL.Vertex3(-kalinlik, yukseklik, 0.0);
            GL.Vertex3(kalinlik, yukseklik + egiklik, 0.0);
            GL.End();
        }

        private void Pervane2(float yukseklik, float uzunluk, float kalinlik, float egiklik)//Nurullah
        {
            float radius = 15, angle = 45.0f;
            GL.Begin(BeginMode.Quads);
            GL.Color3(Color.White);
            GL.Vertex3(uzunluk, yukseklik, kalinlik);
            GL.Vertex3(uzunluk, yukseklik + egiklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik + egiklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik, kalinlik);
            GL.Color3(Color.White);
            GL.Vertex3(-uzunluk, yukseklik + egiklik, kalinlik);
            GL.Vertex3(-uzunluk, yukseklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik, -kalinlik);
            GL.Vertex3(0.0, yukseklik + egiklik, kalinlik);
            GL.Color3(Color.White);
            GL.Vertex3(kalinlik, yukseklik, -uzunluk);
            GL.Vertex3(-kalinlik, yukseklik + egiklik, -uzunluk);
            GL.Vertex3(-kalinlik, yukseklik + egiklik, 0.0);//+
            GL.Vertex3(kalinlik, yukseklik, 0.0);//-
            GL.Color3(1.0f, 0.49f, 0.22f);
            GL.Vertex3(kalinlik, yukseklik + egiklik, +uzunluk);
            GL.Vertex3(-kalinlik, yukseklik, +uzunluk);
            GL.Vertex3(-kalinlik, yukseklik, 0.0);
            GL.Vertex3(kalinlik, yukseklik + egiklik, 0.0);
            GL.End();
        }

    }
}
