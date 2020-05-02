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
		// internal プロパティ

		#region 名前付きAPIリソース
		/// <summary>
		/// 名前付きAPIリソース
		/// </summary>
		internal NamedAPIResourceModel Model { get; } = new NamedAPIResourceModel();
		#endregion

		// public プロパティ

		#region 名称
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get => Model?.Name;
			set {
				Model.Name = value;
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
			get => Model?.URL;
			set {
				Model.URL = value;
				RaisePropertyChanged();
			}
		}
		#endregion
	}
}
