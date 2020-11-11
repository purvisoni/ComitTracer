using System;
using System.Collections.Generic;
using System.Linq;

using ComitTracer.Storage;

namespace ComitTracer
{
    public class TracerSystem
    {
        public TracerSystem(IStoreUsers userStorage) {
            _userStorage = userStorage;
            _locationList = new List<Location>();
            _visitList = new List<Visit>();

            var user1 = new User() {
                Id = Guid.NewGuid(),
                FirstName = "Pablo",
                LastName = "Listingart",
                PhoneNumber = "306-123-4567"
            };
            Console.WriteLine($"User ID: {user1.Id}");
            var user2= new User() {
                Id = Guid.NewGuid(),
                FirstName = "Jesselyn",
                LastName = "Popoff",
                PhoneNumber = "306-999-9999"
            };

            _userStorage.Save(user1);
            _userStorage.Save(user2);

            var location1 = new Location() {
                Id = Guid.NewGuid(),
                Name = "YMCA"
            };
            Console.WriteLine($"Location ID: {location1.Id}");
            var location2 = new Location() {
                Id = Guid.NewGuid(),
                Name = "Grocery Store"
            };
            var location3 = new Location() {
                Id = Guid.NewGuid(),
                Name = "Restaurant"
            };

            _locationList.Add(location1);
            _locationList.Add(location2);
            _locationList.Add(location3);
        }

        // Storage
        private IStoreUsers _userStorage;


        private List<Location> _locationList;
        private List<Visit> _visitList;
        // Store users
        // Store locations
        // Store visits


        public void CheckForExposure() {
            Console.WriteLine("Checking for exposure...");
        }

        public void VisitedLocation(Guid userId, Guid locationId) {
            // Validation.?

            var user = _userStorage.GetById(userId);
            var location = _locationList.Find(x => x.Id == locationId);

            // Create the visit
            var newVisit = new Visit() {
                Id = Guid.NewGuid(),
                Location = location,
                User = user,
                DateOfVisit = DateTime.Now
            };

            // Add it to the list
            _visitList.Add(newVisit);
        }

        public void UserShowsSymptoms() {
            Console.WriteLine("User is marked as showing symptoms...");
        }



    }
}