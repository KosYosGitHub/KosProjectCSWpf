using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	/// 説明ビューモデル
	/// </summary>
	public class Description : KosViewModel
	{
		// internal プロパティ

		#region 説明モデル
		/// <summary>
		/// 説明モデル
		/// </summary>
		internal DescriptionModel Model { get; } = new DescriptionModel();
		#endregion

		// public プロパティ

		#region 説明
		/// <summary>
		/// 説明
		/// </summary>
		public string Text
		{
			get => Model.Description;
			set {
				Model.Description = value;
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
	}
}
