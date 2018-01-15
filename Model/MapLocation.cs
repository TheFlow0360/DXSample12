using System;

namespace DXSample12.Model
{
    public class MapLocation
    {
        public MapLocation(String name, Double latitude, Double longitude, Double value)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            Value = value;
        }

        public String Name { get; }

        public Double Latitude { get; }

        public Double Longitude { get; }

        public Double Value { get; }
    }
}