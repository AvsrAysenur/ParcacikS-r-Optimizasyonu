using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using psoproject;

namespace psoproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Veri setini yükle
            string dosyaYolu = "veriseti.csv";
            double[][] veriSeti = VeriSetiYukleyici.YükleVeriSeti(dosyaYolu);

            // Form'dan alınan değerlerin Algoritma Sınıfına uygun değerlerinin alınması
            int parcacık = Convert.ToInt32(nud_parcacık.Value);
            int jenerasyon = Convert.ToInt32(nud_jenerasyon.Value);
            double gbest = Convert.ToDouble(nud_gbest.Value);
            double pbest = Convert.ToDouble(nud_pbest.Value);

            Algoritma algoritma = new Algoritma(parcacık, jenerasyon, gbest, pbest); // PSO Algoritmasının oluşturulması
            double[] eniyifitnessdeger = algoritma.psoalgoritma(veriSeti); // PSO Algoritmasının çalıştırılması ve değerlerin alınması

            // Grafik oluşturma işlemleri
            Series grafik = new Series("Yakınsama")
            {
                ChartType = SeriesChartType.Line, // Çizgi Grafik Oluşturulur
                XValueType = ChartValueType.Int32, // Jenerasyon Değeri int tipindedir
                YValueType = ChartValueType.Double // En İyi Uygunluk Değeri double tipindedir
            };

            for (int i = 0; i < eniyifitnessdeger.Length; i++) // X: Uygunluk Değerleri, Y: Jenerasyon Değeri
                grafik.Points.Add(new DataPoint(i + 1, eniyifitnessdeger[i]));

            if (chart1.Series.Count != 0) // Birden fazla problem çözümünde önceki grafik silinir
                chart1.Series.Clear();

            grafik.Color = Color.Red;
            chart1.ChartAreas["ChartArea1"].Axes[0].Interval = 40; // X değerlerinin aralık boyutu
            chart1.ChartAreas["ChartArea1"].Axes[1].Interval = 0.1; // Y değerlerinin aralık boyutu
            chart1.ChartAreas["ChartArea1"].Axes[1].Maximum = eniyifitnessdeger[0] + 0.08; // Y Değerinin Maximum aralık değeri 
            chart1.ChartAreas["ChartArea1"].Axes[1].Minimum = eniyifitnessdeger[eniyifitnessdeger.Length - 1] - 0.08; // Y Değerinin Minumum aralık değeri
            chart1.Series.Add(grafik); // Sonuçların grafiğe işlenmesi
        }
    }
}
    

