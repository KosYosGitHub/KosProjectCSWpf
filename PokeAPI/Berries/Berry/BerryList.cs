using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
	/// <summary>
	/// ベリーリスト
	/// </summary>
	public class BerryList : NamedAPIResourceList
	{
		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public BerryList() : base("berry")
		{
		}
		#endregion
	}
}
