using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Autopartweek7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WriteLine("How many parts would you like to enter?");
            int Partno = Convert.ToInt32(ReadLine());

            Parts[] partarray = new Parts[Partno];
            
            for (int x = 0; x < partarray.Length; x++)
            {
                populatepart(ref partarray[x]);
            }

           
            
            for (int y = 0; y < partarray.Length; y++)
            {
                WriteLine("{0,1}{1,15}", y+1, partarray[y].PartName);

            }
            WriteLine("please enter the the number of the part you would like to view");
            int partslection = Convert.ToInt32(ReadLine());
            printselectedpart(ref partarray[partslection - 1]);



            ReadKey();
        }//closes main
        static void printselectedpart( ref Parts b)
        {
            WriteLine("{0,15}{1,20}{2,20}{3,15}", "Part #", " Part Name", "Part Description", "Cost");
            WriteLine("{0,15}{1,20}{2,20}{3,15}", b.partNumber, b.PartName, b.PartDescription, b.Cost);


        }
        static void populatepart(ref Parts A)
        {
            WriteLine("Please enter the Part #");
            int partnum = Convert.ToInt32(ReadLine());
            WriteLine("Please enter the Part name");
            string partname = ReadLine();
            WriteLine("Please enrter the Part Description");
            string partdescrip = ReadLine();
            WriteLine("Please enter the Part Cost");
            double partcost = Convert.ToDouble(ReadLine());

            A = new Parts(partnum, partcost, partname, partdescrip);
        }
    }
}
