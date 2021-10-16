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

        public AllocateBookingSpaceValidator(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;

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

        }

        private async Task<bool> DoesLocationExist(AllocateBookingSpaceCommand e, CancellationToken token)
        {
            return await _locationRepository.DoesLocationExist(e.LocationID);
        }
    }
}
