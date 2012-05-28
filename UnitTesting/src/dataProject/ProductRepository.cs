using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTesting.src.dataProject
{
    class ProductRepository: IProductRepository
    {
        /// <summary>
        /// This class resembles any class that performs operations with the external layer,
        /// such as a database, file or a web service.
        /// 
        /// To stress upon the fact that we need to test in isolation,
        /// all the methods here will return exception - as it is undesirable for the user to access these
        /// </summary>
        public IProduct GetProduct(int ProductIdNumber)
        {
            throw new Exception();
        }

        public IEnumerable<IProduct> Select()
        {
            throw new Exception();
        }

        public void RemoveProduct(int ProductIdNumber)
        {
            throw new Exception();
        }
    }
}
