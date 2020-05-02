namespace PokeAPI
{
	/// <summary>
	/// ポケモン種族バリエーションモデル
	/// </summary>
	internal class PokemonSpeciesVarietyModel
	{
		// プロパティ

		#region デフォルト
		/// <summary>
		/// デフォルト
		/// </summary>
		internal bool IsDefault { get; set; } = false;
		#endregion

		#region ポケモン
		/// <summary>
		/// ポケモン
		/// </summary>
		internal NamedAPIResourceViewModel Pokemon { get; } = new NamedAPIResourceViewModel();
		#endregion
	}
}
