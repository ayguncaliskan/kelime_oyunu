namespace kelime_oyunu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.harf1lbl = new System.Windows.Forms.Label();
            this.harf2lbl = new System.Windows.Forms.Label();
            this.harf3lbl = new System.Windows.Forms.Label();
            this.harf4lbl = new System.Windows.Forms.Label();
            this.harf5lbl = new System.Windows.Forms.Label();
            this.harf6lbl = new System.Windows.Forms.Label();
            this.harf7lbl = new System.Windows.Forms.Label();
            this.harf8lbl = new System.Windows.Forms.Label();
            this.harf9lbl = new System.Windows.Forms.Label();
            this.harf10lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.harfalbtn = new System.Windows.Forms.Button();
            this.cevaplatxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cevaplabtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.topPuanLbl = new System.Windows.Forms.Label();
            this.baslabtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.zamanlbl = new System.Windows.Forms.Label();
            this.durdurbtn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.oyuncu = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tarihlbl = new System.Windows.Forms.Label();
            this.saatlbl = new System.Windows.Forms.Label();
            this.sonucbtn = new System.Windows.Forms.Button();
            this.sorupuanlbl = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.durlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // harf1lbl
            // 
            this.harf1lbl.AutoSize = true;
            this.harf1lbl.BackColor = System.Drawing.Color.Transparent;
            this.harf1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf1lbl.ForeColor = System.Drawing.Color.White;
            this.harf1lbl.Location = new System.Drawing.Point(168, 121);
            this.harf1lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harf1lbl.Name = "harf1lbl";
            this.harf1lbl.Size = new System.Drawing.Size(48, 25);
            this.harf1lbl.TabIndex = 0;
            this.harf1lbl.Text = "___";
            this.harf1lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // harf2lbl
            // 
            this.harf2lbl.AutoSize = true;
            this.harf2lbl.BackColor = System.Drawing.Color.Transparent;
            this.harf2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf2lbl.ForeColor = System.Drawing.Color.White;
            this.harf2lbl.Location = new System.Drawing.Point(220, 121);
            this.harf2lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harf2lbl.Name = "harf2lbl";
            this.harf2lbl.Size = new System.Drawing.Size(48, 25);
            this.harf2lbl.TabIndex = 1;
            this.harf2lbl.Text = "___";
            // 
            // harf3lbl
            // 
            this.harf3lbl.AutoSize = true;
            this.harf3lbl.BackColor = System.Drawing.Color.Transparent;
            this.harf3lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf3lbl.ForeColor = System.Drawing.Color.White;
            this.harf3lbl.Location = new System.Drawing.Point(272, 121);
            this.harf3lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harf3lbl.Name = "harf3lbl";
            this.harf3lbl.Size = new System.Drawing.Size(48, 25);
            this.harf3lbl.TabIndex = 2;
            this.harf3lbl.Text = "___";
            // 
            // harf4lbl
            // 
            this.harf4lbl.AutoSize = true;
            this.harf4lbl.BackColor = System.Drawing.Color.Transparent;
            this.harf4lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf4lbl.ForeColor = System.Drawing.Color.White;
            this.harf4lbl.Location = new System.Drawing.Point(324, 121);
            this.harf4lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harf4lbl.Name = "harf4lbl";
            this.harf4lbl.Size = new System.Drawing.Size(48, 25);
            this.harf4lbl.TabIndex = 3;
            this.harf4lbl.Text = "___";
            // 
            // harf5lbl
            // 
            this.harf5lbl.AutoSize = true;
            this.harf5lbl.BackColor = System.Drawing.Color.Transparent;
            this.harf5lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf5lbl.ForeColor = System.Drawing.Color.White;
            this.harf5lbl.Location = new System.Drawing.Point(376, 121);
            this.harf5lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harf5lbl.Name = "harf5lbl";
            this.harf5lbl.Size = new System.Drawing.Size(48, 25);
            this.harf5lbl.TabIndex = 4;
            this.harf5lbl.Text = "___";
            // 
            // harf6lbl
            // 
            this.harf6lbl.AutoSize = true;
            this.harf6lbl.BackColor = System.Drawing.Color.Transparent;
            this.harf6lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf6lbl.ForeColor = System.Drawing.Color.White;
            this.harf6lbl.Location = new System.Drawing.Point(428, 121);
            this.harf6lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harf6lbl.Name = "harf6lbl";
            this.harf6lbl.Size = new System.Drawing.Size(48, 25);
            this.harf6lbl.TabIndex = 5;
            this.harf6lbl.Text = "___";
            // 
            // harf7lbl
            // 
            this.harf7lbl.AutoSize = true;
            this.harf7lbl.BackColor = System.Drawing.Color.Transparent;
            this.harf7lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf7lbl.ForeColor = System.Drawing.Color.White;
            this.harf7lbl.Location = new System.Drawing.Point(480, 121);
            this.harf7lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harf7lbl.Name = "harf7lbl";
            this.harf7lbl.Size = new System.Drawing.Size(48, 25);
            this.harf7lbl.TabIndex = 6;
            this.harf7lbl.Text = "___";
            // 
            // harf8lbl
            // 
            this.harf8lbl.AutoSize = true;
            this.harf8lbl.BackColor = System.Drawing.Color.Transparent;
            this.harf8lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf8lbl.ForeColor = System.Drawing.Color.White;
            this.harf8lbl.Location = new System.Drawing.Point(532, 121);
            this.harf8lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harf8lbl.Name = "harf8lbl";
            this.harf8lbl.Size = new System.Drawing.Size(48, 25);
            this.harf8lbl.TabIndex = 7;
            this.harf8lbl.Text = "___";
            // 
            // harf9lbl
            // 
            this.harf9lbl.AutoSize = true;
            this.harf9lbl.BackColor = System.Drawing.Color.Transparent;
            this.harf9lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf9lbl.ForeColor = System.Drawing.Color.White;
            this.harf9lbl.Location = new System.Drawing.Point(584, 121);
            this.harf9lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harf9lbl.Name = "harf9lbl";
            this.harf9lbl.Size = new System.Drawing.Size(48, 25);
            this.harf9lbl.TabIndex = 8;
            this.harf9lbl.Text = "___";
            // 
            // harf10lbl
            // 
            this.harf10lbl.AutoSize = true;
            this.harf10lbl.BackColor = System.Drawing.Color.Transparent;
            this.harf10lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf10lbl.ForeColor = System.Drawing.Color.White;
            this.harf10lbl.Location = new System.Drawing.Point(636, 121);
            this.harf10lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harf10lbl.Name = "harf10lbl";
            this.harf10lbl.Size = new System.Drawing.Size(48, 25);
            this.harf10lbl.TabIndex = 9;
            this.harf10lbl.Text = "___";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(171, 89);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(283, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = ".......................................................";
            // 
            // harfalbtn
            // 
            this.harfalbtn.BackColor = System.Drawing.Color.Red;
            this.harfalbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harfalbtn.ForeColor = System.Drawing.Color.White;
            this.harfalbtn.Location = new System.Drawing.Point(173, 330);
            this.harfalbtn.Margin = new System.Windows.Forms.Padding(4);
            this.harfalbtn.Name = "harfalbtn";
            this.harfalbtn.Size = new System.Drawing.Size(100, 54);
            this.harfalbtn.TabIndex = 11;
            this.harfalbtn.Text = "Harf Al";
            this.harfalbtn.UseVisualStyleBackColor = false;
            this.harfalbtn.Click += new System.EventHandler(this.harfalbtn_Click);
            // 
            // cevaplatxt
            // 
            this.cevaplatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevaplatxt.Location = new System.Drawing.Point(175, 165);
            this.cevaplatxt.Margin = new System.Windows.Forms.Padding(4);
            this.cevaplatxt.Name = "cevaplatxt";
            this.cevaplatxt.Size = new System.Drawing.Size(200, 30);
            this.cevaplatxt.TabIndex = 12;
            this.cevaplatxt.TextChanged += new System.EventHandler(this.cevaplatxt_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(37, 123);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "Kelime  :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(37, 165);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "Cevap  :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(37, 85);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 25);
            this.label14.TabIndex = 15;
            this.label14.Text = "Soru";
            // 
            // cevaplabtn
            // 
            this.cevaplabtn.BackColor = System.Drawing.Color.Red;
            this.cevaplabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevaplabtn.ForeColor = System.Drawing.Color.White;
            this.cevaplabtn.Location = new System.Drawing.Point(308, 330);
            this.cevaplabtn.Margin = new System.Windows.Forms.Padding(4);
            this.cevaplabtn.Name = "cevaplabtn";
            this.cevaplabtn.Size = new System.Drawing.Size(100, 54);
            this.cevaplabtn.TabIndex = 16;
            this.cevaplabtn.Text = "Cevapla";
            this.cevaplabtn.UseVisualStyleBackColor = false;
            this.cevaplabtn.Click += new System.EventHandler(this.cevaplabtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(37, 208);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 25);
            this.label15.TabIndex = 17;
            this.label15.Text = "Puan    :";
            // 
            // topPuanLbl
            // 
            this.topPuanLbl.AutoSize = true;
            this.topPuanLbl.BackColor = System.Drawing.Color.Transparent;
            this.topPuanLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topPuanLbl.ForeColor = System.Drawing.Color.White;
            this.topPuanLbl.Location = new System.Drawing.Point(171, 212);
            this.topPuanLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.topPuanLbl.Name = "topPuanLbl";
            this.topPuanLbl.Size = new System.Drawing.Size(17, 17);
            this.topPuanLbl.TabIndex = 18;
            this.topPuanLbl.Text = "0";
            this.topPuanLbl.Click += new System.EventHandler(this.label16_Click);
            // 
            // baslabtn
            // 
            this.baslabtn.BackColor = System.Drawing.Color.Red;
            this.baslabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.baslabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslabtn.ForeColor = System.Drawing.Color.White;
            this.baslabtn.Location = new System.Drawing.Point(34, 330);
            this.baslabtn.Margin = new System.Windows.Forms.Padding(4);
            this.baslabtn.Name = "baslabtn";
            this.baslabtn.Size = new System.Drawing.Size(100, 54);
            this.baslabtn.TabIndex = 19;
            this.baslabtn.Text = "Başla";
            this.baslabtn.UseVisualStyleBackColor = false;
            this.baslabtn.Click += new System.EventHandler(this.baslabtn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(739, 9);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 25);
            this.label17.TabIndex = 20;
            this.label17.Text = "Süre  :";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // zamanlbl
            // 
            this.zamanlbl.AutoSize = true;
            this.zamanlbl.BackColor = System.Drawing.Color.Transparent;
            this.zamanlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zamanlbl.ForeColor = System.Drawing.Color.White;
            this.zamanlbl.Location = new System.Drawing.Point(813, 9);
            this.zamanlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zamanlbl.Name = "zamanlbl";
            this.zamanlbl.Size = new System.Drawing.Size(82, 25);
            this.zamanlbl.TabIndex = 21;
            this.zamanlbl.Text = "label18";
           
            // durdurbtn
            // 
            this.durdurbtn.BackColor = System.Drawing.Color.Red;
            this.durdurbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durdurbtn.ForeColor = System.Drawing.Color.White;
            this.durdurbtn.Location = new System.Drawing.Point(441, 337);
            this.durdurbtn.Margin = new System.Windows.Forms.Padding(4);
            this.durdurbtn.Name = "durdurbtn";
            this.durdurbtn.Size = new System.Drawing.Size(103, 40);
            this.durdurbtn.TabIndex = 22;
            this.durdurbtn.Text = "Durdur";
            this.durdurbtn.UseVisualStyleBackColor = false;
            this.durdurbtn.Click += new System.EventHandler(this.durdurbtn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(37, 9);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(205, 29);
            this.label19.TabIndex = 23;
            this.label19.Text = "KELİME OYUNU";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Red;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(31, 311);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 25);
            this.label22.TabIndex = 26;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(460, 53);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 20);
            this.label24.TabIndex = 36;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(344, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(152, 29);
            this.label21.TabIndex = 37;
            this.label21.Text = "BAŞARILAR";
            // 
            // oyuncu
            // 
            this.oyuncu.AutoSize = true;
            this.oyuncu.BackColor = System.Drawing.Color.Transparent;
            this.oyuncu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyuncu.ForeColor = System.Drawing.Color.White;
            this.oyuncu.Location = new System.Drawing.Point(504, 9);
            this.oyuncu.Name = "oyuncu";
            this.oyuncu.Size = new System.Drawing.Size(40, 29);
            this.oyuncu.TabIndex = 38;
            this.oyuncu.Text = "---";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // tarihlbl
            // 
            this.tarihlbl.AutoSize = true;
            this.tarihlbl.BackColor = System.Drawing.Color.Transparent;
            this.tarihlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarihlbl.ForeColor = System.Drawing.Color.White;
            this.tarihlbl.Location = new System.Drawing.Point(575, 355);
            this.tarihlbl.Name = "tarihlbl";
            this.tarihlbl.Size = new System.Drawing.Size(20, 17);
            this.tarihlbl.TabIndex = 39;
            this.tarihlbl.Text = "--";
            this.tarihlbl.Click += new System.EventHandler(this.tarihlbl_Click);
            // 
            // saatlbl
            // 
            this.saatlbl.AutoSize = true;
            this.saatlbl.BackColor = System.Drawing.Color.Transparent;
            this.saatlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saatlbl.ForeColor = System.Drawing.Color.White;
            this.saatlbl.Location = new System.Drawing.Point(690, 355);
            this.saatlbl.Name = "saatlbl";
            this.saatlbl.Size = new System.Drawing.Size(20, 17);
            this.saatlbl.TabIndex = 40;
            this.saatlbl.Text = "--";
            this.saatlbl.Click += new System.EventHandler(this.saatlbl_Click);
            // 
            // sonucbtn
            // 
            this.sonucbtn.BackColor = System.Drawing.Color.Red;
            this.sonucbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucbtn.ForeColor = System.Drawing.Color.White;
            this.sonucbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sonucbtn.Location = new System.Drawing.Point(780, 322);
            this.sonucbtn.Margin = new System.Windows.Forms.Padding(4);
            this.sonucbtn.Name = "sonucbtn";
            this.sonucbtn.Size = new System.Drawing.Size(100, 71);
            this.sonucbtn.TabIndex = 41;
            this.sonucbtn.Text = "Sonuç Göster";
            this.sonucbtn.UseVisualStyleBackColor = false;
            this.sonucbtn.Click += new System.EventHandler(this.sonucbtn_Click);
            // 
            // sorupuanlbl
            // 
            this.sorupuanlbl.AutoSize = true;
            this.sorupuanlbl.BackColor = System.Drawing.Color.Transparent;
            this.sorupuanlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorupuanlbl.ForeColor = System.Drawing.Color.White;
            this.sorupuanlbl.Location = new System.Drawing.Point(226, 212);
            this.sorupuanlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sorupuanlbl.Name = "sorupuanlbl";
            this.sorupuanlbl.Size = new System.Drawing.Size(17, 17);
            this.sorupuanlbl.TabIndex = 42;
            this.sorupuanlbl.Text = "0";
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // durlbl
            // 
            this.durlbl.AutoSize = true;
            this.durlbl.BackColor = System.Drawing.Color.Transparent;
            this.durlbl.ForeColor = System.Drawing.Color.White;
            this.durlbl.Location = new System.Drawing.Point(795, 268);
            this.durlbl.Name = "durlbl";
            this.durlbl.Size = new System.Drawing.Size(24, 17);
            this.durlbl.TabIndex = 43;
            this.durlbl.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 428);
            this.Controls.Add(this.durlbl);
            this.Controls.Add(this.sorupuanlbl);
            this.Controls.Add(this.sonucbtn);
            this.Controls.Add(this.saatlbl);
            this.Controls.Add(this.tarihlbl);
            this.Controls.Add(this.oyuncu);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.durdurbtn);
            this.Controls.Add(this.zamanlbl);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.baslabtn);
            this.Controls.Add(this.topPuanLbl);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cevaplabtn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cevaplatxt);
            this.Controls.Add(this.harfalbtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.harf10lbl);
            this.Controls.Add(this.harf9lbl);
            this.Controls.Add(this.harf8lbl);
            this.Controls.Add(this.harf7lbl);
            this.Controls.Add(this.harf6lbl);
            this.Controls.Add(this.harf5lbl);
            this.Controls.Add(this.harf4lbl);
            this.Controls.Add(this.harf3lbl);
            this.Controls.Add(this.harf2lbl);
            this.Controls.Add(this.harf1lbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label harf1lbl;
        private System.Windows.Forms.Label harf2lbl;
        private System.Windows.Forms.Label harf3lbl;
        private System.Windows.Forms.Label harf4lbl;
        private System.Windows.Forms.Label harf5lbl;
        private System.Windows.Forms.Label harf6lbl;
        private System.Windows.Forms.Label harf7lbl;
        private System.Windows.Forms.Label harf8lbl;
        private System.Windows.Forms.Label harf9lbl;
        private System.Windows.Forms.Label harf10lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button harfalbtn;
        private System.Windows.Forms.TextBox cevaplatxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button cevaplabtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label topPuanLbl;
        private System.Windows.Forms.Button baslabtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label zamanlbl;
        private System.Windows.Forms.Button durdurbtn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label oyuncu;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label tarihlbl;
        private System.Windows.Forms.Label saatlbl;
        private System.Windows.Forms.Button sonucbtn;
        private System.Windows.Forms.Label sorupuanlbl;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label durlbl;
    }
}

