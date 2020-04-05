using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
	/// <summary>
	/// 言語リスト
	/// </summary>
	public class LanguageList : NamedAPIResourceList
	{
		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public LanguageList() : base("language")
		{
		}
		#endregion
	}
}
