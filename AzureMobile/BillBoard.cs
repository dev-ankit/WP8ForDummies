using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureMobile
{
    public class BillBoard
    {
        public String Id { get; set; }
        public String Message { get; set; }

        public override string ToString()
        {
            return Message;
        }
    }
}
