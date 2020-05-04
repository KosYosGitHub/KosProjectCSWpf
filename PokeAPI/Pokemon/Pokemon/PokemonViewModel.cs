using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using KosGeneric;
using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	/// ポケモンビューモデル
	/// </summary>
	public class PokemonViewModel : KosViewModel
	{
		// private プロパティ

		#region ポケモンモデル
		/// <summary>
		/// ポケモンモデル
		/// </summary>
		private PokemonModel Model { get; } = new PokemonModel();
		#endregion

		// public プロパティ

		#region ID
		/// <summary>
		/// ID
		/// </summary>
		public int ID
		{
			get => Model.ID;
			set {
				Model.ID = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 名称
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get => Model.Name;
			set {
				Model.Name = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 基本経験値
		/// <summary>
		/// 基本経験値
		/// </summary>
		public int BaseExperience
		{
			get => Model.BaseExperience;
			set {
				Model.BaseExperience = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 高さ
		/// <summary>
		/// 高さ
		/// </summary>
		public int Height
		{
			get => Model.Height;
			set {
				Model.Height = value;
				RaisePropertyChanged();
			}
		}
		#endregion

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

		#region 順番
		/// <summary>
		/// 順番
		/// </summary>
		public int Order
		{
			get => Model.Order;
			set {
				Model.Order = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 重さ
		/// <summary>
		/// 重さ
		/// </summary>
		public int Weight
		{
			get => Model.Weight;
			set {
				Model.Weight = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 特性リスト
		/// <summary>
		/// 特性リスト
		/// </summary>
		public ListCollectionView Abilities { get; }
		#endregion

		#region 関連するゲームインデックスリスト
		/// <summary>
		/// 関連するゲームインデックスリスト
		/// </summary>
		public ListCollectionView GameIndices { get; }
		#endregion

		#region スプライトURL
		/// <summary>
		/// スプライトURL
		/// </summary>
		public List<string> Sprites => Model.Sprites;
		#endregion

		// イベントハンドラ

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokemonViewModel()
		{
			Abilities = new ListCollectionView(Model.Abilities);
			GameIndices = new ListCollectionView(Model.GameIndices);
		}
		#endregion

		// public メソッド

		#region ポケモンの取得
		/// <summary>
		/// ポケモンの取得
		/// </summary>
		/// <param name="url">URL</param>
		public void GetPokemon(string url)
		{
			// 取得済
			if(Model.IsGeted) {
				return;
			}

			// JSON文字列の取得
			string json = Singleton<PokeAPIClient>.Instance.GetJson(url);

			// 解析
			Model.GetPokemonJson(json);
			Model.IsGeted = true;

			RaisePropertyChanged(nameof(ID));
			RaisePropertyChanged(nameof(Name));
			RaisePropertyChanged(nameof(BaseExperience));
			RaisePropertyChanged(nameof(Height));
			RaisePropertyChanged(nameof(IsDefault));
			RaisePropertyChanged(nameof(Order));
			RaisePropertyChanged(nameof(Weight));
			RaisePropertyChanged(nameof(Abilities));
			RaisePropertyChanged(nameof(GameIndices));
		}
		#endregion
	}
}
