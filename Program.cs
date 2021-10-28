using System;
using System.Text;
using System.IO;
using System.Collections;
using System.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Globalization;


namespace tiedostoavaaja
{
    class PostiViestiLahettaja
    {


        static void Main(string[] args)
        {


            try {
                DateTime today = DateTime.Now;

                string tnow = today.ToShortDateString();

                string tnow_2 = tnow.ToString().Replace("/", ".");
                string express = "";
                
                var tiedostot_1 = Directory.GetFiles(@"PATH TO FOLDER").Select(x => new FileInfo(x)).OrderByDescending(x => x.LastWriteTime).Take(40).ToArray();
                
                tiedostot_1.GetType(); 

                for (int f = 0; f < tiedostot_1.Length; f++) {

                    var x = tiedostot_1[f].ToString();
                    //Console.WriteLine(f);
                    var reader = new PdfReader(x);
                    string pdfteksti = PdfTextExtractor.GetTextFromPage(reader, 1);
                    pdfteksti = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(pdfteksti)));
                    string pdfteksti_2 = pdfteksti.ToString();



                    //string date = "21.10.2021";
                    //var foooo = pdfteksti_2.Contains(tnow_2);
                    if ((pdfteksti_2.Contains(tnow_2) == true) && (pdfteksti_2.Contains(express) == true))
                    {
                        
                        ViestinLahettaja.ViestinLahetys();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("...");
                        Console.ReadKey();
                        System.Environment.Exit(1);

                    }
                } 
            }
            catch (Exception errori)
            {
                Console.WriteLine(errori);
                Console.ReadKey();
                System.Environment.Exit(1);
            }




            }

        }
    }

