namespace PokeAPI
{
	/// <summary>
	/// ポケモン特性モデル
	/// </summary>
	internal class PokemonAbilityModel
	{
		// プロパティ

		#region 隠し特性
		/// <summary>
		/// 隠し特性
		/// </summary>
		internal bool IsHidden { get; set; } = false;
		#endregion

		#region 特性スロット
		/// <summary>
		/// 特性スロット
		/// </summary>
		internal int Slot { get; set; } = 0;
		#endregion

		#region 特性
		/// <summary>
		/// 特性
		/// </summary>
		internal NamedAPIResourceViewModel Ability { get; } = new NamedAPIResourceViewModel();
		#endregion
	}
}
