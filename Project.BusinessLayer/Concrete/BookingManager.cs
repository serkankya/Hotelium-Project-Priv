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
	public class BookingManager : IBookingService
	{
		private readonly IBookingDal _bookingDal;

		public BookingManager(IBookingDal bookingDal)
		{
			_bookingDal = bookingDal;
		}

		public void TDelete(Booking entity)
		{
			_bookingDal.Delete(entity);
		}

		public List<Booking> TGetAll()
		{
			return _bookingDal.GetAll();
		}

		public Booking TGetById(int id)
		{
			return _bookingDal.GetById(id);
		}

		public void TInsert(Booking entity)
		{
			_bookingDal.Insert(entity);
		}

		public void TUpdate(Booking entity)
		{
			_bookingDal.Update(entity);
		}
	}
}
