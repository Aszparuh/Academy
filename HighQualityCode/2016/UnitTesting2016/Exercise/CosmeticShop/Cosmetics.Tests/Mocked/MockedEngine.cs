﻿namespace Cosmetics.Tests.Mocked
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts;
    using Engine;

    internal class MockedEngine : CosmeticsEngine
    {
        public MockedEngine(
            ICosmeticsFactory factory,
            IShoppingCart shoppingCart,
            ICommandParser commandParser)
            : base(factory, shoppingCart, commandParser)
        {
        }

        public IDictionary<string, ICategory> Categories
        {
            get
            {
                return this.categories;
            }
        }

        public IDictionary<string, IProduct> Products
        {
            get
            {
                return this.products;
            }
        }
    }
}
