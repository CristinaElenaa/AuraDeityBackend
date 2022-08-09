using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class WeatherData:BaseModel
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public double Temperature { get; set; }
        public DateTime QueryDateTime { get; set; }
        public int UserAuthsId { get; set; }
        public virtual UserAuthEntity UserAuths { get; set; }
    }
}
