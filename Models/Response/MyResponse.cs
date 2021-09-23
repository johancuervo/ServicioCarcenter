using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioCar.Models.Response
{
    public class MyResponse
    {
        public int Success { get; set; }
        public String Message { get; set; }

        public object Data { get; set; }

    }
}
