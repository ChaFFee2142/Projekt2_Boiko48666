namespace Projekt2_Boiko48666
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vbBtnPrzedSortowaniem = new System.Windows.Forms.Button();
            this.vbBtnPoSortowaniu = new System.Windows.Forms.Button();
            this.vbBtnWynikiTabelaryczne = new System.Windows.Forms.Button();
            this.vbBtnWykres = new System.Windows.Forms.Button();
            this.vbBtnReset = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.vbTxtMinimalnaProbaBadawcza = new System.Windows.Forms.TextBox();
            this.vbTxtRozmiarTabl = new System.Windows.Forms.TextBox();
            this.vbTxtDolnaGranica = new System.Windows.Forms.TextBox();
            this.vbTxtGornaGranica = new System.Windows.Forms.TextBox();
            this.vbCmbAlgorytmySortowania = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.element = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vbBtnAkceptacja = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rozmiar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosztCzas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosztAnalit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosztPamiec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wybierz kolor linii";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Wybierz kolor tla dla obrzaru wykresu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vbBtnPrzedSortowaniem
            // 
            this.vbBtnPrzedSortowaniem.Enabled = false;
            this.vbBtnPrzedSortowaniem.Location = new System.Drawing.Point(354, 556);
            this.vbBtnPrzedSortowaniem.Name = "vbBtnPrzedSortowaniem";
            this.vbBtnPrzedSortowaniem.Size = new System.Drawing.Size(147, 36);
            this.vbBtnPrzedSortowaniem.TabIndex = 2;
            this.vbBtnPrzedSortowaniem.Text = "Wizualizacja tablicy przed sortowaniem";
            this.vbBtnPrzedSortowaniem.UseVisualStyleBackColor = true;
            this.vbBtnPrzedSortowaniem.Click += new System.EventHandler(this.vbBtnPrzedSortowaniem_Click);
            // 
            // vbBtnPoSortowaniu
            // 
            this.vbBtnPoSortowaniu.Enabled = false;
            this.vbBtnPoSortowaniu.Location = new System.Drawing.Point(523, 556);
            this.vbBtnPoSortowaniu.Name = "vbBtnPoSortowaniu";
            this.vbBtnPoSortowaniu.Size = new System.Drawing.Size(158, 36);
            this.vbBtnPoSortowaniu.TabIndex = 3;
            this.vbBtnPoSortowaniu.Text = "Wizualizacja tablicy po sortowaniu";
            this.vbBtnPoSortowaniu.UseVisualStyleBackColor = true;
            this.vbBtnPoSortowaniu.Click += new System.EventHandler(this.vbBtnPoSortowaniu_Click);
            // 
            // vbBtnWynikiTabelaryczne
            // 
            this.vbBtnWynikiTabelaryczne.Enabled = false;
            this.vbBtnWynikiTabelaryczne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vbBtnWynikiTabelaryczne.Location = new System.Drawing.Point(1140, 274);
            this.vbBtnWynikiTabelaryczne.Name = "vbBtnWynikiTabelaryczne";
            this.vbBtnWynikiTabelaryczne.Size = new System.Drawing.Size(123, 55);
            this.vbBtnWynikiTabelaryczne.TabIndex = 4;
            this.vbBtnWynikiTabelaryczne.Text = "Tabelaryczna prezentacja złożoności";
            this.vbBtnWynikiTabelaryczne.UseVisualStyleBackColor = true;
            this.vbBtnWynikiTabelaryczne.Click += new System.EventHandler(this.vbBtnWynikiTabelaryczne_Click);
            // 
            // vbBtnWykres
            // 
            this.vbBtnWykres.Enabled = false;
            this.vbBtnWykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vbBtnWykres.Location = new System.Drawing.Point(1140, 346);
            this.vbBtnWykres.Name = "vbBtnWykres";
            this.vbBtnWykres.Size = new System.Drawing.Size(123, 63);
            this.vbBtnWykres.TabIndex = 5;
            this.vbBtnWykres.Text = "Graficzna prezentacja złożoności";
            this.vbBtnWykres.UseVisualStyleBackColor = true;
            this.vbBtnWykres.Click += new System.EventHandler(this.vbBtnWykres_Click);
            // 
            // vbBtnReset
            // 
            this.vbBtnReset.Enabled = false;
            this.vbBtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vbBtnReset.Location = new System.Drawing.Point(1140, 428);
            this.vbBtnReset.Name = "vbBtnReset";
            this.vbBtnReset.Size = new System.Drawing.Size(123, 51);
            this.vbBtnReset.TabIndex = 6;
            this.vbBtnReset.Text = "Resetuj (ustaw stan)";
            this.vbBtnReset.UseVisualStyleBackColor = true;
            this.vbBtnReset.Click += new System.EventHandler(this.vbBtnReset_Click);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(1140, 496);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(123, 56);
            this.button8.TabIndex = 7;
            this.button8.Text = "DEMO (symulacja działania)";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(177, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 32);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(522, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "DashDot"});
            this.comboBox1.Location = new System.Drawing.Point(683, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Solid";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1139, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(123, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1135, 100);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(127, 45);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Value = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // vbTxtMinimalnaProbaBadawcza
            // 
            this.vbTxtMinimalnaProbaBadawcza.Location = new System.Drawing.Point(49, 204);
            this.vbTxtMinimalnaProbaBadawcza.Name = "vbTxtMinimalnaProbaBadawcza";
            this.vbTxtMinimalnaProbaBadawcza.Size = new System.Drawing.Size(159, 20);
            this.vbTxtMinimalnaProbaBadawcza.TabIndex = 14;
            this.vbTxtMinimalnaProbaBadawcza.TextChanged += new System.EventHandler(this.vbTxtMinimalnaProbaBadawcza_TextChanged);
            // 
            // vbTxtRozmiarTabl
            // 
            this.vbTxtRozmiarTabl.Location = new System.Drawing.Point(47, 282);
            this.vbTxtRozmiarTabl.Name = "vbTxtRozmiarTabl";
            this.vbTxtRozmiarTabl.Size = new System.Drawing.Size(161, 20);
            this.vbTxtRozmiarTabl.TabIndex = 15;
            this.vbTxtRozmiarTabl.TextChanged += new System.EventHandler(this.vbTxtRozmiarTabl_TextChanged);
            // 
            // vbTxtDolnaGranica
            // 
            this.vbTxtDolnaGranica.Location = new System.Drawing.Point(50, 368);
            this.vbTxtDolnaGranica.Name = "vbTxtDolnaGranica";
            this.vbTxtDolnaGranica.Size = new System.Drawing.Size(157, 20);
            this.vbTxtDolnaGranica.TabIndex = 16;
            this.vbTxtDolnaGranica.TextChanged += new System.EventHandler(this.vbTxtDolnaGranica_TextChanged);
            // 
            // vbTxtGornaGranica
            // 
            this.vbTxtGornaGranica.Location = new System.Drawing.Point(49, 453);
            this.vbTxtGornaGranica.Name = "vbTxtGornaGranica";
            this.vbTxtGornaGranica.Size = new System.Drawing.Size(157, 20);
            this.vbTxtGornaGranica.TabIndex = 17;
            this.vbTxtGornaGranica.TextChanged += new System.EventHandler(this.vbTxtGornaGranica_TextChanged);
            // 
            // vbCmbAlgorytmySortowania
            // 
            this.vbCmbAlgorytmySortowania.FormattingEnabled = true;
            this.vbCmbAlgorytmySortowania.Items.AddRange(new object[] {
            "BubbleSort",
            "ShellSort"});
            this.vbCmbAlgorytmySortowania.Location = new System.Drawing.Point(49, 517);
            this.vbCmbAlgorytmySortowania.Name = "vbCmbAlgorytmySortowania";
            this.vbCmbAlgorytmySortowania.Size = new System.Drawing.Size(159, 21);
            this.vbCmbAlgorytmySortowania.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Wziernik koloru linii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Wziernik koloru tla\r\n dla wykresu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ustaw styl linii wykresu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1141, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Zmien grubość \r\nlinii wykresu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1136, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ustalona grubość linii";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 52);
            this.label7.TabIndex = 25;
            this.label7.Text = "Minimalna próba badawcz\r\n(liczba powtórzeń sortowania \r\ntablicy o tych samych roz" +
    "miarach\r\nale o różnej zawartości";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 26);
            this.label8.TabIndex = 26;
            this.label8.Text = "Maksymalny rozmiar\r\nsortowanych tablic";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 39);
            this.label9.TabIndex = 27;
            this.label9.Text = "Dolna granica przedziału\r\nwartości elementów\r\nsortowanych tablicy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 39);
            this.label10.TabIndex = 28;
            this.label10.Text = "Górna granica przedziału\r\nwartości elementów\r\nsortowanych tablicy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 496);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Wybierz algorytmy do analizy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(232, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(647, 29);
            this.label12.TabIndex = 30;
            this.label12.Text = "Analizator złożoności obliczeniowej algorytmów sortowania";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(12, 592);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Volodymyr Boiko 48666";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.element,
            this.value});
            this.dataGridView1.Location = new System.Drawing.Point(261, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 346);
            this.dataGridView1.TabIndex = 32;
            // 
            // element
            // 
            this.element.HeaderText = "Nr elementu tablicy";
            this.element.Name = "element";
            // 
            // value
            // 
            this.value.HeaderText = "Znaczenie w tablicy";
            this.value.Name = "value";
            // 
            // vbBtnAkceptacja
            // 
            this.vbBtnAkceptacja.Location = new System.Drawing.Point(50, 544);
            this.vbBtnAkceptacja.Name = "vbBtnAkceptacja";
            this.vbBtnAkceptacja.Size = new System.Drawing.Size(158, 31);
            this.vbBtnAkceptacja.TabIndex = 33;
            this.vbBtnAkceptacja.Text = "Akceptacja danych";
            this.vbBtnAkceptacja.UseVisualStyleBackColor = true;
            this.vbBtnAkceptacja.Click += new System.EventHandler(this.vbBtnAkceptacja_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(261, 163);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(765, 346);
            this.chart1.TabIndex = 34;
            this.chart1.Text = "chart1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rozmiar,
            this.kosztCzas,
            this.kosztAnalit,
            this.kosztPamiec});
            this.dataGridView2.Location = new System.Drawing.Point(261, 163);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(765, 346);
            this.dataGridView2.TabIndex = 35;
            // 
            // rozmiar
            // 
            this.rozmiar.HeaderText = "Rozmiar sortowanej tablicy";
            this.rozmiar.Name = "rozmiar";
            // 
            // kosztCzas
            // 
            this.kosztCzas.HeaderText = "Koszt czasowy z pomiaru";
            this.kosztCzas.Name = "kosztCzas";
            // 
            // kosztAnalit
            // 
            this.kosztAnalit.HeaderText = "analityczny koszt czasowy ";
            this.kosztAnalit.Name = "kosztAnalit";
            // 
            // kosztPamiec
            // 
            this.kosztPamiec.HeaderText = "Koszt pamięciowy";
            this.kosztPamiec.Name = "kosztPamiec";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 614);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.vbBtnAkceptacja);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vbCmbAlgorytmySortowania);
            this.Controls.Add(this.vbTxtGornaGranica);
            this.Controls.Add(this.vbTxtDolnaGranica);
            this.Controls.Add(this.vbTxtRozmiarTabl);
            this.Controls.Add(this.vbTxtMinimalnaProbaBadawcza);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.vbBtnReset);
            this.Controls.Add(this.vbBtnWykres);
            this.Controls.Add(this.vbBtnWynikiTabelaryczne);
            this.Controls.Add(this.vbBtnPoSortowaniu);
            this.Controls.Add(this.vbBtnPrzedSortowaniem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button vbBtnPrzedSortowaniem;
        private System.Windows.Forms.Button vbBtnPoSortowaniu;
        private System.Windows.Forms.Button vbBtnWynikiTabelaryczne;
        private System.Windows.Forms.Button vbBtnWykres;
        private System.Windows.Forms.Button vbBtnReset;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox vbTxtMinimalnaProbaBadawcza;
        private System.Windows.Forms.TextBox vbTxtRozmiarTabl;
        private System.Windows.Forms.TextBox vbTxtDolnaGranica;
        private System.Windows.Forms.TextBox vbTxtGornaGranica;
        private System.Windows.Forms.ComboBox vbCmbAlgorytmySortowania;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button vbBtnAkceptacja;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn element;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rozmiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosztCzas;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosztAnalit;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosztPamiec;
    }
}

