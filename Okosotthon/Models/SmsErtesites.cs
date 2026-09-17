using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon.Models
{
    public class SmsErtesites : Ertesites
    {
        public string Telefonszam {  get; set; }

        public SmsErtesites(string Telefonszam) 
        {
            Telefonszam = Telefonszam;
        }

        public override void Kuldes(string uzenet)
        {
            DateTime ido = DateTime.Now;
            Console.WriteLine($"SMS - {Telefonszam} {ido}: {uzenet}");
        }
    }
}
