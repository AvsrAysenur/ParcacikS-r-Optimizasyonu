using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class VeriSetiYukleyici
{
    public static double[][] YükleVeriSeti(string dosyaYolu)
    {
        List<double[]> veriSeti = new List<double[]>();

        try
        {
            if (!File.Exists(dosyaYolu))
            {
                Console.WriteLine($"Dosya bulunamadı: {dosyaYolu}");
                return null;
            }

            using (var reader = new StreamReader(dosyaYolu))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',').Select(double.Parse).ToArray();
                    veriSeti.Add(values);
                }
            }

            return veriSeti.ToArray();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Veri seti yüklenirken bir hata oluştu: {ex.Message}");
            return null;
        }
    }
}
