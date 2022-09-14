using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinBreakAwayGreekAdventures.Data;
using XamarinBreakAwayGreekAdventures.Models;

namespace XamarinBreakAwayGreekAdventures.Services
{
    public class DataStore : IDataStore1
    {
        BagaContext context = new BagaContext();

        // Activities
        public async Task<bool> AddActivityAsync(Activity item)
        {
            context.Activities.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateActivityAsync(Activity item)
        {
            var oldItem = context.Activities.Where((Activity arg) => arg.ActivityId == item.ActivityId).FirstOrDefault();
            context.Activities.Remove(oldItem);
            context.Activities.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteActivityAsync(int id)
        {
            var oldItem = context.Activities.Where((Activity arg) => arg.ActivityId == id).FirstOrDefault();
            context.Activities.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Activity> GetActivityAsync(int id)
        {
            return await Task.FromResult(context.Activities.FirstOrDefault(s => s.ActivityId == id));
        }

        public async Task<IEnumerable<Activity>> GetActivitiesAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(context.Activities);
        }

        // Destinations

        public async Task<bool> AddDestinationAsync(Destination item)
        {
            context.Destinations.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateDestinationAsync(Destination item)
        {
            var oldItem = context.Destinations.Where((Destination arg) => arg.DestinationId == item.DestinationId).FirstOrDefault();
            context.Destinations.Remove(oldItem);
            context.Destinations.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteDestinationAsync(int id)
        {
            var oldItem = context.Destinations.Where((Destination arg) => arg.DestinationId == id).FirstOrDefault();
            context.Destinations.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Destination> GetDestinationAsync(int id)
        {
            return await Task.FromResult(context.Destinations.FirstOrDefault(s => s.DestinationId == id));
        }

        public async Task<IEnumerable<Destination>> GetDestinationsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(context.Destinations);
        }

        // Lodgings
        public async Task<bool> AddLodgingAsync(Lodging item)
        {
            context.Lodgings.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateLodgingAsync(Lodging item)
        {
            var oldItem = context.Lodgings.Where((Lodging arg) => arg.lodgingId == item.lodgingId).FirstOrDefault();
            context.Lodgings.Remove(oldItem);
            context.Lodgings.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteLodgingAsync(int id)
        {
            var oldItem = context.Lodgings.Where((Lodging arg) => arg.lodgingId == id).FirstOrDefault();
            context.Lodgings.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Lodging> GetLodgingsAsync(int id)
        {
            return await Task.FromResult(context.Lodgings.FirstOrDefault(s => s.lodgingId == id));
        }

        public async Task<IEnumerable<Lodging>> GetLodgingsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(context.Lodgings);
        }

        // People

        public async Task<bool> AddPersonAsync(Person item)
        {
            context.People.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdatePersonAsync(Person item)
        {
            var oldPersonPhoto = context.People.Where((Person arg) => arg.PersonId == item.PersonId).FirstOrDefault();
            context.People.Remove(oldPersonPhoto);
            context.People.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeletePersonAsync(int id)
        {
            var oldPersonPhoto = context.People.Where((Person arg) => arg.PersonId == id).FirstOrDefault();
            context.People.Remove(oldPersonPhoto);

            return await Task.FromResult(true);
        }

        public async Task<Person> GetPersonAsync(int id)
        {
            return await Task.FromResult(context.People.FirstOrDefault(s => s.PersonId == id));
        }

        public async Task<IEnumerable<Person>> GetPeopleAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(context.People);
        }

        // PersonPhotos
        public async Task<bool> AddPersonPhotoAsync(PersonPhoto item)
        {
            context.PersonPhotos.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdatePersonPhotoAsync(PersonPhoto item)
        {
            var oldPerson = context.PersonPhotos.Where((PersonPhoto arg) => arg.Id == item.Id).FirstOrDefault();
            context.PersonPhotos.Remove(oldPerson);
            context.PersonPhotos.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeletePersonPhotoAsync(int id)
        {
            var oldPerson = context.PersonPhotos.Where((PersonPhoto arg) => arg.Id == id).FirstOrDefault();
            context.PersonPhotos.Remove(oldPerson);

            return await Task.FromResult(true);
        }

        public async Task<PersonPhoto> GetPersonPhotosAsync(int id)
        {
            return await Task.FromResult(context.PersonPhotos.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<PersonPhoto>> GetPersonPhotosAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(context.PersonPhotos);
        }

        // Trips

        public async Task<bool> AddTripAsync(Trip item)
        {
            context.Trips.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateTripAsync(Trip item)
        {
            var oldItem = context.Trips.Where((Trip arg) => arg.Identifier == item.Identifier).FirstOrDefault();
            context.Trips.Remove(oldItem);
            context.Trips.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteTripAsync(Guid id)
        {
            var oldItem = context.Trips.Where((Trip arg) => arg.Identifier == id).FirstOrDefault();
            context.Trips.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Trip> GetTripAsync(Guid id)
        {
            return await Task.FromResult(context.Trips.FirstOrDefault(s => s.Identifier == id));
        }

        public async Task<IEnumerable<Trip>> GetTripsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(context.Trips);
        }

        // ActivityTrips

        public async Task<bool> AddActivityTripAsync(ActivityTrip item)
        {
            context.ActivityTrip.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateActivityTripAsync(string ActivityTrip, ActivityTrip item)
        {
            if (ActivityTrip.ToLower() == "activity")
            {
                var oldItem = context.ActivityTrip.Where((ActivityTrip arg) => arg.ActivitiesActivityId == item.ActivitiesActivityId).FirstOrDefault();
                context.ActivityTrip.Remove(oldItem);
                context.ActivityTrip.Add(item);
                return await Task.FromResult(true);
            }
            else if (ActivityTrip.ToLower() == "trip")
            {
                var oldItem = context.ActivityTrip.Where((ActivityTrip arg) => arg.TripsIdentifier == item.TripsIdentifier).FirstOrDefault();
                context.ActivityTrip.Remove(oldItem);
                context.ActivityTrip.Add(item);
                return await Task.FromResult(true);
            }
            return await Task.FromResult(false);
        }

        public async Task<bool> DeleteActivityTripAsync(Guid guid, int id)
        {
            if (id != 0)
            {
                var oldItem = context.ActivityTrip.Where((ActivityTrip arg) => arg.ActivitiesActivityId == id).FirstOrDefault();
                context.ActivityTrip.Remove(oldItem);

                return await Task.FromResult(true);
            }
            else if (guid != null)
            {
                var oldItem = context.ActivityTrip.Where((ActivityTrip arg) => arg.TripsIdentifier == guid).FirstOrDefault();
                context.ActivityTrip.Remove(oldItem);

                return await Task.FromResult(true);
            }
            return await Task.FromResult(false);

        }

        public async Task<ActivityTrip> GetActivityTripAsync(string ActivityOrTrip, Guid guid, int id = 0)
        {
            if (ActivityOrTrip.ToLower() == "activity")
                return await Task.FromResult(context.ActivityTrip.FirstOrDefault(s => s.ActivitiesActivityId == id));
            else if (ActivityOrTrip.ToLower() == "trip")
                return await Task.FromResult(context.ActivityTrip.FirstOrDefault(s => s.TripsIdentifier == guid));
            else
                return await Task.FromResult(context.ActivityTrip.FirstOrDefault(s => s.ActivitiesActivityId == 1));
        }

        public async Task<IEnumerable<ActivityTrip>> GetActivityTripsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(context.ActivityTrip);
        }
    }
}