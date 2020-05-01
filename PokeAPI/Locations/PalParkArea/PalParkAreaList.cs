using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
	/// <summary>
	/// パルパークエリアリスト
	/// </summary>
	public class PalParkAreaList : NamedAPIResourceList
	{
		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PalParkAreaList() : base("pal-park-area")
		{
		}
		#endregion
	}
}
