using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	/// ポケモン種族図鑑登録情報ビューモデル
	/// </summary>
	public class PokemonSpeciesDexEntryViewModel : KosViewModel
	{
		// private プロパティ

		#region ポケモン種族図鑑登録情報モデル
		/// <summary>
		/// ポケモン種族図鑑登録情報モデル
		/// </summary>
		private PokemonSpeciesDexEntryModel Model { get; } = new PokemonSpeciesDexEntryModel();
		#endregion

		// public プロパティ

		#region 登録番号
		/// <summary>
		/// 登録番号
		/// </summary>
		public int EntryNumber
		{
			get => Model.EntryNumber;
			set {
				Model.EntryNumber = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region ポケモン図鑑
		/// <summary>
		/// ポケモン図鑑
		/// </summary>
		public NamedAPIResourceViewModel Pokedex => Model.Pokedex;
		#endregion
	}
}
