using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            //Product'ın unitPrice'ı CategoryId'si 1 iken 10'dan büyük eşit olmalı.
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            //Burada kendi kuralımızı yazdık ve sonrasında hata mesajını belirttik.
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün adı A harfi ile başlamalıdır!");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
