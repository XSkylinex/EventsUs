using Microsoft.ML.Runtime.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsUs
{
    public class Numberofcopartner
    {
        [Column("0")]
        public float Sayyes;

        [Column("1", name: "Label")]
        public float RealCome;
    }
}
