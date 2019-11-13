using Test.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Test.Entities.Concrete
{
	/// <summary>
	/// Generated by ElementalBuilder (12.11.2019 16:39:22)
	/// </summary>
	public class Emlak:IEntity
	{
		#region Properties 
        [Key]
		public Int32 EmlakId_PK { get; set; }
		public String EmlakTur { get; set; }
		public Int32 Metrekare { get; set; }
		public Int32 OdaSayisi { get; set; }
		public Int32 Kat { get; set; }
		public Int32 BinaKati { get; set; }
		public String IsinmaTur { get; set; }
		#endregion 

	}
}
	// C:\Users\manas\source\repos\Test\Test.Entities\Concrete 
