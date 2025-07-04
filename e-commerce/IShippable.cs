using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public interface IShippable
    {
        public string getName();
        public double getWeight();
    }
}
