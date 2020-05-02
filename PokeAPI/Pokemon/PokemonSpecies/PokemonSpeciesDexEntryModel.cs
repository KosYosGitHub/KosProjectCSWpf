namespace PokeAPI
{
	/// <summary>
	/// ポケモン種族図鑑登録情報モデル
	/// </summary>
	internal class PokemonSpeciesDexEntryModel
	{
		// プロパティ

		#region 登録番号
		/// <summary>
		/// 登録番号
		/// </summary>
		internal int EntryNumber { get; set; } = 0;
		#endregion

		#region ポケモン図鑑
		/// <summary>
		/// ポケモン図鑑
		/// </summary>
		internal NamedAPIResource Pokedex { get; } = new NamedAPIResource();
		#endregion

		#region 取得済フラグ
		/// <summary>
		/// 取得済フラグ
		/// </summary>
		internal bool IsGeted { get; set; } = false;
		#endregion
	}
}
