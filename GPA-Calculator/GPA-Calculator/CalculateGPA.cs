using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator
{
    public class CalculateGPA
    {
        public double totalweightpoints = 0;
        public int totalunits = 0;
        public int totalunitspassed = 0;


        public string[] AddCourse (string courseCode,int courseUnit, double score)
        {
            var gradeTuple = Gradescore(score);
            double qualitypoint = courseUnit * gradeTuple.Item2;
            string[] row = new string[6];
            row[0] = courseCode;
            row[1] = courseUnit.ToString();
            row[2]=gradeTuple.Item1;
            row[3] =gradeTuple.Item2.ToString();
            row[4] =qualitypoint.ToString();
            row[5] =gradeTuple.Item3;
            totalweightpoints += qualitypoint;
            totalunits += courseUnit;
            if(gradeTuple.Item1 != "F")
                totalunitspassed += courseUnit;
            return row;

        }
         private static Tuple<string,int,string> Gradescore(double score)
        {
            if (score >= 70 && score <= 100)
            {
                return Tuple.Create("A", 5,  "Excelllent");
            }
            else if (score >= 60 && score <= 69)
            {
                return Tuple.Create("B", 4, "very Good");
            }
            else if (score >= 50 && score <= 50)
            {
                return Tuple.Create("C", 3, "Good");
            }
            else if (score >= 45 && score <= 49)
            {
                return Tuple.Create("D", 2, "pass");
            }
            else if (score >= 40 && score <= 44)
            {
                return Tuple.Create("E", 1, "Poor");
            }
            else if (score >= 0 && score <= 39)
            {
                return Tuple.Create("F", 0, "Fail");
            }
            else
            {
                return Tuple.Create("Invalid", -1, "Invalid");
            }
        }
       
    }
}
