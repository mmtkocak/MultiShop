using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.FeatureSliderDtos;
using MultiShop.WebUI.Services.CatalogServices.FeatureSliderServices;

namespace MultiShop.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeatureSliderController : Controller
    {
        private readonly IFeatureSliderService _featureSliderService;

        public FeatureSliderController(IFeatureSliderService featureSliderService)
        {
            _featureSliderService = featureSliderService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _featureSliderService.GetAllFeatureSliderAsync();
            return View(values);

        }
        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureSliderDto createFeatureDto)
        {
            await _featureSliderService.CreateFeatureSliderAsync(createFeatureDto);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> DeleteFeature(string id)
        {
            await _featureSliderService.DeleteFeatureSliderAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFeature(string id)
        {
            var values = await _featureSliderService.GetByIdFeatureSliderAsync(id);
            return View(values);
        }


        [HttpPost]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureSliderDto updateFeatureDto)
        {
            await _featureSliderService.UpdateFeatureSliderAsync(updateFeatureDto);
            return RedirectToAction("Index");
        }

    }
}
