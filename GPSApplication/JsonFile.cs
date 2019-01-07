using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Sheets
    {
        [JsonProperty("positions")]
        public List<Row> Sheet { get; set; }
    }

    public class Row
    {
        [JsonProperty("altitude")]
        public float altitude { get; set; }

        [JsonProperty("longitude")]
        public float longitude { get; set; }

        [JsonProperty("latitude")]
        public float latitude { get; set; }
    }

}
