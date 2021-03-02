using System;
using System.Collections.Generic;
using System.Text;
using ShoeStore.Core.Interfaces;
using ShoeStore.Core.Domain;

namespace ShoeStore.Core.Services
{
    public class ShoeService : IShoeService
    {
        public ShoeService(IRepository<Shoe> shoeBaseRepository, IShoeRepository shoeExtendedRepository) { }
        public void DeleteShoe(Shoe shoe)
        {
            throw new NotImplementedException();
        }

        public IList<Shoe> GetAllShoes()
        {
            throw new NotImplementedException();
        }

        public Shoe GetShoeById(int shoeId)
        {
            throw new NotImplementedException();
        }

        public IList<Shoe> GetShoes(int group, int category = 0, int brand = 0, decimal size = 0, int width = 0)
        {
            throw new NotImplementedException();
        }

        public void InsertShoe(Shoe shoe)
        {
            throw new NotImplementedException();
        }

        public void UpdateShoe(Shoe shoe)
        {
            throw new NotImplementedException();
        }
    }
}
