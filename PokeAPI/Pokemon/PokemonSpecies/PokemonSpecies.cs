﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KosGeneric;
using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	/// ポケモン種族ビューモデル
	/// </summary>
	public class PokemonSpecies : KosViewModel
	{
		// private プロパティ

		#region ポケモン種族モデル
		/// <summary>
		/// ポケモン種族モデル
		/// </summary>
		private PokemonSpeciesModel Model { get; } = new PokemonSpeciesModel();
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

		#region 性別レート
		/// <summary>
		/// 性別レート
		/// </summary>
		public int GenderRate
		{
			get => Model.GenderRate;
			set {
				Model.GenderRate = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 取得レート
		/// <summary>
		/// 取得レート
		/// </summary>
		public int CaptureRate
		{
			get => Model.CaptureRate;
			set {
				Model.CaptureRate = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 基本なつき度
		/// <summary>
		/// 基本なつき度
		/// </summary>
		public int BaseHappiness
		{
			get => Model.BaseHapiness;
			set {
				Model.BaseHapiness = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 赤ちゃんポケモン
		/// <summary>
		/// 赤ちゃんポケモン
		/// </summary>
		public bool IsBaby
		{
			get => Model.IsBaby;
			set {
				Model.IsBaby = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 孵化歩数
		/// <summary>
		/// 孵化歩数
		/// </summary>
		public int HatchCounter
		{
			get => Model.HatchCounter;
			set {
				Model.HatchCounter = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 性別による見た目の違いの有無
		/// <summary>
		/// 性別による見た目の違いの有無
		/// </summary>
		public bool HasGenderDifferences
		{
			get => Model.HasGenderDifferences;
			set {
				Model.HasGenderDifferences = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region フォルム変化の有無
		/// <summary>
		/// フォルム変化の有無
		/// </summary>
		public bool FormSwitchable
		{
			get => Model.FormsSwitchable;
			set {
				Model.FormsSwitchable = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 成長レート
		/// <summary>
		/// 成長レート
		/// </summary>
		public NamedAPIResource GrowthRate => Model.GrowthRate;
		#endregion

		#region ポケモン図鑑番号リスト
		/// <summary>
		/// ポケモン図鑑番号リスト
		/// </summary>
		public List<PokemonSpeciesDexEntry> PokedexNumbers => Model.PokedexNumbers;
		#endregion

		#region 卵グループリスト
		/// <summary>
		/// 卵グループリスト
		/// </summary>
		public List<NamedAPIResource> EggGroups => Model.EggGroups;
		#endregion

		#region 色
		/// <summary>
		/// 色
		/// </summary>
		public NamedAPIResource Color => Model.Color;
		#endregion

		#region 形
		/// <summary>
		/// 形
		/// </summary>
		public NamedAPIResource Shape => Model.Shape;
		#endregion

		#region 進化元ポケモン種族
		/// <summary>
		/// 進化元ポケモン種族
		/// </summary>
		public NamedAPIResource EvolvesFromSpecies => Model.EvolvesFromSpecies;
		#endregion

		#region 進化ルート
		/// <summary>
		/// 進化ルート
		/// </summary>
		public APIResource EvolutionChain => Model.EvolutionChain;
		#endregion

		#region 生息地
		/// <summary>
		/// 生息地
		/// </summary>
		public NamedAPIResource Habitat => Model.Habitat;
		#endregion

		#region 世代
		/// <summary>
		/// 世代
		/// </summary>
		public NamedAPIResource Generation => Model.Generation;
		#endregion

		#region 名称リスト
		/// <summary>
		/// 名称リスト
		/// </summary>
		public List<Name> Names => Model.Names;
		#endregion

		#region パルパークエンカウントエリアリスト
		/// <summary>
		/// パルパークエンカウントエリアリスト
		/// </summary>
		public List<PalParkEncounterArea> PalParkEncounters => Model.PalParkEncounters;
		#endregion
	}
}
