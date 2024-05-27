using FluentValidation;

namespace Valaki.Application.Features.KiteSpotFeatures.CreateKiteSpot
{
    public sealed class CreateKiteSpotValidator : AbstractValidator<CreateKiteSpotRequest>
    {
        public CreateKiteSpotValidator()
        {
            RuleFor(x => x).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
