using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using My_Rent.Data;
using My_Rent.Models;
using My_Rent.Views.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList;
using My_Rent.Service;
using My_Rent.Service.Models;

namespace My_Rent.Controllers
{
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
            var properties = await this._propertyService.GetListAsync(propertyCategory, searchString);
            var x = this._mapper.Map<List<PropertyDto>, PropertyCategoryViewModel>(properties);
            return this.View(x);


            //// Use LINQ to get list of categories.
            //IQueryable<string> categoryQuery = from p in _context.Property
            //                                   orderby p.Category
            //                                   select p.Category;


            //var properties = from p in _context.Property
            //                 select p;


            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    properties = properties.Where(s => s.PropertyName.Contains(searchString));
            //}

            //if (!string.IsNullOrEmpty(propertyCategory))
            //{
            //    properties = properties.Where(x => x.Category == propertyCategory);
            //}

            //var propertyCategoryVM = new PropertyCategoryViewModel
            //{
            //    Categories = new SelectList(await categoryQuery.Distinct().ToListAsync()),
            //    Properties = await properties.ToListAsync()
            //};


            //return View(propertyCategoryVM);
        }


        // GET: Properties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var x = await this._propertyService.GetSingleByIdAsync(id.Value);
            return this.View(this._mapper.Map<PropertyDto, PropertyViewModel>(x));

          /*  if (id == null)
            {
                return NotFound();
            }

            var property = await _context.Property.FindAsync(id);

            if (property == null)
            {
                return NotFound();
            }

            var viewModel = this._mapper.Map<Property, PropertyViewModel>(property);

            return this.View(viewModel);  */
        }

        // GET: Properties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Properties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            CreatePropertyViewModel model)
        {
    
            
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }

           var dto = this._mapper.Map<CreatePropertyViewModel, CreatePropertyDto>(model);

            var response = await this._propertyService.CreateAsync(dto);

            return this.RedirectToAction(nameof(Index));
            
            //
            //Property property = this._mapper.Map<CreatePropertyViewModel, Property>(model);
            //this._context.Add(property);
            //await this._context.SaveChangesAsync();
            //return this.RedirectToAction(nameof(Index));
        }

        // GET: Properties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {



            var property = await this._propertyService.GetSingleByIdAsync(id.Value);
           var x = this._mapper.Map<UpdatePropertyDto>(property);
            var view = this._mapper.Map<UpdatePropertyDto, UpdatePropertyViewModel>(x);
            return View(view);



            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var property = await _context.Property.FindAsync(id);

            //if (property == null)
            //{
            //    return NotFound();
            //}

            //var view = this._mapper.Map<Property, UpdatePropertyViewModel>(property);

            //return View(view);
        }

        // POST: Properties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
            int id,
            UpdatePropertyViewModel model)
        {
           var property = this._mapper.Map<PropertyDto>(model);           
            var x = this._mapper.Map<UpdatePropertyDto>(property);
            var update = await this._propertyService.UpdateAsync(x);
            var view = this._mapper.Map<PropertyDto, UpdatePropertyViewModel>(update);
            return this.RedirectToAction(nameof(Index));



            //var property = await this._context.Property.FindAsync(model.Id);

            //if (property == null)
            //{
            //    return this.NotFound();
            //}

            //this._mapper.Map<UpdatePropertyViewModel, Property>(model, property);

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(property);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        return this.BadRequest();
            //    }

            //    return this.RedirectToAction(nameof(Index));
            //}
            //return this.View(@property);
        }

        // GET: Properties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var dto = await this._propertyService.GetSingleByIdAsync(id.Value);
            var view = this._mapper.Map<PropertyDto, PropertyViewModel>(dto);
            return this.View(view);


            //if (id == null)
            //{
            //    return this.NotFound();
            //}

            //var property = await this._context.Property.FindAsync(id);
            //if (property == null)
            //{
            //    return this.NotFound();
            //}

            //var viewModel = this._mapper.Map<Property, PropertyViewModel>(property);

            //return this.View(viewModel);
        }

        // POST: Properties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this._propertyService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

            //var property = await this._context.Property.FindAsync(id);
            //this._context.Property.Remove(property);
            //await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
        }

        private bool PropertyExists(int id)
        {
            return _context.Property.Any(e => e.Id == id);
        }
    }
}
