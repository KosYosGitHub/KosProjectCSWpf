using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	/// パルパークエンカウントエリアビューモデル
	/// </summary>
	public class PalParkEncounterAreaViewModel : KosViewModel
	{
		// internal プロパティ

		#region パルパークエンカウントエリアモデル
		/// <summary>
		/// パルパークエンカウントエリアモデル
		/// </summary>
		internal PalParkEncounterAreaModel Model { get; } = new PalParkEncounterAreaModel();
		#endregion

		// public プロパティ

		#region 基本スコア
		/// <summary>
		/// 基本スコア
		/// </summary>
		public int BaseScore
		{
			get => Model.BaseScore;
			set {
				Model.BaseScore = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region レート
		/// <summary>
		/// レート
		/// </summary>
		public int Rate
		{
			get => Model.Rate;
			set {
				Model.Rate = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region エリア
		/// <summary>
		/// エリア
		/// </summary>
		public NamedAPIResourceViewModel Area => Model.Area;
		#endregion
	}
}
