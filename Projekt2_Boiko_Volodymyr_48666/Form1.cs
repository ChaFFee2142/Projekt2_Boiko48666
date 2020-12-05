using System;
using System.Drawing;
using System.Windows.Forms;


namespace Projekt2_Boiko48666
{
    public partial class Form1 : Form
    {
        const int vbMargines = 20;
        int vbProbaBadawcza = 100;
        int vbMaxRozmiarTabl = 50;
        double vbDolnaGranicaWartosci = 20.0;
        double vbGornaGranicaWartosci = 3000000.0;


        double[] vbTabl; //Tablica do sortowania
        double[] vbTablBeforeSort;
        float[] vbWynikiZpomiaru;
        float[] vbWynikiAnalityczne;
        int[] vbKosztPamieciowy;
        int[] vbTablicaLOD; //LOD licznik Operacje Dominujące

        bool vbSortDone;



        public Form1()
        {
            InitializeComponent();

            this.Location = new Point(Screen.PrimaryScreen.Bounds.Left + vbMargines,
                Screen.PrimaryScreen.Bounds.Top + vbMargines);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.75f);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.8f);
            this.StartPosition = FormStartPosition.Manual;
            this.AutoScroll = true;

            
            vbTxtMinimalnaProbaBadawcza.Text = vbMaxRozmiarTabl.ToString();
            vbTxtRozmiarTabl.Text = vbMaxRozmiarTabl.ToString();
            vbTxtDolnaGranica.Text = vbDolnaGranicaWartosci.ToString();
            vbTxtGornaGranica.Text = vbGornaGranicaWartosci.ToString();
            vbCmbAlgorytmySortowania.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            textBox3.Text = trackBar1.Value.ToString();
            textBox2.BackColor = Color.Bisque;
        }

        private void vbBtnAkceptacja_Click(object sender, EventArgs e)
        {
            vbTabl = new double[vbMaxRozmiarTabl];
            vbTablBeforeSort = new double[vbMaxRozmiarTabl];
            vbWynikiZpomiaru = new float[vbMaxRozmiarTabl];
            vbWynikiAnalityczne = new float[vbMaxRozmiarTabl];
            vbTablicaLOD = new int[vbProbaBadawcza];
            vbKosztPamieciowy = new int[vbMaxRozmiarTabl];

            
            vbBtnPrzedSortowaniem.Enabled = true;
            vbBtnPoSortowaniu.Enabled = true;
            vbBtnReset.Enabled = true;
            vbBtnAkceptacja.Enabled = false;
            vbCmbAlgorytmySortowania.Enabled = false;
        }

        private void vbBtnPrzedSortowaniem_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView1.Rows.Clear();

            //Wyświetlić tablicę, jeśli sortowanie już było przeprowadzone
            if (vbSortDone)
            {
                vbWyswietlicTablice(vbTablBeforeSort);
                return;
            }
            vbWykonacSortowanie();
            vbWyswietlicTablice(vbTablBeforeSort);
            MessageBox.Show("Przprowadzono sortowanie algorytmem " + vbCmbAlgorytmySortowania.SelectedItem
                + "\nWyświetlono tablicę niesortowaną");
            vbBtnWynikiTabelaryczne.Enabled = true;
            vbBtnWykres.Enabled = true;
        }

        private void vbBtnPoSortowaniu_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            chart1.Visible = false;
            dataGridView1.Rows.Clear();


            if (vbSortDone)
            {
                vbWyswietlicTablice(vbTabl);
                return;
            }
            vbWykonacSortowanie();
            vbWyswietlicTablice(vbTabl);
            MessageBox.Show("Przprowadzono sortowanie algorytmem " + vbCmbAlgorytmySortowania.SelectedItem);
            vbBtnWynikiTabelaryczne.Enabled = true;
            vbBtnWykres.Enabled = true;
        }

        private void vbBtnWynikiTabelaryczne_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Clear();
            //DGV
            for (int i = 0; i < vbMaxRozmiarTabl; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[0].Value = i;
                dataGridView2.Rows[i].Cells[1].Value =
                    String.Format("{0:F2}", vbWynikiZpomiaru[i]);
                dataGridView2.Rows[i].Cells[2].Value =
                    String.Format("{0:F2}", vbWynikiAnalityczne[i]);
                dataGridView2.Rows[i].Cells[3].Value = i;
                if (i % 2 == 0)
                {
                    dataGridView2.Rows[i].Cells[0].Style.BackColor = Color.LightGray;
                    dataGridView2.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                    dataGridView2.Rows[i].Cells[2].Style.BackColor = Color.LightGray;
                    dataGridView2.Rows[i].Cells[3].Style.BackColor = Color.LightGray;
                }
                else
                {
                    dataGridView2.Rows[i].Cells[0].Style.BackColor = Color.White;
                    dataGridView2.Rows[i].Cells[1].Style.BackColor = Color.White;
                    dataGridView2.Rows[i].Cells[2].Style.BackColor = Color.White;
                    dataGridView2.Rows[i].Cells[3].Style.BackColor = Color.White;
                }
                dataGridView2.Rows[i].Cells[0].Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dataGridView2.Rows[i].Cells[1].Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dataGridView2.Rows[i].Cells[2].Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dataGridView2.Rows[i].Cells[3].Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

            }

            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
            chart1.Visible = false;
            vbBtnPoSortowaniu.Enabled = true;
            vbBtnWynikiTabelaryczne.Enabled = true;





        }

        private void vbBtnWykres_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            chart1.Visible = true;
            chart1.Titles.Clear();
            chart1.Titles.Add("Algorytm" + vbCmbAlgorytmySortowania.SelectedItem);

            int[] vbRozmiarTabeli = new int[vbMaxRozmiarTabl];
            for (int i = 0; i < vbMaxRozmiarTabl; i++)
            {
                vbRozmiarTabeli[i] = i;
            }

            chart1.BackColor = textBox2.BackColor;
            chart1.Legends[0].LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;

            chart1.Series[0].Name = "Koszt czasowy z pomiaru";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].Color = textBox1.BackColor;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    chart1.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
                    break;
                case 1:
                    chart1.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
                    break;
                case 2:
                    chart1.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
                    break;
            }
            errorProvider1.Clear();
            chart1.Series[0].BorderWidth = trackBar1.Value;
            chart1.Series[0].Points.DataBindXY(vbRozmiarTabeli, vbWynikiZpomiaru);

            chart1.Series[1].Name = "Koszt analityczny";
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[1].Color = Color.Green;
            chart1.Series[1].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chart1.Series[1].BorderWidth = trackBar1.Value;
            chart1.Series[1].Points.DataBindXY(vbRozmiarTabeli, vbWynikiAnalityczne);

            chart1.Series[2].Name = "Koszt pamięciowy";
            chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[2].Color = Color.Red;
            chart1.Series[2].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chart1.Series[2].BorderWidth = trackBar1.Value;
            chart1.Series[2].Points.DataBindXY(vbRozmiarTabeli, vbKosztPamieciowy);

        }

        private void vbBtnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //--------------------- Ustawienia wykresu --------------------
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            chart1.Series[0].BorderWidth = trackBar1.Value;
            chart1.Series[1].BorderWidth = trackBar1.Value;
            chart1.Series[2].BorderWidth = trackBar1.Value;
            textBox3.Text = trackBar1.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                chart1.BackColor = MyDialog.Color;
                textBox2.BackColor = MyDialog.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.Color = chart1.Series[0].Color;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                chart1.Series[0].Color = MyDialog.Color;
                textBox1.BackColor = MyDialog.Color;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    chart1.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
                    break;
                case 1:
                    chart1.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
                    break;
                case 2:
                    chart1.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
                    break;
            }
            errorProvider1.Clear();
        }


        //----------------------Input--------------------------------------
        private void vbTxtMinimalnaProbaBadawcza_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(vbTxtMinimalnaProbaBadawcza.Text, out vbProbaBadawcza))
                errorProvider1.SetError(vbTxtMinimalnaProbaBadawcza,
                    "error: w podanej liczności próby badawczej wystąpił niedozwolony znak");
            else errorProvider1.Clear();
        }
        private void vbTxtRozmiarTabl_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(vbTxtRozmiarTabl.Text, out vbMaxRozmiarTabl))
                errorProvider1.SetError(vbTxtRozmiarTabl,
                    "error: w podanej liczności rozmiaru wystąpił niedozwolony znak");
            else errorProvider1.Clear();
        }
        private void vbTxtDolnaGranica_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(vbTxtDolnaGranica.Text, out vbDolnaGranicaWartosci))
                errorProvider1.SetError(vbTxtDolnaGranica,
                    "error: w podanej liczności dolnej granicy wystąpił niedozwolony znak");
            else errorProvider1.Clear();
        }
        private void vbTxtGornaGranica_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(vbTxtGornaGranica.Text, out vbGornaGranicaWartosci))
                errorProvider1.SetError(vbTxtGornaGranica,
                    "error: w podanej liczności górnej granicy wystąpił niedozwolony znak");
            else errorProvider1.Clear();
        }



        //--------------------------Funkcje--------------------------------

        private void vbWykonacSortowanie()
        {
            int vbLicznikOD;
            float vbSumaOD, vbSredniaOD;

            Random Rnd = new Random();
            vbSortowanie vbAlgorytmySortowania = new vbSortowanie();
            //Pętla dla wszystkich rozmiarow
            for (int l = 0; l < vbMaxRozmiarTabl; l++) //L
            {           //Pętla dla wszystkich prób
                for (int k = 0; k < vbProbaBadawcza; k++) //K
                {           //Pętla dla wszystkich elementów tablicy
                    for (int i = 0; i <= l; i++)
                        vbTabl[i] = Rnd.NextDouble() *
                            (vbGornaGranicaWartosci - vbDolnaGranicaWartosci) +
                            vbDolnaGranicaWartosci;

                    //Kopia ostatniej niesortowanej tablicy dla wyświetlania
                    if (l == vbMaxRozmiarTabl - 1)
                    {
                        for (int i = 0; i < vbMaxRozmiarTabl; i++)
                        {
                            vbTablBeforeSort[i] = vbTabl[i];
                        }
                    }
                    //Sortowanie tablicy
                    switch (vbCmbAlgorytmySortowania.SelectedIndex)
                    {
                        case 0:
                            vbLicznikOD = vbAlgorytmySortowania.BubbleSort(ref vbTabl, l);
                            break;
                        case 1:
                            vbLicznikOD = vbAlgorytmySortowania.ShellSort(ref vbTabl, l);
                            break;
                        default:
                            errorProvider1.SetError(vbBtnWynikiTabelaryczne,
                                "Uwaga, jeszcze nie ukończyłem prac nad tym algotytmem");
                            return;
                    }
                    vbTablicaLOD[k] = vbLicznikOD;
                } // koniec prób
                vbSumaOD = 0.0f;
                for (int j = 0; j < vbProbaBadawcza; j++)
                    vbSumaOD += vbTablicaLOD[j];
                vbSredniaOD = vbSumaOD / vbProbaBadawcza;
                vbWynikiZpomiaru[l] = vbSredniaOD;
                switch (vbCmbAlgorytmySortowania.SelectedIndex)
                {
                    case 0:
                        vbWynikiAnalityczne[l] = (l - 1) * (l / 2);
                        break;
                    case 1:
                        vbWynikiAnalityczne[l] = l * (float)Math.Log((double)(l), 2);
                        break;
                    default:
                        errorProvider1.SetError(vbBtnWynikiTabelaryczne,
                            "Uwaga: jeszcze nie ukończyłem prac nad tym algorytmem");
                        return;
                }

                vbKosztPamieciowy[l] = l;
            }// Koniec rozmiarów

            dataGridView1.Visible = true;
            vbBtnPoSortowaniu.Enabled = true;
            vbBtnWykres.Enabled = true;
            vbBtnReset.Enabled = true;
            vbBtnWynikiTabelaryczne.Enabled = true;
            vbBtnPrzedSortowaniem.Enabled = true;
            vbSortDone = true;
        }
        private void vbWyswietlicTablice(double[] vbTablica)
        {
            for (int i = 0; i < vbMaxRozmiarTabl; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i;
                dataGridView1.Rows[i].Cells[1].Value =
                    String.Format("{0, 8:F3}", vbTablica[i]);

                if (i % 2 == 0)
                {
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.LightGray;
                    dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.White;
                    dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.White;
                }
                dataGridView1.Rows[i].Cells[0].Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Rows[i].Cells[1].Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }
            return;
        }

     
    }



    class vbSortowanie                          // Algorytmy BubbleSort i ShellSort
    {
        public int BubbleSort(ref double[] T, int n)
        {
            double vbTemp;
            int vbLicznikOD = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (T[j] > T[j + 1])
                    {
                        vbLicznikOD++;
                        vbTemp = T[j + 1];
                        T[j + 1] = T[j];
                        T[j] = vbTemp;
                    }
                }
            }
            return vbLicznikOD;


        }
        public int ShellSort(ref double[] T, int n)
        {
            int vbLicznickOD = 0;
            int i, j, inc;
            double vbTemp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < n; i++)
                {
                    j = i;
                    vbTemp = T[i];
                    while ((j >= inc) && (T[j - inc] > vbTemp))
                    {
                        vbLicznickOD++;
                        T[j] = T[j - inc];
                        j = j - inc;
                    }
                    T[j] = vbTemp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }

            return vbLicznickOD;
        }
    }

}
