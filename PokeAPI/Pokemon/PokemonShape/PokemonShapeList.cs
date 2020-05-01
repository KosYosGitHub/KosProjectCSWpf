namespace PokeAPI
{
	/// <summary>
	/// ポケモンの形リスト
	/// </summary>
	public class PokemonShapeList : NamedAPIResourceList
	{
		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokemonShapeList() : base("pokemon-shape")
		{
		}
		#endregion
	}
}
