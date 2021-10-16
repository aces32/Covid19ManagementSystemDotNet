using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Persistence.Repository
{
    public class AdminBookingAllocationRepository : BaseRepository<AdminBookingAllocation> , IAdminBookingAllocationRepository
    {
        public AdminBookingAllocationRepository(COVID19PCRDbContext dbContext) : base(dbContext)
        {

        }

        public Task<AdminBookingAllocation> GetAdminBookingAllocationByLocationIdandBookingDate(int locationID, DateTimeOffset bookingDate)
        {
            var adminBookingAllocation = _dbContext.AdminBookingAllocations.Where(x => x.LocationID == locationID && 
                                            x.BookingDates.Date == bookingDate.Date).FirstOrDefault();
            return Task.FromResult(adminBookingAllocation);
        }

        public async Task<List<AdminBookingAllocation>> GetAllRecentAvailableBookings()
        {
            var admingBookings = await _dbContext.AdminBookingAllocations.Include(t => t.Location).Where(x => x.BookingDates > DateTime.Now.AddDays(-1) &&
                                            x.Capacity > x.SpaceAllocated).ToListAsync();
            return admingBookings;
        }

        public async Task<List<AdminBookingAllocation>> GetAdminBookingAllocationHistorybyBookingDates(DateTimeOffset StartDate, DateTimeOffset EndDate, int page, int size)
        {
            return await _dbContext.AdminBookingAllocations
                                        .Include(l => l.Location)
                                        .Include(i => i.Individuals).ThenInclude(x => x.IndividualLab)
                                        .Where(s => (s.BookingDates >= StartDate && s.BookingDates <= EndDate))
                                        .Skip((page - 1) * size).Take(size).AsNoTracking().OrderBy(x => x.BookingDates).ToListAsync();
        }
    }
}
