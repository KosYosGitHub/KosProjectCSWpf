using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	/// 名前付きAPIリソース
	/// </summary>
	public class NamedAPIResource : KosViewModel
	{
		// メンバ変数

		#region 名前付きAPIリソース
		/// <summary>
		/// 名前付きAPIリソース
		/// </summary>
		private NamedAPIResourceModel model = new NamedAPIResourceModel();
		#endregion

		// プロパティ

		#region 名称
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get => model?.Name;
			set {
				model.Name = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region URL
		/// <summary>
		/// URL
		/// </summary>
		public string URL
		{
			get => model?.URL;
			set {
				model.URL = value;
				RaisePropertyChanged();
			}
		}
		#endregion
	}
}
