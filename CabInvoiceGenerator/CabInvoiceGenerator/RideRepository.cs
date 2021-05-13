using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        //Creating dictionary to store rides.
        Dictionary<string, List<Ride>> userRides = null;

        /// <summary>
        /// Creating constructor of RideRepository class.
        /// </summary>
        public RideRepository()
        {
            this.userRides = new Dictionary<string, List<Ride>>();
        }

        /// <summary>
        /// Addsing the rides with the help of userId.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="rides">The rides.</param>
        /// <exception cref="CabInvoiceException">Rides are null</exception>
        public void AddRides(string userId, Ride[] rides)
        {
            bool rideList = this.userRides.ContainsKey(userId);
            try
            {
                if (!rideList)
                {
                    List<Ride> list = new List<Ride>();
                    list.AddRange(rides);
                    this.userRides.Add(userId, list);
                }
            }
            catch
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDE, "Rides are null");
            }
        }

        /// <summary>
        /// Getting the rides with the help of UserId.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        /// <exception cref="CabInvoiceException">Invalid User Id</exception>
        public Ride[] GetRides(string userId)
        {
            try
            {
                return this.userRides[userId].ToArray();
            }
            catch
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "Invalid User Id");
            }
        }
    }
}
