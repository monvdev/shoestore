using System;
using System.Collections.Generic;
using System.Text;
using ShoeStore.Core.Domain;

namespace ShoeStore.Core.Interfaces
{
    interface IShoeService
    {
        IList<Shoe> GetAllShoes();
        Shoe GetShoeById(int shoeId);
        void InsertShoe(Shoe shoe);
        void UpdateShoe(Shoe shoe);
        void DeleteShoe(Shoe shoe);
        IList<Shoe> GetShoes(int group, int category = 0, int brand = 0, decimal size = 0, int width = 0);

    }
}
