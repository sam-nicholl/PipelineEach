using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Idea from this python article https://codewords.recurse.com/issues/one/an-introduction-to-functional-programming
/// </summary>
namespace FunctionalPlay
{
    class Program
    {
        static void Main(string[] args)
        {

            var bands = new List<Band>
            {
                new Band("sunset rubdown", "UK", false),
                new Band("women", "Germany", false),
                new Band("a silver mt. zion", "Spain", true),
            };

            IEnumerable<Band> modifiedBands = bands.PipelineEach(
                //LogBandToConsole,
                StripBandNamePunctuation,
                //LogBandToConsole,
                CapitaliseBandName,
                //LogBandToConsole,
                t => ChangeBandCountry(t, "Canada")).ToList();

            Console.ReadLine();
        }

        private static Band ChangeBandCountry(Band band, string newCountry)
        {
            return new Band(band.Name, newCountry, band.Active);
        }

        private static Band StripBandNamePunctuation(Band band)
        {
            return new Band(band.Name.Replace(".", string.Empty), band.Country, band.Active);
        }

        private static Band CapitaliseBandName(Band band)
        {
            return new Band(band.Name.ToUpper(), band.Country, band.Active);
        }

        // Not at all functional, just logging what's going on at runtime
        private static Band LogBandToConsole(Band band)
        {
            Console.WriteLine(band.ToString());
            return new Band(band.Name, band.Country, band.Active);
        }
    }
}
