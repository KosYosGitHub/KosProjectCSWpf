using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
	/// <summary>
	/// ポケモン図鑑リスト
	/// </summary>
	public class PokedexList : NamedAPIResourceList
	{
		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokedexList() : base("pokedex")
		{
		}
		#endregion
	}
}
