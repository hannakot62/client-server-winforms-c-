using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pic3Client
{
    [Serializable]
    class Vegetable
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public string color { get; set; }

        public Vegetable(string name, int quantity, string color)
        {
            this.name = name;
            this.quantity = quantity;
            this.color = color;
        }

    }
}
