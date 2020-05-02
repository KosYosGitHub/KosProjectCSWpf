using System;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight.CommandWpf;
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

		#region 詳細ウィンドウタイプ
		/// <summary>
		/// 詳細ウィンドウタイプ
		/// </summary>
		public Type DetailWindowType { get; set; }
		#endregion

		#region 選択変更コマンド
		/// <summary>
		/// 選択変更コマンド
		/// </summary>
		public RelayCommand<DataGrid> SelectedChangedCommand { get; }
		#endregion

		#region 詳細ボタンクリックコマンド
		/// <summary>
		/// 詳細ボタンクリックコマンド
		/// </summary>
		public RelayCommand DetailClickCommand { get; }
		#endregion

		// private プロパティ

		#region 選択中オブジェクト
		/// <summary>
		/// 選択中オブジェクト
		/// </summary>
		private NamedAPIResourceViewModel Selected { get; set; }
		#endregion

		// イベントハンドラ

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="nameCaption">名称キャプション</param>
		/// <param name="namedAPIResourceList">名前付きAPIリソースリスト</param>
		/// <param name="detailWindowType">詳細ウィンドウの型情報</param>
		public NamedAPIResourceListViewModel(string nameCaption, NamedAPIResourceList namedAPIResourceList, Type detailWindowType)
		{
			NameCaption = nameCaption ?? throw new ArgumentNullException(nameof(nameCaption));
			NamedAPIResrouceList = namedAPIResourceList ?? throw new ArgumentNullException(nameof(namedAPIResourceList));
			DetailWindowType = detailWindowType;

			SelectedChangedCommand = new RelayCommand<DataGrid>(SelectedChanged);
			DetailClickCommand = new RelayCommand(DetailClick);
		}
		#endregion

		#region 選択変更
		/// <summary>
		/// 選択変更
		/// </summary>
		/// <param name="dataGrid">データグリッド</param>
		private void SelectedChanged(DataGrid dataGrid)
		{
			if(dataGrid.IsLoaded) {
				Selected = (dataGrid.SelectedItem as NamedAPIResourceViewModel);
			}
		}
		#endregion

		#region 詳細ボタン クリック
		/// <summary>
		/// 詳細ボタン クリック
		/// </summary>
		private void DetailClick()
		{
			if(Selected == null) {
				return;
			}

			object window = Activator.CreateInstance(DetailWindowType, Selected.URL);
			PropertyInfo ownerProperty = DetailWindowType.GetProperty("Owner");
			MethodInfo showDialogMethod = DetailWindowType.GetMethod("ShowDialog");

			ownerProperty.SetValue(window, Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive));
			_ = showDialogMethod.Invoke(window, new object[] { });
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
