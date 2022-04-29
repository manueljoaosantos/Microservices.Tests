using System.Security.Claims;
using System.Threading.Tasks;
using API.Dtos;
using API.Errors;
using API.Extensions;
using AutoMapper;
using Core.Entities.AdventureWorks;
using Core.Entities.Identity;
using Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AdventureWorksController : BaseApiController
    {
        private readonly IGenericRepository<Product> _genericProductsRepo;
        private readonly IMapper _mapper;
        private readonly IProductRepository _productsRepo;
        public AdventureWorksController(IGenericRepository<Product> genericProductsRepo, IProductRepository productsRepo, IMapper mapper)
        {
            _productsRepo = productsRepo;
            _mapper = mapper;
            _genericProductsRepo = genericProductsRepo;
        }

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return _genericProductsRepo.ListAll();
        }
/*
        [HttpGet]
        public IEnumerable<Product> Details(int? id)
        {
            return _productsRepo.Details();
        }*/
    }
}
