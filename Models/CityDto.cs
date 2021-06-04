using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First.Api.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NoOfPointsOfIntrest
        {
            get
            { return PointsOfIntrest.Count; }

        }

        public ICollection<PointOfIntrestDto> PointsOfIntrest { get; set; } =
            new List<PointOfIntrestDto>();
    }
}
