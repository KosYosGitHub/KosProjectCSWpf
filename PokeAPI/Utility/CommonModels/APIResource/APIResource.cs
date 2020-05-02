using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	///  APIリソースjビューモデル
	/// </summary>
	public class APIResource : KosViewModel
	{
		// internal プロパティ

		#region APIリソースモデル
		/// <summary>
		/// APIリソースモデル
		/// </summary>
		internal APIResourceModel Model { get; set; } = new APIResourceModel();
		#endregion

		// public プロパティ

		#region URL
		/// <summary>
		/// URL
		/// </summary>
		public string URL
		{
			get => Model.URL;
			set {
				Model.URL = value;
				RaisePropertyChanged();
			}
		}
		#endregion
	}
}
