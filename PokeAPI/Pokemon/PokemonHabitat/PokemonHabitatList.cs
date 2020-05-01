namespace PokeAPI
{
	/// <summary>
	/// ポケモン生息地リスト
	/// </summary>
	public class PokemonHabitatList : NamedAPIResourceList
	{
		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokemonHabitatList() : base("pokemon-habitat")
		{
		}
		#endregion
	}
}
