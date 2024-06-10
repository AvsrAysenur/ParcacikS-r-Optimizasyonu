using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psoproject
{
    class Fonks
    {
        public static double Fonk(double[] gelen, double[][] veriSeti)
        {
            // PSO algoritması için uygunluk fonksiyonu
            double uygunluk = (4 * Math.Pow(gelen[0], 2)) - (2.1 * Math.Pow(gelen[0], 4)) + (0.33 * Math.Pow(gelen[0], 6)) + (gelen[0] * gelen[1]) - (4 * Math.Pow(gelen[1], 2)) + (4 * Math.Pow(gelen[1], 4));

            // Eğer veri setini kullanarak uygunluk hesaplaması yapmanız gerekiyorsa,
            // burada uygunluk değerini hesaplamanız gerekecek.
            // Örnek olarak:
            // double uygunluk = VeriSetiIslemleri.Hesapla(gelen, veriSeti);

            return uygunluk;
        }
    }
}
