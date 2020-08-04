using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

// A special namespace has been defined since extension methods are used
namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        /// <summary>
        /// An extension method to load the filepath from appconfig
        /// </summary>
        public static string FullFilePath(this string fileName)
        {
            // returns the filename based on the path set inside appconfig
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }
        /// <summary>
        /// An extension method to load the files from the appropriate path
        /// </summary>
        public static List<string> LoadFile(this string file)
        {
            if(!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList(); 
        }
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                // Create the model from each line
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }
            return output;
        }
        /// <summary>
        /// Write the prizemodel to the specified file
        /// </summary>
        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{ p.Id },{ p.PlaceNumber },{ p.PlaceName },{ p.PrizeAmount },{ p.PrizePercentage }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
