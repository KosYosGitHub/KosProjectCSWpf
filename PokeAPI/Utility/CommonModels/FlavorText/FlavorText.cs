using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	/// フレーバーテキストビューモデル
	/// </summary>
	public class FlavorText : KosViewModel
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
		public string Text
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
		public NamedAPIResource Language => Model.Language;
		#endregion

		#region バージョン
		/// <summary>
		/// バージョン
		/// </summary>
		public NamedAPIResource Version => Model.Version;
		#endregion
	}
}
