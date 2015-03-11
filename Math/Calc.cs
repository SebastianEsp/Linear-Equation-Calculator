using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Math
{
    class Calc
    {
        public string[] function(string func)
        {
            Regex regex = new Regex(@"\w\(([\w]*)\)=([\d]*|[\w]*)(\**)((\1))(\+)([\w]*|[\d]*)");
            Match match = regex.Match(func);

            string[] result = new string[match.Groups.Count];

            for (int i = 0; i < match.Groups.Count; i++)
            {
                result[i] = match.Groups[i].ToString();
            }
            return result;
        }

        public string getResult(string func)
        {
            Regex regex = new Regex(@"\w+\((\w+)\)=");
            Match match = regex.Match(func);

            string result = match.Groups[1].ToString();
            return result;
        }

        public string[] getPoints(string points)
        {
            Regex regex = new Regex(@"\((\-*\d+|\w+)\.(\-*\d+|\w+)\)");
            Match match = regex.Match(points);

            string[] result = new string[match.Groups.Count];

            for (int i = 0; i < match.Groups.Count; i++)
            {
                result[i] = match.Groups[i].ToString();
            }
            return result;
        }
        public double Y(double a, double x, double b)
        {
            double y = a*x+b;
            return y;
        }

        public double A(double y1, double y2, double x1, double x2)
        {
                double a = (y2 - y1) / (x2 - x1);
                return a;
        }

        public double B(double y1, double a, double x1)
        {
            double b = y1 - a * x1;
            return b;
        }
    }
}
