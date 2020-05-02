namespace PokeAPI
{
	/// <summary>
	/// パルパークエンカウントエリアモデル
	/// </summary>
	internal class PalParkEncounterAreaModel
	{
		// プロパティ

		#region 基本スコア
		/// <summary>
		/// 基本スコア
		/// </summary>
		internal int BaseScore { get; set; } = 0;
		#endregion

		#region レート
		/// <summary>
		/// レート
		/// </summary>
		internal int Rate { get; set; } = 0;
		#endregion

		#region エリア
		/// <summary>
		/// エリア
		/// </summary>
		internal NamedAPIResourceViewModel Area { get; } = new NamedAPIResourceViewModel();
		#endregion
	}
}
