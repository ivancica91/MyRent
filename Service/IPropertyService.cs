
namespace My_Rent.Service
{
    using My_Rent.Service.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPropertyService
    {
        Task<List<string>> GetCategoriesAsync(string? propertyCategory);

        Task<PropertyDto> GetSingleByIdAsync(int id);

        Task<List<PropertyDto>> GetListAsync(string name, string category);

        Task<PropertyDto> CreateAsync(CreatePropertyDto dto);

        Task<PropertyDto> UpdateAsync(UpdatePropertyDto dto);

        Task<int> DeleteAsync(int id);
    }
}
