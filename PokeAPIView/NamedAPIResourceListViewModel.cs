using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using KosMVVM;
using PokeAPI;

namespace PokeAPIView
{
	public class NamedAPIResourceListViewModel : KosViewModel
	{
		// コマンド

		#region 選択変更コマンド
		/// <summary>
		/// 選択変更コマンド
		/// </summary>
		public static readonly RoutedCommand SelectedChangedCommand = new RoutedCommand("SelectChangedCommand", typeof(NamedAPIResourceListViewModel));
		#endregion

		#region 詳細ボタンクリックコマンド
		/// <summary>
		/// 詳細ボタンクリックコマンド
		/// </summary>
		public static readonly RoutedCommand DetailClickCommand = new RoutedCommand("DetailClickCommand", typeof(NamedAPIResourceListViewModel));
		#endregion

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

		// private プロパティ

		#region 選択中オブジェクト
		/// <summary>
		/// 選択中オブジェクト
		/// </summary>
		private NamedAPIResource Selected { get; set; }
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
		}
		#endregion

		#region 選択変更
		/// <summary>
		/// 選択変更
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SelectedChanged(object sender, RoutedEventArgs e)
		{
			NamedAPIResourceListWindow window = sender as NamedAPIResourceListWindow;
			if(window == null) {
				return;
			}

			if(window.namedAPIResourceListDataGrid.IsLoaded) {
				Selected = (window.namedAPIResourceListDataGrid.SelectedItem as NamedAPIResource);
			}
		}
		#endregion

		#region 詳細ボタン クリック
		/// <summary>
		/// 詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DetailClick(object sender, RoutedEventArgs e)
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

		#region コマンドの初期化
		/// <summary>
		/// コマンドの初期化
		/// </summary>
		/// <param name="commands">Command Binding Collection</param>
		public void InitializeCommandBindings(CommandBindingCollection commands)
		{
			commands.Add(new CommandBinding(SelectedChangedCommand, SelectedChanged));
			commands.Add(new CommandBinding(DetailClickCommand, DetailClick));
		}
		#endregion

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
