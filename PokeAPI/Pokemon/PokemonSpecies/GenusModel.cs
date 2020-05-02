namespace PokeAPI
{
	/// <summary>
	/// 属性モデル
	/// </summary>
	internal class GenusModel
	{
		// プロパティ

		#region 属性
		/// <summary>
		/// 属性
		/// </summary>
		internal string Genus { get; set; } = string.Empty;
		#endregion

		#region 言語情報
		/// <summary>
		/// 言語情報
		/// </summary>
		internal NamedAPIResourceViewModel Language { get; } = new NamedAPIResourceViewModel();
		#endregion

		#region 取得済フラグ
		/// <summary>
		/// 取得済フラグ
		/// </summary>
		internal bool IsGeted { get; set; } = false;
		#endregion
	}
}
