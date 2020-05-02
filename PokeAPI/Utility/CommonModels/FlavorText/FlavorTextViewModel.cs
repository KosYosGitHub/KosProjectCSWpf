using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	/// フレーバーテキストビューモデル
	/// </summary>
	public class FlavorTextViewModel : KosViewModel
	{
		// internal プロパティ

		#region フレーバーテキストモデル
		/// <summary>
		/// フレーバーテキストモデル
		/// </summary>
		internal FlavorTextModel Model { get; } = new FlavorTextModel();
		#endregion

		// public プロパティ

		#region フレーバーテキスト
		/// <summary>
		/// フレーバーテキスト
		/// </summary>
		public string FlavorText
		{
			get => Model.FlavorText;
			set {
				Model.FlavorText = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 言語
		/// <summary>
		/// 言語
		/// </summary>
		public NamedAPIResourceViewModel Language => Model.Language;
		#endregion

		#region バージョン
		/// <summary>
		/// バージョン
		/// </summary>
		public NamedAPIResourceViewModel Version => Model.Version;
		#endregion
	}
}
