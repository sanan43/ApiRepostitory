using FluentValidation;
using TaskWebAPI.Entities.Dtos.Cars;

namespace TaskWebAPI.Validators.Car
{
    public class CreateCarDtoValidators: AbstractValidator<CreateCarDto>
    {
        public CreateCarDtoValidators()
        {

            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("Description field must not be empty!")
                .NotNull().WithMessage("Description field must not be null!")
                .MaximumLength(100)
                .MinimumLength(3)
                .Must(MustBeStartWithA).WithMessage("Car Description must be start 'A'");
            RuleFor(p => p.DailyPrice).NotNull().GreaterThanOrEqualTo(100).LessThanOrEqualTo(10000);
        }

        public bool MustBeStartWithA(string Description)
        {
            return Description.StartsWith('A');

        }
    }
}
