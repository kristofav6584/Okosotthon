using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon.Models
{
    public class EmailErtesites : Ertesites
    {
        public string Email { get; set; }
        public string Targy { get; set; }

        public EmailErtesites(string email, string targy) 
        {
            Email = email;
            Targy = targy;
        }

        public override void Kuldes(string uzenet)
        {
            DateTime ido = DateTime.Now;
            Console.WriteLine($"Email - {Email} Tárgy: {Targy} {ido}");
        }
    }
}
