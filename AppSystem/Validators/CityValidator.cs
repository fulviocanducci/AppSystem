using AppSystem.Data;
using AppSystem.Models;
using FluentValidation;
using System.Linq;

namespace AppSystem.Validators
{
    public class CityValidator: AbstractValidator<City>
    {
        public CityValidator(Database database)
        {
            Database = database;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Digte o nome da cidade")
                .MaximumLength(100).WithMessage("Nome da cidade no máximo 100 caracteres");


            RuleFor(p => p.UfId)
                .GreaterThan(0).WithMessage("Unidade federativa inválida")
                .NotNull().WithMessage("Unidade federativa nula")               
                .Must(BeValidUf).WithMessage("Unidade federativa não existe");
        }

        public Database Database { get; }

        private bool BeValidUf(int ufId)
        {
            return Database
                .Uf
                .AsNoTracking()
                .Any(c => c.Id == ufId);
        }
    }
}
