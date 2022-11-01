using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSG = Tekla.Structures.Geometry3d;

namespace PadFootingsInsertion
{
    public class CoordinatesAlgorithm
    {
        public static List<string> SplitToBlocks(string input)
        {
            //List<string> cor = new List<string>();
            //input = input.Replace('.', ',');
            var cor = input.Split('*').ToList();
            int final = int.Parse(cor[0]);
            for (int i = 1; i <= int.Parse(cor[0]); i++)
            {
                double append = (double)i * double.Parse(cor[1]);
                cor.Add(append.ToString());
            }
            cor.RemoveRange(0, 2);
            return cor;
        }
        public static List<string> SplitToNumbers(string fullXCoordinates)
        {
            fullXCoordinates = fullXCoordinates.Replace('.', ',');
            var x = fullXCoordinates.Split(' ').ToList();
            List<string> fullList = new List<string>();
            foreach (string point in x)
            {
                if (point.Contains("*"))
                {
                    fullList = fullList.Concat(SplitToBlocks(point)).ToList();
                }
                else
                {
                    fullList.Add(point);
                }
            }
            return fullList;
        }
        public static double DoubleConversion(string value)
        {
            double.TryParse(value, out double result);
            return result;
        }

        public static List<TSG.Point> GetInsertionPoints(List<string> xList, List<string> yList)
        {
            List<double> xPoints = xList.Select(x => DoubleConversion(x)).ToList();
            List<double> yPoints = yList.Select(y => DoubleConversion(y)).ToList();
            List<TSG.Point> Coordinates = new List<TSG.Point>();
            for (int i = 0; i < xPoints.Count; i++)
            {
                for (int j = 0; j < yPoints.Count; j++)
                {
                    TSG.Point point = new TSG.Point(xPoints[i], yPoints[j], 0.0);
                    Coordinates.Add(point);
                }
            }
            return Coordinates;
        }
    }
}
