namespace PokeAPI
{
	/// <summary>
	/// 説明モデル
	/// </summary>
	internal class DescriptionModel
	{
		// プロパティ

		#region 説明
		/// <summary>
		/// 説明
		/// </summary>
		internal string Description { get; set; } = string.Empty;
		#endregion

		#region 言語
		/// <summary>
		/// 言語
		/// </summary>
		internal NamedAPIResourceViewModel Language { get; } = new NamedAPIResourceViewModel();
		#endregion
	}
}
