using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KosMVVM;
using PokeAPI;

namespace PokeAPIView
{
	public class NamedAPIResourceListViewModel : KosViewModel
	{
		// メンバ変数

		#region 名称キャプション
		/// <summary>
		/// 名称キャプション
		/// </summary>
		private string nameCaption = string.Empty;
		#endregion

		// プロパティ

		#region 名称キャプション
		/// <summary>
		/// 名称キャプション
		/// </summary>
		public string NameCaption
		{
			get => nameCaption;
			set {
				nameCaption = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 名前付きAPIリソースリスト
		/// <summary>
		/// 名前付きAPIリソースリスト
		/// </summary>
		public NamedAPIResourceList NamedAPIResrouceList { get; }
		#endregion

		// イベントハンドラ

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="nameCaption">名称キャプション</param>
		/// <param name="namedAPIResourceList">名前付きAPIリソースリスト</param>
		public NamedAPIResourceListViewModel(string nameCaption, NamedAPIResourceList namedAPIResourceList)
		{
			if(nameCaption == null) {
				throw new ArgumentNullException(nameof(nameCaption));
			}
			if(namedAPIResourceList == null) {
				throw new ArgumentNullException(nameof(namedAPIResourceList));
			}

			this.nameCaption = nameCaption;
			this.NamedAPIResrouceList = namedAPIResourceList;
		}
		#endregion

		// public メソッド

		#region 名前付きAPIリソースリストの取得
		/// <summary>
		/// 名前付きAPIリソースリストの取得
		/// </summary>
		public void GetNamedAPIResourceList()
		{
			this.NamedAPIResrouceList.GetNamedAPIResourceList();
		}
		#endregion
	}
}
