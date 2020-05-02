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
		internal NamedAPIResource Language { get; } = new NamedAPIResource();
		#endregion

		#region バージョン
		/// <summary>
		/// バージョン
		/// </summary>
		internal NamedAPIResource Version { get; } = new NamedAPIResource();
		#endregion
	}
}
