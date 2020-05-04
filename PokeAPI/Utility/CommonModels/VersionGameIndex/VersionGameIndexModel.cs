namespace PokeAPI
{
	/// <summary>
	/// ゲームインデックスモデル
	/// </summary>
	internal class VersionGameIndexModel
	{
		// プロパティ

		#region ゲームインデックス
		/// <summary>
		/// ゲームインデックス
		/// </summary>
		internal int GameIndex { get; set; } = 0;
		#endregion

		#region バージョン
		/// <summary>
		/// バージョン
		/// </summary>
		internal NamedAPIResourceViewModel Version { get; } = new NamedAPIResourceViewModel();
		#endregion
	}
}
