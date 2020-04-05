using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using KosGeneric;
using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	/// 名前付きAPIリソースのリスト
	/// </summary>
	public abstract class NamedAPIResourceList : KosViewModel
	{
		// メンバ変数

		#region エンドポイント
		/// <summary>
		/// エンドポイント
		/// </summary>
		private readonly string endPoint = null;
		#endregion

		#region 名前付きAPIリソースのコレクション
		/// <summary>
		/// 名前付きAPIリソースのコレクション
		/// </summary>
		private ObservableCollection<NamedAPIResource> namedAPIResources = new ObservableCollection<NamedAPIResource>();
		#endregion

		#region ListCollectionView
		/// <summary>
		/// 名前付きAPIリソースのListCollectionView
		/// </summary>
		private ListCollectionView namedAPIResroucesView;
		#endregion

		#region 件数
		/// <summary>
		/// 件数
		/// </summary>
		protected int count = 0;
		#endregion

		// プロパティ

		#region エンドポイント
		/// <summary>
		/// エンドポイント
		/// </summary>
		internal string EndPoint => endPoint;
		#endregion

		#region 名前付きAPIリソースのコレクション
		/// <summary>
		/// 名前付きAPIリソースのコレクション
		/// </summary>
		protected internal ObservableCollection<NamedAPIResource> NamedAPIResources => namedAPIResources;
		#endregion

		#region 名前付きAPIリソースのListCollectionView
		/// <summary>
		/// 名前付きAPIリソースのListCollectionView
		/// </summary>
		public ListCollectionView NamedAPIResourcesView => namedAPIResroucesView;
		#endregion

		#region 件数
		/// <summary>
		/// 件数
		/// </summary>
		public int Count
		{
			get => count;
			internal set => count = value;
		}
		#endregion

		// イベントハンドラ

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="endPoint">エンドポイント</param>
		protected NamedAPIResourceList(string endPoint)
		{
			this.endPoint = endPoint;

			namedAPIResroucesView = new ListCollectionView(namedAPIResources);
		}
		#endregion

		// public メソッド

		#region 名前付きAPIリソースリストの取得
		/// <summary>
		/// 名前付きAPIリソースリストの取得
		/// </summary>
		public void GetNamedAPIResourceList()
		{
			// 取得済
			if(namedAPIResources.Any()) {
				return;
			}

			// JSON文字列の取得
			string json = Singleton<PokeAPIClient>.Instance.GetAPIResourceListEndPoint(endPoint);

			// 取得した
			NamedAPIResourceParser parser = new NamedAPIResourceParser();
			parser.ParseNamedAPIResourceList(json, this);
		}
		#endregion
	}
}
