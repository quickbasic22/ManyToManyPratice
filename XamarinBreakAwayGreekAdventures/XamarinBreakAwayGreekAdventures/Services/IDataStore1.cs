using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinBreakAwayGreekAdventures.Models;

namespace XamarinBreakAwayGreekAdventures.Services
{
    public interface IDataStore1
    {
        Task<bool> AddActivityAsync(Activity item);
        Task<bool> AddActivityTripAsync(ActivityTrip item);
        Task<bool> AddDestinationAsync(Destination item);
        Task<bool> AddLodgingAsync(Lodging item);
        Task<bool> AddPersonAsync(Person item);
        Task<bool> AddPersonPhotoAsync(PersonPhoto item);
        Task<bool> AddTripAsync(Trip item);
        Task<bool> DeleteActivityAsync(int id);
        Task<bool> DeleteActivityTripAsync(Guid guid, int id);
        Task<bool> DeleteDestinationAsync(int id);
        Task<bool> DeleteLodgingAsync(int id);
        Task<bool> DeletePersonAsync(int id);
        Task<bool> DeletePersonPhotoAsync(int id);
        Task<bool> DeleteTripAsync(Guid id);
        Task<Activity> GetActivityAsync(int id);
        Task<ActivityTrip> GetActivityTripAsync(string ActivityOrTrip, Guid guid, int id = 0);
        Task<IEnumerable<ActivityTrip>> GetActivityTripsAsync(bool forceRefresh = false);
        Task<Destination> GetDestinationAsync(int id);
        Task<IEnumerable<Destination>> GetDestinationsAsync(bool forceRefresh = false);
        Task<IEnumerable<Activity>> GetActivitiesAsync(bool forceRefresh = false);
        Task<IEnumerable<Lodging>> GetLodgingsAsync(bool forceRefresh = false);
        Task<Lodging> GetLodgingsAsync(int id);
        Task<IEnumerable<Person>> GetPeopleAsync(bool forceRefresh = false);
        Task<Person> GetPersonAsync(int id);
        Task<IEnumerable<PersonPhoto>> GetPersonPhotosAsync(bool forceRefresh = false);
        Task<PersonPhoto> GetPersonPhotosAsync(int id);
        Task<Trip> GetTripAsync(Guid id);
        Task<IEnumerable<Trip>> GetTripsAsync(bool forceRefresh = false);
        Task<bool> UpdateActivityAsync(Activity item);
        Task<bool> UpdateActivityTripAsync(string ActivityTrip, ActivityTrip item);
        Task<bool> UpdateDestinationAsync(Destination item);
        Task<bool> UpdateLodgingAsync(Lodging item);
        Task<bool> UpdatePersonAsync(Person item);
        Task<bool> UpdatePersonPhotoAsync(PersonPhoto item);
        Task<bool> UpdateTripAsync(Trip item);
    }
}