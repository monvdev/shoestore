using System;
using System.Collections.Generic;
using System.Text;
using ShoeStore.Core.Domain;
using ShoeStore.Core.Interfaces;

namespace ShoeStore.Core.Data
{
    public class ShoeRepository : Repository<Shoe>, IShoeRepository
    {
        public ShoeRepository(ShoeStoreContext context) : base(context)
        {
        }

        public IList<Shoe> GetShoes(int group, int category = 0, int brand = 0, decimal size = 0, int width = 0)
        {
            throw new NotImplementedException();
        }

    }
}
