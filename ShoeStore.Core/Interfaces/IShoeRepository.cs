using System;
using System.Collections.Generic;
using System.Text;
using ShoeStore.Core.Domain;

namespace ShoeStore.Core.Interfaces
{
    public interface IShoeRepository
    {
        IList<Shoe> GetShoes(int group, int category = 0, int brand = 0, decimal size = 0, int width = 0);
    }
}
