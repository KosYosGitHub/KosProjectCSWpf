namespace PokeAPI
{
	/// <summary>
	/// ポケモンリスト
	/// </summary>
	public class PokemonList : NamedAPIResourceList
	{
		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokemonList() : base("pokemon")
		{
		}
		#endregion
	}
}
