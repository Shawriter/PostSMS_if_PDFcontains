using System;
using System.Text;
using System.IO;
using System.Collections;
using System.Globalization;
using System.Linq;
using Twilio;
using Twilio.Exceptions;
using Twilio.Rest.Api.V2010.Account;

namespace tiedostoavaaja
{
    class ViestinLahettaja
    {
        
        public static void ViestinLahetys()
        {
            DateTime time_1 = DateTime.Now;
            // Line 21-97 removed strings
           
            string yks = "";
            string kaks = "";
            string kolm = "";
            string nelj = "";
            string viis = "";
            string kuus = "";
            string seitse = "";
            string kasi = "";
            string ysi = "";
            string kymme = "";
            string ykstois = "";
            string kakstois = "";
            string kolmetois = "";
            string neljatois = "";
            string viistois = "";
            string kuustois = "";
            string seitentois = "";
            string kasitois = "";
            string ysitois = "";
            string kakskyt = "";
            string kakskytyks = "";
            string kakskytkaks = "";
            string kakskytkolme = "";
            string kakskytnelja = "";
            string kakskytviis = "";
            string kakskytkuus = "";
            string kakskytseitseman = "";

            string kakskytkaheksan = "";
            string kakskytyheksan = "";
            string kolkyt = "";

            string hy = yks + nelj + kolmetois + viis + neljatois + kolm + ykstois + kolmetois + seitse + kymme + ysi + kolmetois + kakstois + seitse + ykstois + kakskytyks + kuustois + kakskytseitseman
                + kakstois + kakskytviis + kymme + kakskytkuus + seitentois + kakstois + kolkyt + viis + kakskytyks + ysitois + kakskytkaks;
            
            string encodhy = Convert.ToBase64String(Encoding.UTF8.GetBytes(hy));
            string encodhy_2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(encodhy));
           

            string E = Encoding.UTF8.GetString(Convert.FromBase64String(encodhy));

            byte[] _1 = Encoding.Default.GetBytes("");
            byte[] _2 = Encoding.Default.GetBytes("");
            byte[] _3 = Encoding.Default.GetBytes("");
            byte[] _4 = Encoding.Default.GetBytes("");
            byte[] _5 = Encoding.Default.GetBytes("");
            byte[] _6 = Encoding.Default.GetBytes("");
            byte[] _7 = Encoding.Default.GetBytes("");
            byte[] _8 = Encoding.Default.GetBytes("");
            byte[] _9 = Encoding.Default.GetBytes("");
            byte[] _10 = Encoding.Default.GetBytes("");
            byte[] _11 = Encoding.Default.GetBytes("");
            byte[] _12 = Encoding.Default.GetBytes("");

            string hexString1 = BitConverter.ToString(_1);
            string hexString2 = BitConverter.ToString(_2);
            string hexString3 = BitConverter.ToString(_3);
            string hexString4 = BitConverter.ToString(_4);
            string hexString5 = BitConverter.ToString(_5);
            string hexString6 = BitConverter.ToString(_6);
            string hexString7 = BitConverter.ToString(_7);
            string hexString8 = BitConverter.ToString(_8);
            string hexString9 = BitConverter.ToString(_9);
            string hexString10 = BitConverter.ToString(_10);
            string hexString11 = BitConverter.ToString(_11);
            string hexString12 = BitConverter.ToString(_12);


            string E_2 = hexString5.Replace("-","") + hexString6.Replace("-", "") + hexString4.Replace("-", "") + hexString8.Replace("-", "") + hexString7.Replace("-", "") + hexString10.Replace("-", "") + hexString9.Replace("-", "")
                + hexString12.Replace("-", "") + hexString11.Replace("-", "") + hexString1.Replace("-", "") + hexString3.Replace("-", "") + hexString2.Replace("-", "");
        

            string E_3 = string.Concat(Enumerable.Range(0, E_2.Length / 2).Select(i => (char)int.Parse(E_2.Substring(2 * i, 2), NumberStyles.HexNumber)));


            string S = E;  
            string T = E_3; 
            
            TwilioClient.Init(S, T);
            try
            {
                var message = MessageResource.Create(
                body: "Lähtevää on" + "\r\n" + time_1.ToString().Replace("/", "."),
                from: new Twilio.Types.PhoneNumber(""),
                to: new Twilio.Types.PhoneNumber("") 

            );

                //Console.WriteLine(message.Sid);
               
                Console.WriteLine("Viesti lähetetty Postin kuljettajalle. " + time_1.ToString().Replace("/", ".") + "\r\nViestin sisältö: 'Lähtevää on'");
                Console.ReadKey();
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Twilio Error {e.Code} - {e.MoreInfo}");
                System.Environment.Exit(1);
            }
            
        }
       }
    } 

