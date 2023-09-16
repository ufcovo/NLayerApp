using FluentValidation;
using NLayer.Core.DTOs;

namespace NLayer.Service.Validations
{
    public class ProductDtoValidator : AbstractValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(r => r.Name).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertName} is required");
            RuleFor(r => r.Price).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater than 0");
            RuleFor(r => r.Stock).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater than 0");
            RuleFor(r => r.CategoryId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater than 0");
        }
    }
}
