using Okosotthon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ertesites> csatornak = new List<Ertesites>
            {
            new PushErtesites("Hello"),
            new EmailErtesites("hello@hello.com","Riasztás: betörő"),
            new SmsErtesites("+36354325126")
            };

            string riasztasUzenet = "betörő!";

            foreach (Ertesites csatorna in csatornak)
            {
                csatorna.Kuldes(riasztasUzenet);
            }
        }
    }
}
