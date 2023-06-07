using FluentValidation;
using TaskWebAPI.Entities.Dtos.Brands;
using TaskWebAPI.Entities.Dtos.Colors;

namespace TaskWebAPI.Validators.Color
{
    public class CreateColorDtoValidators : AbstractValidator<CreateColorDto>
    {
        public CreateColorDtoValidators()
        {

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Name field must not be empty!")
                .NotNull().WithMessage("Name field must not be null!")
                .MaximumLength(100)
                .MinimumLength(3)
                .Must(MustBeStartWithA).WithMessage("Color name must be start 'A'");
        }

        public bool MustBeStartWithA(string name)
        {
            return name.StartsWith('A');

        }
    }
}
