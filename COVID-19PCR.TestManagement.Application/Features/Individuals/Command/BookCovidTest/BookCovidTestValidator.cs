using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using COVID_19PCR.TestManagement.Application.Features.Administrators.Command.AllocateBookingSpace;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Individuals.Command.BookCovidTest
{
    public class BookCovidTestValidator : AbstractValidator<BookCovidTestCommand>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly IIndividualRepository _individualRepository; 
        private readonly IAdminBookingAllocationRepository _adminBookingAllocationRepository;

        public BookCovidTestValidator(ILocationRepository locationRepository, IIndividualRepository individualRepository,
            IAdminBookingAllocationRepository adminBookingAllocationRepository)
        {
            _locationRepository = locationRepository;
            _individualRepository = individualRepository;
            _adminBookingAllocationRepository = adminBookingAllocationRepository;

            RuleFor(p => p.LocationID)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .GreaterThan(0);

            RuleFor(p => p.IndividualEmailAddress)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .EmailAddress();

            RuleFor(p => p.IndividualFirstName)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(150);

            RuleFor(p => p.IndividualLastName)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(150);

            RuleFor(p => p.IndividualMobileNumber)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(30);

            RuleFor(p => p.BookingDate)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .GreaterThan(DateTimeOffset.Now.AddDays(-1));

            RuleFor(e => e)
            .MustAsync(DoesLocationExist)
            .WithMessage("Location ID does not exist.");

            RuleFor(e => e)
            .MustAsync(DoesAllocatedBookingExist)
            .WithMessage("Location ID does not exist.");

            RuleFor(e => e)
            .MustAsync(DoesIndividualExist)
            .WithMessage("Individual already booked Covid Test.");

            RuleFor(e => e)
            .MustAsync(IsValidTestType)
            .WithMessage("Test Type must be either PCRTest or RapidTest.");

        }

        private async Task<bool> DoesLocationExist(BookCovidTestCommand e, CancellationToken token)
        {
            return await _locationRepository.DoesLocationExist(e.LocationID);
        }

        private async Task<bool> DoesIndividualExist(BookCovidTestCommand e, CancellationToken token)
        {
            return !(await _individualRepository.DoesIndividualExist(e.IndividualEmailAddress, e.IndividualMobileNumber));
        }

        private Task<bool> IsValidTestType(BookCovidTestCommand e, CancellationToken token)
        {
            var isValid = TestTypeData.TestType.Contains(e.IndividualLab.TestType.ToLower());
            return Task.FromResult(isValid);

        }

        private async Task<bool> DoesAllocatedBookingExist(BookCovidTestCommand e, CancellationToken token)
        {
            return await _adminBookingAllocationRepository.DoesBookingExist(e.LocationID, e.BookingDate);
        }
    }
}
