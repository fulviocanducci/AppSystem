using AppSystem.Data;
using AppSystem.Models;
using FluentValidation;
using System.Linq;

namespace AppSystem.Validators
{
    public class UfValidator : AbstractValidator<Uf>
    {
        public UfValidator(Database database)
        {
            Database = database;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Uf tem 2 caracteres")
                .MinimumLength(2).WithMessage("Uf com 2 caracteres")                
                .Must(BeValidUfExist).WithMessage("Uf existente");
        }

        public Database Database { get; }

        private bool BeValidUfExist(string uf)
        {
            return !Database
                .Uf
                .AsNoTracking()
                .Any(c => c.Name == uf);
        }
    }
}
