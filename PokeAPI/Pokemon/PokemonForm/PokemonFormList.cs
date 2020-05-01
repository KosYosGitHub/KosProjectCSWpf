namespace PokeAPI
{
	/// <summary>
	/// ポケモンフォルムリスト
	/// </summary>
	public class PokemonFormList : NamedAPIResourceList
	{
		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokemonFormList() : base("pokemon-form")
		{
		}
		#endregion
	}
}
