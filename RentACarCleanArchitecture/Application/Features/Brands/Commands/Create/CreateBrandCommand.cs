using System;
using MediatR;

namespace Application.Features.Brands.Commands.Create
{
    //IRequest : Marka oluşturma talebi. MediatR ile geldi. Swagger'dan bir emir geldi diye anlıyor ve CreatedBrandResponse yanıtını dön.
    //CreatedBrandResponse : oluşturulan marka yanıtı
    public class CreateBrandCommand : IRequest<CreatedBrandResponse>
    {
        //Bana markanın adını ver demek
        //Marka oluşturma talebinde isim istiyoruz.Kullanıcıdan ne istiyorsan onu yazıyoruz
        public string Name { get; set; }
    }
}


