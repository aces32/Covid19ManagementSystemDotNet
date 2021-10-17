using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Administrators.Command.AllocateBookingSpace
{
    public class AllocateBookingSpaceValidator : AbstractValidator<AllocateBookingSpaceCommand>
    {
        public readonly ILocationRepository _locationRepository;
        private readonly IAdminBookingAllocationRepository _adminBookingAllocationRepository;

        public AllocateBookingSpaceValidator(ILocationRepository locationRepository, IAdminBookingAllocationRepository adminBookingAllocationRepository)
        {
            _locationRepository = locationRepository;
            _adminBookingAllocationRepository = adminBookingAllocationRepository;

            RuleFor(p => p.Capacity)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .GreaterThan(0);

            RuleFor(p => p.LocationID)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .GreaterThan(0);

            RuleFor(p => p.BookingDates)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .GreaterThan(DateTimeOffset.Now.AddDays(-1));

            RuleFor(e => e)
            .MustAsync(DoesLocationExist)
            .WithMessage("Location ID does not exist.");

            RuleFor(e => e)
            .MustAsync(DoesAllocatedBookingExist)
            .WithMessage("Booking has been allocated for the specifed location at the specified date.");

        }

        private async Task<bool> DoesLocationExist(AllocateBookingSpaceCommand e, CancellationToken token)
        {
            return await _locationRepository.DoesLocationExist(e.LocationID);
        }

        private async Task<bool> DoesAllocatedBookingExist(AllocateBookingSpaceCommand e, CancellationToken token)
        {
            return !(await _adminBookingAllocationRepository.DoesBookingExist(e.LocationID, e.BookingDates));
        }
    }
}
