using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class SellProoductUseCase : ISellProoductUseCase
    {
        private readonly IProductRepository productRepository;

        public SellProoductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public void Execute(int productId, int qtyToSell)
        {
            var product = productRepository.GetProductById(productId);
            if (product == null) return;

            product.Quantity -= qtyToSell;
            productRepository.UpdateProduct(product);
        }
    }
}
