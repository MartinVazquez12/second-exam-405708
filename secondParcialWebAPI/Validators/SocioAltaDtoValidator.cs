using FluentValidation;
using secondParcialWebAPI.DTOS;

namespace secondParcialWebAPI.Validators
{
    public class SocioAltaDtoValidator : AbstractValidator<SocioAltaDto>
    {
        public SocioAltaDtoValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                 .WithMessage("El formato de id debe ser guid");
            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .EmailAddress();
            RuleFor(x => x.Nombre)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2).WithMessage("Largo minimo 2")
                .MaximumLength(30).WithMessage("Largo maximo 30");
            RuleFor(x => x.Apellido)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2).WithMessage("Largo minimo 2")
                .MaximumLength(30).WithMessage("Largo maximo 30");
            RuleFor(x => x.Dni)
                .NotEmpty()
                .NotNull()
                .MinimumLength(7).WithMessage("Largo minimo 7")
                .MaximumLength(10).WithMessage("Largo maximo 10");
            RuleFor(x => x.Telefono)
               .NotEmpty()
               .NotNull()
               .MinimumLength(8).WithMessage("Largo minimo 8")
               .MaximumLength(12).WithMessage("Largo maximo 12");
            RuleFor(x => x.Calle)
               .NotEmpty()
                .NotNull()
                .MinimumLength(2).WithMessage("Largo minimo 2")
                .MaximumLength(30).WithMessage("Largo maximo 30");
            RuleFor(x => x.Numero)
               .NotEmpty()
                .NotNull()
                .MinimumLength(2).WithMessage("Largo minimo 2")
                .MaximumLength(10).WithMessage("Largo maximo 10");
            RuleFor(x => x.CodPost)
               .NotEmpty()
                .NotNull()
                .MinimumLength(2).WithMessage("Largo minimo 2")
                .MaximumLength(6).WithMessage("Largo maximo 6");
            RuleFor(x => x.Provincia)
               .NotEmpty()
                .NotNull()
                .MinimumLength(2).WithMessage("Largo minimo 2")
                .MaximumLength(30).WithMessage("Largo maximo 30");
            RuleFor(x => x.Ciudad)
               .NotEmpty()
                .NotNull()
                .MinimumLength(2).WithMessage("Largo minimo 2")
                .MaximumLength(30).WithMessage("Largo maximo 30");
            RuleFor(x => x.FechaAlta)
               .NotEmpty()
                .NotNull();
        }
    }
}
