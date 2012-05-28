using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Rhino.Mocks;
using UnitTesting.src.dataProject;

namespace UnitTesting.test
{
    class TestMockedImplementation
    {
        [Test]
        public static void TestSubCreation()
        {
            IProduct product = MockRepository.GenerateStub<IProduct>();
            product.id = 34;
            product.name = "4Gb Pen Drive";
            product.price = 450;

            Assert.AreEqual(34, product.id);
            Assert.AreEqual("4Gb Pen Drive", product.name);
            Assert.AreEqual(450, product.price);
        }
        /// <summary>
        /// This method demonstrates the actual mock object creation usage
        /// </summary>
        [Test]
        public static void UseMocks()
        {
            IEnumerable<IProduct> fakes = new List<IProduct>
            {
                new Product(1,"SuiteCase",300),
                new Product(2,"Cake",250),
                new Product(3,"Tyre",1000)
            };
            
            // We now will create the mock repository as before
            MockRepository mocks = new MockRepository();
            
            //Here, we will inject our mock into the IProductRepository
            IProductRepository repository = mocks.Stub<IProductRepository>();
            
            //Finally, we create fake behaviour for the injected mock
            using (mocks.Record())
            {
                SetupResult.For(repository.Select()).Return(fakes);
                SetupResult.For(repository.GetProduct(1)).Return(new Product(1, "Sample Product", 150));
            }
            //Now perform different operations as before
            var results = repository.Select();
            Assert.AreEqual(3, results.Count());
            Assert.AreEqual(1, repository.GetProduct(1).id);
            Assert.AreEqual("Sample Product", repository.GetProduct(1).name);
            Assert.AreEqual(150, repository.GetProduct(1).price);
            Assert.Null(repository.GetProduct(500));
        }
    }
}
