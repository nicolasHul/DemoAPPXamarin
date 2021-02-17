using System;
using System.Collections.Generic;
using System.Windows.Input;
using TestDemoAPP.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TestDemoAPP.ViewModels
{
    public class DemoTestViewModel : ObservableObject
    {
        private List<ActivityLocation> activityData;
        private int _position;

        public DemoTestViewModel()
        {
            LoadData();
        }

        public List<ActivityLocation> ActivityData
        {
            get { return activityData; }
            set { SetProperty(ref activityData, value); }
        }

        public ICommand TestCommand => new Command(() =>
        {
            var x = "some debug text";
        });

        public int Position
        {
            get { return _position; }
            set { SetProperty(ref _position, value); }
        }

        private async void LoadData()
        {
            // SEEDING TEST DATA (2 differtent locations, 5 floors each)

            // Initialize Floors
            var activityFloors_location1 = new List<ActivityFloor>
            {
                new ActivityFloor { FloorId = 1, FloorName = "(Location 1) Floor 1" },
                new ActivityFloor { FloorId = 2, FloorName = "(Location 1) Floor 2" },
                new ActivityFloor { FloorId = 3, FloorName = "(Location 1) Floor 3" },
                new ActivityFloor { FloorId = 4, FloorName = "(Location 1) Floor 4" },
                new ActivityFloor { FloorId = 5, FloorName = "(Location 1) Floor 5" }
            };

            var activityFloors_location2 = new List<ActivityFloor>
            {
                new ActivityFloor { FloorId = 1, FloorName = "(Location 2) Floor 1" },
                new ActivityFloor { FloorId = 2, FloorName = "(Location 2) Floor 2" },
                new ActivityFloor { FloorId = 3, FloorName = "(Location 2) Floor 3" },
                new ActivityFloor { FloorId = 4, FloorName = "(Location 2) Floor 4" },
                new ActivityFloor { FloorId = 5, FloorName = "(Location 2) Floor 5" }
            };

            // Initialize Locations / merge data
            var activityLocations = new List<ActivityLocation>
            {
                new ActivityLocation {
                    LocationId = 1,
                    LocationName = "Location 1",
                    CurrentFloors = activityFloors_location1
                },
                new ActivityLocation
                {
                    LocationId = 2,
                    LocationName = "Location 2",
                    CurrentFloors = activityFloors_location2
                }
            };

            // Set ListSource for ContentPage's CarouselView
            try
            {
                ActivityData = activityLocations;
            }
            catch (Exception ex)
            {

                throw;
            }
            

        }


    }
}