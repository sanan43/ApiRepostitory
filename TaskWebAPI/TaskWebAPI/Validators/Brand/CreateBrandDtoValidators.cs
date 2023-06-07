using FluentValidation;
using TaskWebAPI.Entities.Dtos.Brands;

namespace TaskWebAPI.Validators.Brand
{
    public class CreateBrandDtoValidators: AbstractValidator<CreateBrandDto>
    {
        public CreateBrandDtoValidators()
        {

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Name field must not be empty!")
                .NotNull().WithMessage("Name field must not be null!")
                .MaximumLength(100)
                .MinimumLength(3)
                .Must(MustBeStartWithA).WithMessage("Brand name must be start 'A'");
        }

        public bool MustBeStartWithA(string name)
        {
            return name.StartsWith('A');
            
        }
    }
}
