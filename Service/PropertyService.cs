using AutoMapper;
using Microsoft.EntityFrameworkCore;
using My_Rent.Data;
using My_Rent.Models;
using My_Rent.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace My_Rent.Service
{
    public class PropertyService : IPropertyService
    {

        
        private readonly IMapper mapper;
        private readonly MvcPropertyContext context;

        public PropertyService(MvcPropertyContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<PropertyDto> GetSingleByIdAsync(int id)
        {
            var property = await this.context.Property.FindAsync(id);

            return this.mapper.Map<PropertyDto>(property);  
        }

        public async Task<List<PropertyDto>> GetListAsync(string searchString, string propertyCategory)
        {





            var properties = await this.context.Property
                 .WhereIf(string.IsNullOrEmpty(searchString), s => s.PropertyName.Contains(searchString)) 
                 .WhereIf(string.IsNullOrEmpty(propertyCategory), s => s.Category.Equals(propertyCategory))
                 .ToListAsync();

            return this.mapper.Map<List<PropertyDto>>(properties);


        }

        public async Task<PropertyDto> CreateAsync(CreatePropertyDto dto)
        {
            if (dto == null)
            {
                throw new ApplicationException("Invalid arguments.");
            }

            var property = this.mapper.Map<Property>(dto);

            this.context.Property.Add(property);

            await this.context.SaveChangesAsync();

            return this.mapper.Map<PropertyDto>(property);
        }

        public async Task<PropertyDto> UpdateAsync(UpdatePropertyDto dto)
        {
            if (dto == null)
            {
                throw new ApplicationException("Invalid arguments.");
            }

            var property = await this.GetPropertyByIdSafeAsync(dto.Id);

            this.mapper.Map(dto, property);

            this.context.Property.Update(property);

            await this.context.SaveChangesAsync();

            return this.mapper.Map<PropertyDto>(property);
        }

        public async Task<int> DeleteAsync(int id)
        {
            var property = await this.GetPropertyByIdSafeAsync(id);

            this.context.Property.Remove(property);

            await this.context.SaveChangesAsync();

            return property.Id;
        }
        private async Task<Property> GetPropertyByIdSafeAsync(int id)   // zasto smo ovu uopce radili? osim da ju moemo gore koristit, al jel nismo mogli nes drugo?
        {
            var property = await this.context.Property.FindAsync(id);

            if (property == null)
            {
                throw new ApplicationException("Property not found.");
            }

            return property;
        }
    }
}
