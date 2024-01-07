using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.StatisticsRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public StatisticsController(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        

        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            var Count = _statisticsRepository.ActiveCategoryCount();
            return Ok(Count);
        }

        [HttpGet("ActiveEmployeeCount")]
        public IActionResult ActiveEmployeeCount()
        {
            var Count = _statisticsRepository.ActiveEmployeeCount();
            return Ok(Count);
        }
        [HttpGet("ApartmentCount")]
        public IActionResult ApartmentCount()
        {
            var deger = _statisticsRepository.ApartmentCount();
            return Ok(deger);
        }

        [HttpGet("AverageProductPriceByRent")]
        public IActionResult AverageProductPriceByRent()
        {
            var deger = _statisticsRepository.AverageProductPriceByRent();
            return Ok(deger);
        }

        [HttpGet("AverageProductPriceBySale")]
        public IActionResult AverageProductPriceBySale()
        {
            var deger = _statisticsRepository.AverageProductPriceBySale();
            return Ok(deger);
        }

        [HttpGet("AvereageRoomCount")]
        public IActionResult AvereageRoomCount()
        {
            var deger = _statisticsRepository.AvereageRoomCount();
            return Ok(deger);
        }

        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            var deger = _statisticsRepository.CategoryCount();
            return Ok(deger);
        }

        [HttpGet("CategoryNameByMaxProductCount")]
        public IActionResult CategoryNameByMaxProductCount()
        {
            var deger = _statisticsRepository.CategoryNameByMaxProductCount();
            return Ok(deger);
        }

        [HttpGet("CityNameByMaxProductCount")]
        public IActionResult CityNameByMaxProductCount()
        {
            var deger = _statisticsRepository.CityNameByMaxProductCount();
            return Ok(deger);
        }

        [HttpGet("DifferentCityCount")]
        public IActionResult DifferentCityCount()
        {
            var deger = _statisticsRepository.DifferentCityCount();
            return Ok(deger);
        }

        [HttpGet("EmployeeNameByMaxProductCount")]
        public IActionResult EmployeeNameByMaxProductCount()
        {
            var deger = _statisticsRepository.EmployeeNameByMaxProductCount();
            return Ok(deger);
        }

        [HttpGet("LastProductPrice")]
        public IActionResult LastProductPrice()
        {
            var deger = _statisticsRepository.LastProductPrice();
            return Ok(deger);
        }

        [HttpGet("NewestBuildingYear")]
        public IActionResult NewestBuildingYear()
        {
            var deger = _statisticsRepository.NewestBuildingYear();
            return Ok(deger);
        }

        [HttpGet("OldestBuildingYear")]
        public IActionResult OldestBuildingYear()
        {
            var deger = _statisticsRepository.OldestBuildingYear();
            return Ok(deger);
        }

        [HttpGet("PassiveCategoryCount")]
        public IActionResult PassiveCategoryCount()
        {
            var deger = _statisticsRepository.PassiveCategoryCount();
            return Ok(deger);
        }

        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            var deger = _statisticsRepository.ProductCount();
            return Ok(deger);
        }
    }
}
