﻿using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	/// 属性ビューモデル
	/// </summary>
	public class Genus : KosViewModel
	{
		// internal プロパティ

		#region 属性モデル
		/// <summary>
		/// 属性モデル
		/// </summary>
		internal GenusModel Model { get; } = new GenusModel();
		#endregion

		// public プロパティ

		#region 属性
		/// <summary>
		/// 属性
		/// </summary>
		public string Name
		{
			get => Model.Genus;
			set {
				Model.Genus = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 言語
		/// <summary>
		/// 言語
		/// </summary>
		public NamedAPIResource Language => Model.Language;
		#endregion
	}
}
