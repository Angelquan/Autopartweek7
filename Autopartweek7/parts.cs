using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopartweek7
{
    class Parts
    {
        int partNum;
        double cost;
        string partName, partDescription;

        public Parts(int partNumero, double costo, string partNombre, string partDes)
        {
            partNum = partNumero;
            cost = costo;
            partName = partNombre;
            partDescription = partDes;
        }

        public int partNumber
        {
            get { return partNum; }
            set { partNum = value; }

        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

     
        public string PartDescription
        {
            get { return partDescription; }
            set { partDescription = value; }
        }



        public string PartName
        {
            get { return partName; }
            set { partName = value; }
        }

    }
}
