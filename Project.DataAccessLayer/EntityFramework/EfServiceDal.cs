﻿using Project.DataAccessLayer.Abstract;
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
	public class EfServiceDal : GenericRepository<Service>, IServiceDal
	{
		public EfServiceDal(Context context) : base(context)
		{

		}
	}
}
