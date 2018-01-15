using System;
using System.Collections.Generic;
using DevExpress.Mvvm;
using DevExpress.Xpf.Map;
using DXSample12.Model;

namespace DXSample12.ViewModels
{
    public class MapViewModel : ViewModelBase
    {
        public MapViewModel()
        {
            Locations = new List<MapLocation>
            {
                new MapLocation("Magdeburg Cracau", 52.1223, 11.6656, 15000),
                new MapLocation("Magdeburg Neustadt", 52.1512, 11.6451, 16000),
                new MapLocation("Magdeburg Sudenburg", 52.1132, 11.5948, 9000),
                new MapLocation("Magdeburg Westerhüsen", 52.0651, 11.6752, 12000),
                new MapLocation("Burg (bei Magdeburg)", 52.2710, 11.8544, 14000),
                new MapLocation("Berlin Mitte", 52.5303, 13.3829, 20000),
                new MapLocation("Berlin Kreuzberg", 52.4982, 13.3890, 11000),
                new MapLocation("Berlin Steglitz", 52.4559, 13.3341, 9000),
                new MapLocation("Berlin Friedrichshain", 52.5153, 13.4549, 10000),
                new MapLocation("Berlin Charlottenburg", 52.5169, 13.3012, 9000)
            };
            
            DataSourceAdapter = new BubbleChartDataAdapter()
            {
                Mappings = new MapBubbleMappingInfo()
                {
                    Latitude = nameof(MapLocation.Latitude),
                    Longitude = nameof(MapLocation.Longitude),
                    Value = nameof(MapLocation.Value)
                },
                AttributeMappings =
                {
                    new MapItemAttributeMapping(){ Member = nameof(MapLocation.Name), Name = nameof(MapLocation.Name) },
                    new MapItemAttributeMapping(){ Member = nameof(MapLocation.Value), Name = nameof(MapLocation.Value) }
                },
                Clusterer = new DistanceBasedClusterer(),
                DataSource = Locations,
                ItemMinSize = 25,
                ItemMaxSize = 75
            };
        }

        private List<MapLocation> Locations { get; set; }

        public DataSourceAdapterBase DataSourceAdapter { get; set; }
    }
}