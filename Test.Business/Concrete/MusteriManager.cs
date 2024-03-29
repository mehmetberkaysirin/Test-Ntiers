using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Test.Business.Abstract;
using Test.DataAccess.Abstract;
using Test.Entities.Concrete;

namespace Test.Business.Concrete
{
	/// <summary>
	/// Generated by ElementalBuilder (12.11.2019 16:39:22)
	/// </summary>
	public class MusteriManager : IMusteriService 
	{
		 private IMusteriDal _musteriDal; 
		 public MusteriManager(IMusteriDal musteriDal) 
		{
			_musteriDal = musteriDal;
		}

		public List<Musteri> GetAllMusteri() 
		{
			return _musteriDal.GetList();
		}

		public Musteri GetMusteriById(int Id) 
		{
			return _musteriDal.Get(x=>x.MusteriId_PK == Id); 
		}

		public int Add(Musteri entity) 
		{
			return _musteriDal.Add(entity); 
		}

		public int Update(Musteri entity) 
		{
			return _musteriDal.Update(entity); 
		}

		public int Delete(int Id) 
		{
			return _musteriDal.Delete(new Musteri{MusteriId_PK = Id}); 
		}

	}
}
	// C:\Users\manas\source\repos\Test\Test.Business\Concrete 
