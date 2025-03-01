using Project.BusinessLayer.Abstract;
using Project.DataAccessLayer.Abstract;
using Project.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Concrete
{
	public class SubscriberManager : ISubscriberService
	{
		private readonly ISubscriberDal _subscriberDal;

		public SubscriberManager(ISubscriberDal subscriberDal)
		{
			_subscriberDal = subscriberDal;
		}

		public void TDelete(Subscriber entity)
		{
			_subscriberDal.Delete(entity);
		}

		public List<Subscriber> TGetAll()
		{
			return _subscriberDal.GetAll();
		}

		public Subscriber TGetById(int id)
		{
			return _subscriberDal.GetById(id);
		}

		public void TInsert(Subscriber entity)
		{
			_subscriberDal.Insert(entity);
		}

		public void TUpdate(Subscriber entity)
		{
			_subscriberDal.Update(entity);
		}
	}
}
