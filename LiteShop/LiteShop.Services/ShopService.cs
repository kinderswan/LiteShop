using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteShop.DataServices.Infrastructure;
using LiteShop.DataServices.Repositories;
using LiteShop.Models;

namespace LiteShop.Services
{
    public class ShopService : IShopService
    {
        private readonly IShopRepository mShopRepository;
        private readonly IUnitOfWork mUnitOfWork;

        public ShopService(IUnitOfWork uof, IShopRepository repository)
        {
            this.mUnitOfWork = uof;
            this.mShopRepository = repository;
        }

        public void Add(ShopEntity entity)
        {
            this.mShopRepository.Add(entity);
			this.mUnitOfWork.Commit();
        }

        public void Update(ShopEntity entity)
        {
            this.mShopRepository.Update(entity);
			this.mUnitOfWork.Commit();
        }

        public void Delete(int id)
        {
            this.mShopRepository.Delete(id);
			this.mUnitOfWork.Commit();
        }

        public ShopEntity GetById(int id)
        {
            return this.mShopRepository.GetById(id);
        }

        public IList<ShopEntity> GetAll()
        {
            return this.mShopRepository.GetAll();
        }
    }
}
