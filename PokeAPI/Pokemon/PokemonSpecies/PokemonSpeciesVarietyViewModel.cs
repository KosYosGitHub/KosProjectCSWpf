using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	/// ポケモン種族バリエーションビューモデル
	/// </summary>
	public class PokemonSpeciesVarietyViewModel : KosViewModel
	{
		// internal プロパティ

		#region ポケモン種族バリエーションモデル
		/// <summary>
		/// ポケモン種族バリエーションモデル
		/// </summary>
		internal PokemonSpeciesVarietyModel Model { get; } = new PokemonSpeciesVarietyModel();
		#endregion

		// public プロパティ

		#region デフォルト
		/// <summary>
		/// デフォルト
		/// </summary>
		public bool IsDefault
		{
			get => Model.IsDefault;
			set {
				Model.IsDefault = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region ポケモン
		/// <summary>
		/// ポケモン
		/// </summary>
		public NamedAPIResourceViewModel Pokemon => Model.Pokemon;
		#endregion
	}
}
