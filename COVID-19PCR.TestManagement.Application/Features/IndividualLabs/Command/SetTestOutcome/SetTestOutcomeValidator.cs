using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Features.IndividualLabs.Command.SetTestOutcome
{
    public class SetTestOutcomeValidator : AbstractValidator<SetTestOutcomeCommand>
    {
        public SetTestOutcomeValidator()
        {
            RuleFor(p => p.IndividualLabId)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .GreaterThan(0);

            RuleFor(p => p.TestCompleted)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull();

            RuleFor(p => p.TestOutCome)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull();

            RuleFor(e => e)
            .MustAsync(IsValidTestOutcomeType)
            .WithMessage("Test Outcome must be either negative or positive.");
        }

        private Task<bool> IsValidTestOutcomeType(SetTestOutcomeCommand e, CancellationToken token)
        {
            var isValid = TestOutcomeData.TestOutcomeType.Contains(e.TestOutCome.ToLower());
            return Task.FromResult(isValid);

        }
    }
}
