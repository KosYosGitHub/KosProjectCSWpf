using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
	/// <summary>
	/// アイテムポケットリスト
	/// </summary>
	public class ItemPocketList : NamedAPIResourceList
	{
		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public ItemPocketList() : base("item-pocket")
		{
		}
		#endregion
	}
}
