using COVID_19PCR.TestManagement.Application.Contracts.Persistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.Individuals.Command.CancelBookedTest
{
    public class CancelBookedTestValidator : AbstractValidator<CancelBookedTestCommand>
    {
        private readonly IIndividualRepository _individualRepository;

        public CancelBookedTestValidator(IIndividualRepository individualRepository)
        {
            _individualRepository = individualRepository;

            RuleFor(p => p.IndividualEmailAddress)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .EmailAddress();

            RuleFor(p => p.IndividualMobileNumber)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(30);

            RuleFor(p => p.IndividualBookingStatus)
            .NotNull();

            RuleFor(e => e)
            .MustAsync(DoesIndividualExist)
            .WithMessage("Canceled or no booked Covid tests based on the specified email address and phone number.");
        }

        private async Task<bool> DoesIndividualExist(CancelBookedTestCommand e, CancellationToken token)
        {
            return await _individualRepository.DoesIndividualExist(e.IndividualEmailAddress, e.IndividualMobileNumber);
        }
    }
}
