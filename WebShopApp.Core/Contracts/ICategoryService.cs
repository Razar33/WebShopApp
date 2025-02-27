﻿using WebShopApp.Infrastructure.Data.Entities;

namespace WebShopApp.Core.Contracts
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category GetBrandById(int categoryId);
        List<Product> GetProductByCategory(int categoryId);
    }
}
