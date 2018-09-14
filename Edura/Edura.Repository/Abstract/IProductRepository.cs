using Edura.Entity;
using System.Linq;

namespace Edura.WebUI.Repository.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
