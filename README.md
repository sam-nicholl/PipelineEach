# PipelineEach
PipelineEach - Extension method for IEnumerable&lt;T>, inspired by python example from https://codewords.recurse.com/issues/one/an-introduction-to-functional-programming 

Applies functions to a list of objects.

```
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
```
