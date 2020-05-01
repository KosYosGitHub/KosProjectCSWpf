using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
	public class BerryFirmnessList : NamedAPIResourceList
	{
		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public BerryFirmnessList() : base("berry-firmness")
		{
		}
		#endregion
	}
}
