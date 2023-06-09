using System;
using Inciso1.Context;
using Inciso1.Models;

namespace Inciso1.Services
{
	public class ColegioService: IColegioService
    {
		private readonly IAppDbContext _appDbContext;

		public ColegioService(IAppDbContext ContextDB)
		{
			_appDbContext = ContextDB;
		}

		public void AddColegio(COLEGIO colegio){
			_appDbContext.COLEGIO.Add(colegio);
			_appDbContext.SaveChanges();
		}
	}
}

