using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Weather
{

    /// <summary>
    /// DTO which hold the property information related to the searched city.
    /// </summary>
    public class WeatherSearchDto
    {
        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        public string City { get; set; }
    }
}
