using Application.Services.Repositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tobeto.Core.Persistence.Repositories;

namespace Application.Features.Categories.Commands.Create
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreatedCategoryResponse>
    {
        ICategoryRepository _repository;
        public CreateCategoryCommandHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }
        public async Task<CreatedCategoryResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            Category category = new Category();
            category.Name = request.Name;

            var createdCategory = await _repository.AddAsync(category);

            CreatedCategoryResponse createdCategoryResponse = new CreatedCategoryResponse();
            createdCategoryResponse.Id = createdCategory.Id;
            createdCategoryResponse.Name = createdCategory.Name;
            createdCategoryResponse.CreatedDate = createdCategory.CreatedDate;

            return createdCategoryResponse;
        }
    }
}
