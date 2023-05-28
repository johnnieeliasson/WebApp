using WebApp.Contexts;

namespace WebApp.Helpers.Repositories
{
    public class ProductTagRepository : Repo<ProductTagRepository>
    {
        public ProductTagRepository(DataContext context) : base(context)
        {
        }
    }
}
