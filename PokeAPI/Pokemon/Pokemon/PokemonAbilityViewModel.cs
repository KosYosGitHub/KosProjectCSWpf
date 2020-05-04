using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	/// ポケモン特性ビューモデル
	/// </summary>
	public class PokemonAbilityViewModel : KosViewModel
	{
		// internal プロパティ

		#region ポケモン特性モデル
		/// <summary>
		/// ポケモン特性モデル
		/// </summary>
		internal PokemonAbilityModel Model { get; } = new PokemonAbilityModel();
		#endregion

		// public プロパティ

		#region 隠れ特性
		/// <summary>
		/// 隠れ特性
		/// </summary>
		public bool IsHidden
		{
			get => Model.IsHidden;
			set {
				Model.IsHidden = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 特性スロット
		/// <summary>
		/// 特性スロット
		/// </summary>
		public int Slot
		{
			get => Model.Slot;
			set {
				Model.Slot = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 特性
		/// <summary>
		/// 特性
		/// </summary>
		public NamedAPIResourceViewModel Ability => Model.Ability;
		#endregion
	}
}
