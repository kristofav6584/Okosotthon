using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon.Models
{
    public class PushErtesites : Ertesites
    {
        public string EszkozId { get; set; }

        public PushErtesites(string eszkozId)
        {
            EszkozId = eszkozId;
        }

        public override void Kuldes(string uzenet)
        {
            DateTime ido = DateTime.Now;
            Console.WriteLine($"push - {EszkozId} {ido}: {uzenet}");
        }
    }
}
