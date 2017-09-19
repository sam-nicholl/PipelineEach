# PipelineEach
PipelineEach - Extension method for IEnumerable&lt;T>, inspired by python example from https://codewords.recurse.com/issues/one/an-introduction-to-functional-programming 

Applies functions to a list of objects.

```
        static void Main(string[] args)
        {

            var bands = new List<Band>
            {
                new Band("sunset rubdown", "UK", false),
                new Band("women", "Germany", false),
                new Band("a silver mt. zion", "Spain", true),
            };

            IEnumerable<Band> modifiedBands = bands.PipelineEach(
                StripBandNamePunctuation,
                CapitaliseBandName,
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
    }
```
