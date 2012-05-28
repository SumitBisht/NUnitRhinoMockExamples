using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTesting.src.dataProject
{
    public interface IProductRepository
    {
        IProduct GetProduct(int ProductIdNumber);
        
        IEnumerable<IProduct>Select();

        void RemoveProduct(int ProductIdNumber);
    }
}
