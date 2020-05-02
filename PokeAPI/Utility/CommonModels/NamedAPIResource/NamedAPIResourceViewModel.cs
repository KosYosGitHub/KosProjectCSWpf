using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	/// 名前付きAPIリソースビューモデル
	/// </summary>
	public class NamedAPIResourceViewModel : KosViewModel
	{
		// internal プロパティ

		#region 名前付きAPIリソースモデル
		/// <summary>
		/// 名前付きAPIリソースモデル
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
