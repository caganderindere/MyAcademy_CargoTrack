using CargoTrack.DTO.DTOs.AboutDtos;
using FluentValidation;

namespace CargoTrack.Business.Validators.About
{
    public class CreateAboutValidator : AbstractValidator<CreateAboutDto>
    {
       public CreateAboutValidator()
        {
                        RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Bıorakılamaz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Bırakılamaz.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim URL'si Boş Bırakılamaz.");
        }
    }
    }
}
