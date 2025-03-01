using Project.DataAccessLayer.Abstract;
using Project.DataAccessLayer.Concrete;
using Project.DataAccessLayer.Repositories;
using Project.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.EntityFramework
{
	public class EfSubscriberDal : GenericRepository<Subscriber>, ISubscriberDal
	{
		public EfSubscriberDal(Context context) : base(context)
		{

		}
	}
}
