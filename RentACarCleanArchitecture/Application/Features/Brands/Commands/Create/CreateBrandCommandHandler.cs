using System;
using Application.Services.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commands.Create
{
    //public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse> -->
    //handler ettiğinde CreatedBrandResponse ver
    //UpdateBrandCommand --> UpdateBrandCommandHandler

    //Bu sınıf, IRequestHandler arabirimini uygular ve iki generic parametre alır.
    //İlk parametre CreateBrandCommand, işlenecek komut türünü temsil eder.
    //İkinci parametre CreatedBrandResponse, işlemin sonucunu temsil eden bir türdür.


    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        IBrandRepository _brandRepository;

        public CreateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            //request ile gelen nesneleri gerçek brand'e atadık.
            Brand brand = new Brand();
            brand.Name = request.Name;
            brand.Id = Guid.NewGuid(); //id verdi

            var createdBrand = await _brandRepository.AddAsync(brand); 

            //brand değerlerimi response ettik
            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Id = createdBrand.Id;
            createdBrandResponse.Name = createdBrand.Name;
            createdBrandResponse.CreatedDate = createdBrand.CreatedDate;

            return createdBrandResponse;
        }
    }
}
