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
        public static List<double> SplitToBlocks(string input)
        {
            var cor = input.Split('*').ToList();
            List <double> result = new List<double>();
            int final = int.Parse(cor[0]);
            for (int i = 1; i <= int.Parse(cor[0]); i++)
            {
                double append =double.Parse(cor[1]);
                result.Add(append);
            }
            return result;
        }
        public static List<double> SplitToNumbers(string fullXCoordinates)
        {
            fullXCoordinates = fullXCoordinates.Replace('.', ',');
            var x = fullXCoordinates.Split(' ').ToList();
            List<double> doubles = new List<double>();
            foreach (string point in x)
            {
                int pointIndex = x.IndexOf(point);
                if (point.Contains("*"))
                {
                    var conversionList = SplitToBlocks(point);
                    for(int i = 0; i < conversionList.Count; i++)
                    {
                        doubles.Add(doubles[doubles.Count - 1] + conversionList[i]);
                    }
                }
                else
                {
                    if(x.IndexOf(point) == 0)
                    {
                        doubles.Add(double.Parse(point));
                    }
                    else
                    {
                        doubles.Add(doubles[doubles.Count - 1] + double.Parse(point));
                    }
                }
            }
            return doubles;
        }
        public static double DoubleConversion(string value)
        {
            double.TryParse(value, out double result);
            return result;
        }

        public static List<TSG.Point> GetInsertionPoints(List<double> xList, List<double> yList)
        {
            List<TSG.Point> Coordinates = new List<TSG.Point>();
            for (int i = 0; i < xList.Count; i++)
            {
                for (int j = 0; j < yList.Count; j++)
                {
                    TSG.Point point = new TSG.Point(xList[i], yList[j], 0.0);
                    Coordinates.Add(point);
                }
            }
            return Coordinates;
        }
    }
}
