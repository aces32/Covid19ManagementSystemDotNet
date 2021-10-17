using COVID_19PCR.TestManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Contracts.Persistence
{
    public interface IAdminBookingAllocationRepository : IAsyncRepository<AdminBookingAllocation>
    {
        Task<AdminBookingAllocation> GetAdminBookingAllocationByLocationIdandBookingDate(int locationID, DateTimeOffset bookingDate);
        Task<List<AdminBookingAllocation>> GetAllRecentAvailableBookings();
        Task<List<AdminBookingAllocation>> GetAdminBookingAllocationHistorybyBookingDates(DateTimeOffset StartDate, DateTimeOffset EndDate, int page, int size);
        Task<bool> DoesBookingExist(int LocationId, DateTimeOffset bookingdate);
    }
}
