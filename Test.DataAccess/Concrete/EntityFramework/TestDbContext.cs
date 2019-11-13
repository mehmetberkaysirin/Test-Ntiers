using System;
using System.Collections.Generic;
using System.Text;
using Test.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Test.DataAccess.Concrete.EntityFramework 
{
	/// <summary>
	/// Generated by ElementalBuilder (12.11.2019 16:39:22)
	/// </summary>
	public class TestDbContext:DbContext 
	{
		 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
		{
			optionsBuilder.UseSqlServer("server = BERKAYSRN\\SQLEXPRESS ; Database = emlakDb; User Id=sa; Password=P5gplmnxms1.;" ); //bi bug var ��zemedim  o y�zden hard code yaz�lacak
		}

		public DbSet<Isyeri> Isyeri { get; set; }

		public DbSet<Musteri> Musteri { get; set; }

		public DbSet<Emlak> Emlak { get; set; }

		public DbSet<User> Users { get; set; }

	}
}
	// C:\Users\manas\source\repos\Test\Test.DataAccess\Concrete\EntityFramework
