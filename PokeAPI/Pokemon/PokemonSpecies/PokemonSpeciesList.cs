namespace PokeAPI
{
	/// <summary>
	/// ポケモン種族リスト
	/// </summary>
	public class PokemonSpeciesList : NamedAPIResourceList
	{
		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokemonSpeciesList() : base("pokemon-species")
		{
		}
		#endregion
	}
}
