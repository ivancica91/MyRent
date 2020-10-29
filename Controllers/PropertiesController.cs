namespace My_Rent.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using My_Rent.Data;
    using My_Rent.Models;
    using My_Rent.Service;
    using My_Rent.Service.Models;
    using My_Rent.Views.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class PropertiesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly MvcPropertyContext _context;
        private readonly IPropertyService _propertyService;

        public PropertiesController(
            IPropertyService propertyService,
            MvcPropertyContext context,
            IMapper mapper)
        {
            this._propertyService = propertyService;
            this._mapper = mapper;
            this._context = context;
        }

        // GET: Properties
        public async Task<IActionResult> Index(string propertyCategory, string searchString)
        {
            var properties = await this._propertyService.GetListAsync(searchString, propertyCategory);

            var categories = await this._propertyService.GetCategoriesAsync(propertyCategory);

            var mappedProperties = this._mapper.Map<List<PropertyDto>, List<PropertyViewModel>>(properties);

            var vm = new IndexViewModel
            {
                Properties = mappedProperties,
                Categories = new SelectList(categories)
            };
            return this.View(vm);
        }

        // GET: Properties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var dto = await this._propertyService.GetSingleByIdAsync(id.Value);
            return this.View(this._mapper.Map<PropertyDto, PropertyViewModel>(dto));
        }

        // GET: Properties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Properties/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            CreatePropertyViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }

            CreatePropertyDto dto = this._mapper.Map<CreatePropertyViewModel, CreatePropertyDto>(model);

            await this._propertyService.CreateAsync(dto);

            return this.RedirectToAction(nameof(Index));
        }

        // GET: Properties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var property = await this._propertyService.GetSingleByIdAsync(id.Value);
            var view = this._mapper.Map<PropertyDto, UpdatePropertyViewModel>(property);
            return View(view);
        }

        // POST: Properties/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
            int id,
            UpdatePropertyViewModel model)
        {
            var property = this._mapper.Map<UpdatePropertyDto>(model);
            var update = await this._propertyService.UpdateAsync(property);
            var view = this._mapper.Map<PropertyDto, UpdatePropertyViewModel>(update);
            return this.RedirectToAction(nameof(Index));
        }

        // GET: Properties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var dto = await this._propertyService.GetSingleByIdAsync(id.Value);
            var view = this._mapper.Map<PropertyDto, PropertyViewModel>(dto);
            return this.View(view);
        }

        // POST: Properties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this._propertyService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
