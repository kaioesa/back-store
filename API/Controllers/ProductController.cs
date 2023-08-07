using System.Runtime.InteropServices;
using API.DTOs;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;
        private readonly IMapper _mapper;
        public ProductController(
            IProductService productService,
            ILogger<ProductController> logger,
            IMapper mapper
            )
        {
            _productService = productService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var result = await _productService.GetAllProducts();
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving the product.");
                return StatusCode(500, "An error occurred while retrieving the product.");
            }
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetProductByName(string name)
        {
            try
            {
                var result = _productService.GetProductByName(name);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving the product.");
                return StatusCode(500, "An error occurred while retrieving the product.");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(Guid id)
        {
            try
            {
                var result = _productService.GetProductById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving the product.");
                return StatusCode(500, "An error occurred while retrieving the product.");
            }
        }


        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] ProductDTO productDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var product = _mapper.Map<Product>(productDto);

                var createdProduct = await _productService.CreateProduct(product);

                var createdProductDto = _mapper.Map<ProductDTO>(createdProduct);

                return Ok(createdProductDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating the product.");
                return StatusCode(500, "An error occurred while creating the product.");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductDTO productDto, Guid id)
        {

            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var product = _mapper.Map<Product>(productDto);

                var updatedProduct = await _productService.UpdateProduct(product);

                var updatedProductDto = _mapper.Map<ProductDTO>(updatedProduct);

                return Ok(updatedProductDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating the product.");
                return StatusCode(500, "An error occurred while creating the product.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            try
            {
                await _productService.DeleteProduct(id);
                return Ok();
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while deleting the product.");
                return StatusCode(500, "An error occured while deleting the product.");
            }
        }
    }
}
