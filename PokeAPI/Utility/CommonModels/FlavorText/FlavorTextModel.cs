namespace PokeAPI
{
	/// <summary>
	/// フレーバーテキストモデル
	/// </summary>
	internal class FlavorTextModel
	{
		// プロパティ

		#region フレーバーテキスト
		/// <summary>
		/// フレーバーテキスト
		/// </summary>
		internal string FlavorText { get; set; } = string.Empty;
		#endregion

		#region 言語
		/// <summary>
		/// 言語
		/// </summary>
		internal NamedAPIResourceViewModel Language { get; } = new NamedAPIResourceViewModel();
		#endregion

		#region バージョン
		/// <summary>
		/// バージョン
		/// </summary>
		internal NamedAPIResourceViewModel Version { get; } = new NamedAPIResourceViewModel();
		#endregion
	}
}
