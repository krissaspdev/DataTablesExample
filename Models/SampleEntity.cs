using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTablesExample.Models
{
    public class SampleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public int Extn { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }

        public SampleEntity()
        {
        }

        public SampleEntity(int id, string name)
        {
            Id = id;
            Name = name;
        }

        private static IEnumerable<SampleEntity> SampleData;

        public static IEnumerable<SampleEntity> GetSampleData()
        {
            if (SampleEntity.SampleData == null)
            {
                var _data = new List<SampleEntity>
                {
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Tiger Nixon",
                        Position = "System Architect",
                        Office = "Edinburgh",
                        Extn = 5421,
                        StartDate = DateTime.Parse("2011/04/25"),
                        Salary = 320800m
                    },
                    new SampleEntity
                    {
                        Id = 2,
                        Name = "Garrett Winters",
                        Position = "Accountant",
                        Office = "Tokyo",
                        Extn = 8422,
                        StartDate = DateTime.Parse("2011/07/25"),
                        Salary = 170750m
                    },
                    new SampleEntity
                    {
                        Id = 3,
                        Name = "Ashton Cox",
                        Position = "Junior Technical Author",
                        Office = "San Francisco",
                        Extn = 1562,
                        StartDate = DateTime.Parse("2009/01/12"),
                        Salary = 86000m
                    },
                    new SampleEntity
                    {
                        Id = 4,
                        Name = "Cedric Kelly",
                        Position = "Senior Javascript Developer",
                        Office = "Edinburgh",
                        Extn = 6224,
                        StartDate = DateTime.Parse("2012/03/29"),
                        Salary = 43360m
                    },
                    new SampleEntity
                    {
                        Id = 5,
                        Name = "Airi Satou",
                        Position = "Accountant",
                        Office = "Tokyo",
                        Extn = 5407,
                        StartDate = DateTime.Parse("2008/11/28"),
                        Salary = 162700m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Brielle Williamson",
                        Position = "Integration Specialist",
                        Office = "New York",
                        Extn = 4804,
                        StartDate = DateTime.Parse("2012/12/02"),
                        Salary = 372000m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Herrod Chandler",
                        Position = "Sales Assistant",
                        Office = "San Francisco",
                        Extn = 9608,
                        StartDate = DateTime.Parse("2012/08/06"),
                        Salary = 137500m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Rhona Davidson",
                        Position = "Integration Specialist",
                        Office = "Tokyo",
                        Extn = 6200,
                        StartDate = DateTime.Parse("2010/10/14"),
                        Salary = 327900m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Colleen Hurst",
                        Position = "Javascript Developer",
                        Office = "San Francisco",
                        Extn = 236,
                        StartDate = DateTime.Parse("2009/09/15"),
                        Salary = 205500
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Sonya Frost",
                        Position = "Software Engineer",
                        Office = "Edinburgh",
                        Extn = 1667,
                        StartDate = DateTime.Parse("2008/12/13"),
                        Salary = 103600m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Jena Gaines",
                        Position = "Office Manager",
                        Office = "London",
                        Extn = 3814,
                        StartDate = DateTime.Parse("2008/12/19"),
                        Salary = 90560m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Quinn Flynn",
                        Position = "Support Lead",
                        Office = "Edinburgh",
                        Extn = 9497,
                        StartDate = DateTime.Parse("2013/03/03"),
                        Salary = 342000m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Charde Marshall",
                        Position = "Regional Director",
                        Office = "San Francisco",
                        Extn = 6741,
                        StartDate = DateTime.Parse("2008/10/16"),
                        Salary = 470600
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Haley Kennedy",
                        Position = "Senior Marketing Designer",
                        Office = "London",
                        Extn = 3597,
                        StartDate = DateTime.Parse("2012/12/18"),
                        Salary = 313500m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Tatyana Fitzpatrick",
                        Position = "Regional Director",
                        Office = "London",
                        Extn = 1965,
                        StartDate = DateTime.Parse("2010/03/17"),
                        Salary = 385750m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Michael Silva",
                        Position = "Marketing Designer",
                        Office = "London",
                        Extn = 1581,
                        StartDate = DateTime.Parse("2012/11/27"),
                        Salary = 198500m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Paul Byrd",
                        Position = "Chief Financial Officer (CFO)",
                        Office = "New York",
                        Extn = 3059,
                        StartDate = DateTime.Parse("2010/06/09"),
                        Salary = 725000m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Gloria Little",
                        Position = "Systems Administrator",
                        Office = "New York",
                        Extn = 1721,
                        StartDate = DateTime.Parse("2009/04/10"),
                        Salary = 237500m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Bradley Greer",
                        Position = "Software Engineer",
                        Office = "London",
                        Extn = 2558,
                        StartDate = DateTime.Parse("2012/10/13"),
                        Salary = 132000m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Dai Rios",
                        Position = "Personnel Lead",
                        Office = "Edinburgh",
                        Extn = 2290,
                        StartDate = DateTime.Parse("2012/09/26"),
                        Salary = 217500m,
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Jenette Caldwell",
                        Position = "Development Lead",
                        Office = "New York",
                        Extn = 1937,
                        StartDate = DateTime.Parse("2011/09/03"),
                        Salary = 345000m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Yuri Berry",
                        Position = "Chief Marketing Officer (CMO)",
                        Office = "New York",
                        Extn = 6154,
                        StartDate = DateTime.Parse("2009/06/25"),
                        Salary = 675000m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Caesar Vance",
                        Position = "Pre-Sales Support",
                        Office = "New York",
                        Extn = 8330,
                        StartDate = DateTime.Parse("2011/12/12"),
                        Salary = 106450m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Doris Wilder",
                        Position = "Sales Assistant",
                        Office = "Sydney",
                        Extn = 3023,
                        StartDate = DateTime.Parse("2010/09/20"),
                        Salary = 85600m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Angelica Ramos",
                        Position = "Chief Executive Officer (CEO)",
                        Office = "London",
                        Extn = 5797,
                        StartDate = DateTime.Parse("2009/10/09"),
                        Salary = 1200000m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Gavin Joyce",
                        Position = "Developer",
                        Office = "Edinburgh",
                        Extn = 8822,
                        StartDate = DateTime.Parse("2010/12/22"),
                        Salary = 92575m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Jennifer Chang",
                        Position = "Regional Director",
                        Office = "Singapore",
                        Extn = 9239,
                        StartDate = DateTime.Parse("2010/11/14"),
                        Salary = 357650m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Brenden Wagner",
                        Position = "Software Engineer",
                        Office = "San Francisco",
                        Extn = 1314,
                        StartDate = DateTime.Parse("2011/06/07"),
                        Salary = 206850m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Fiona Green",
                        Position = "Chief Operating Officer (COO)",
                        Office = "San Francisco",
                        Extn = 2947,
                        StartDate = DateTime.Parse("2010/03/11"),
                        Salary = 850000m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Shou Itou",
                        Position = "Regional Marketing",
                        Office = "Tokyo",
                        Extn = 8899,
                        StartDate = DateTime.Parse("2011/08/14"),
                        Salary = 163000m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Michelle House",
                        Position = "Integration Specialist",
                        Office = "Sydney",
                        Extn = 2769,
                        StartDate = DateTime.Parse("2011/06/02"),
                        Salary = 95400m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Suki Burks",
                        Position = "Developer",
                        Office = "London",
                        Extn = 6832,
                        StartDate = DateTime.Parse("2009/10/22"),
                        Salary = 114500m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Prescott Bartlett",
                        Position = "Technical Author",
                        Office = "London",
                        Extn = 3606,
                        StartDate = DateTime.Parse("2011/05/07"),
                        Salary = 145000m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Gavin Cortez",
                        Position = "Team Leader",
                        Office = "San Francisco",
                        Extn = 2860,
                        StartDate = DateTime.Parse("2008/10/26"),
                        Salary = 235500m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Martena Mccray",
                        Position = "Post-Sales support",
                        Office = "Edinburgh",
                        Extn = 8240,
                        StartDate = DateTime.Parse("2011/03/09"),
                        Salary = 324050m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Unity Butler",
                        Position = "Marketing Designer",
                        Office = "San Francisco",
                        Extn = 5384,
                        StartDate = DateTime.Parse("2009/12/09"),
                        Salary = 85675m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Howard Hatfield",
                        Position = "Office Manager",
                        Office = "San Francisco",
                        Extn = 7031,
                        StartDate = DateTime.Parse("2008/12/16"),
                        Salary = 164500m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Hope Fuentes",
                        Position = "Secretary",
                        Office = "San Francisco",
                        Extn = 6318,
                        StartDate = DateTime.Parse("2010/02/12"),
                        Salary = 109850m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Vivian Harrell",
                        Position = "Financial Controller",
                        Office = "San Francisco",
                        Extn = 9422,
                        StartDate = DateTime.Parse("2009/02/14"),
                        Salary = 452500m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Timothy Mooney",
                        Position = "Office Manager",
                        Office = "London",
                        Extn = 7580,
                        StartDate = DateTime.Parse("2008/12/11"),
                        Salary = 136200m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Jackson Bradshaw",
                        Position = "Director",
                        Office = "New York",
                        Extn = 1042,
                        StartDate = DateTime.Parse("2008/09/26"),
                        Salary = 645750m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Olivia Liang",
                        Position = "Support Engineer",
                        Office = "Singapore",
                        Extn = 2120,
                        StartDate = DateTime.Parse("2011/02/03"),
                        Salary = 234500m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Bruno Nash",
                        Position = "Software Engineer",
                        Office = "London",
                        Extn = 6222,
                        StartDate = DateTime.Parse("2011/05/03"),
                        Salary = 16350m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Sakura Yamamoto",
                        Position = "Support Engineer",
                        Office = "Tokyo",
                        Extn = 383,
                        StartDate = DateTime.Parse("2009/08/19"),
                        Salary = 139575m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Thor Walton",
                        Position = "Developer",
                        Office = "New York",
                        Extn = 8327,
                        StartDate = DateTime.Parse("2013/08/11"),
                        Salary = 98540m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Finn Camacho",
                        Position = "Support Engineer",
                        Office = "San Francisco",
                        Extn = 2927,
                        StartDate = DateTime.Parse("2009/07/07"),
                        Salary = 87500m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Serge Baldwin",
                        Position = "Data Coordinator",
                        Office = "Singapore",
                        Extn = 8352,
                        StartDate = DateTime.Parse("2012/04/09"),
                        Salary = 138575m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Zenaida Frank",
                        Position = "Software Engineer",
                        Office = "New York",
                        Extn = 7439,
                        StartDate = DateTime.Parse("2010/01/04"),
                        Salary = 125250m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Zorita Serrano",
                        Position = "Software Engineer",
                        Office = "San Francisco",
                        Extn = 4389,
                        StartDate = DateTime.Parse("2012/06/01"),
                        Salary = 115000m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Jennifer Acosta",
                        Position = "Junior Javascript Developer",
                        Office = "Edinburgh",
                        Extn = 3431,
                        StartDate = DateTime.Parse("2013/02/01"),
                        Salary = 75650m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Cara Stevens",
                        Position = "Sales Assistant",
                        Office = "New York",
                        Extn = 3990,
                        StartDate = DateTime.Parse("2011/12/06"),
                        Salary = 145600m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Hermione Butler",
                        Position = "Regional Director",
                        Office = "London",
                        Extn = 1016,
                        StartDate = DateTime.Parse("2011/03/21"),
                        Salary = 356250m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Lael Greer",
                        Position = "Systems Administrator",
                        Office = "London",
                        Extn = 6733,
                        StartDate = DateTime.Parse("2009/02/27"),
                        Salary = 10300m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Jonas Alexander",
                        Position = "Developer",
                        Office = "San Francisco",
                        Extn = 8196,
                        StartDate = DateTime.Parse("2010/07/14"),
                        Salary = 86500m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Shad Decker",
                        Position = "Regional Director",
                        Office = "Edinburgh",
                        Extn = 6373,
                        StartDate = DateTime.Parse("2008/11/13"),
                        Salary = 183000m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Michael Bruce",
                        Position = "Javascript Developer",
                        Office = "Singapore",
                        Extn = 5384,
                        StartDate = DateTime.Parse("2011/06/27"),
                        Salary = 183000m
                    },
                    new SampleEntity
                    {
                        Id = 1,
                        Name = "Donna Snider",
                        Position = "Customer Support",
                        Office = "New York",
                        Extn = 4226,
                        StartDate = DateTime.Parse("2011/01/25"),
                        Salary = 112000m
                    }
                };


                SampleEntity.SampleData = _data;
            }

            return SampleEntity.SampleData;
        }
    }
}