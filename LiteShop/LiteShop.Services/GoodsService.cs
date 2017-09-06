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
    public class GoodsService: IGoodsService
    {
        private readonly IGoodsItemRepository mGoodsItemRepository;
        private readonly IUnitOfWork mUnitOfWork;

        public GoodsService(IUnitOfWork uof, IGoodsItemRepository repository)
        {
            this.mUnitOfWork = uof;
            this.mGoodsItemRepository = repository;
        }

        public void Add(GoodsItemEntity entity)
        {
            this.mGoodsItemRepository.Add(entity);
			this.mUnitOfWork.Commit();
        }

        public void Update(GoodsItemEntity entity)
        {
            this.mGoodsItemRepository.Update(entity);
			this.mUnitOfWork.Commit();
        }

        public void Delete(int id)
        {
            this.mGoodsItemRepository.Delete(id);
			this.mUnitOfWork.Commit();
        }

    }
}
