using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KosMVVM;

namespace PokeAPI
{
	public class Name : KosViewModel
	{
		// メンバ変数

		#region 名称モデル
		/// <summary>
		/// 名称モデル
		/// </summary>
		private NameModel model = new NameModel();
		#endregion

		// public プロパティ

		#region 名称
		/// <summary>
		/// 名称
		/// </summary>
		public string NameText
		{
			get => model.Name;
			set {
				model.Name = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 言語名称
		/// <summary>
		/// 言語名称
		/// </summary>
		public string LanguageName
		{
			get => model.LanguageName;
			set {
				model.Name = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 言語URL
		/// <summary>
		/// 言語URL
		/// </summary>
		public string LanguageURL
		{
			get => model.LanguageURL;
			set {
				model.LanguageURL = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		// internal プロパティ

		#region 言語情報
		/// <summary>
		/// 言語情報
		/// </summary>
		internal NamedAPIResourceModel Language => model.Language;
		#endregion
	}
}
