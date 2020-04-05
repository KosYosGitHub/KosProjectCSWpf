using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
	/// <summary>
	/// 名称モデル
	/// </summary>
	internal class NameModel
	{
		// メンバ変数

		#region 言語
		/// <summary>
		/// 言語
		/// </summary>
		private NamedAPIResourceModel language = new NamedAPIResourceModel();
		#endregion

		// プロパティ

		#region 名称
		/// <summary>
		/// 名称
		/// </summary>
		internal string Name { get; set; } = string.Empty;
		#endregion

		#region 言語名称
		/// <summary>
		/// 言語名称
		/// </summary>
		internal string LanguageName
		{
			get => language.Name;
			set => language.Name = value;
		}

		#endregion

		#region 言語URL
		/// <summary>
		/// 言語URL
		/// </summary>
		internal string LanguageURL
		{
			get => language.URL;
			set => language.URL = value;
		}
		#endregion

		#region 言語
		/// <summary>
		/// 言語
		/// </summary>
		internal NamedAPIResourceModel Language
		{
			get => language;
		}
		#endregion
	}
}
