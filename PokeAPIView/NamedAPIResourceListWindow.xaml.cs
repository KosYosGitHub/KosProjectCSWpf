using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PokeAPI;

namespace PokeAPIView
{
	/// <summary>
	/// NamedAPIResourceList.xaml の相互作用ロジック
	/// </summary>
	public partial class NamedAPIResourceListWindow : Window
	{
		// メンバ変数

		#region ビューモデル
		/// <summary>
		/// ビューモデル
		/// </summary>
		private NamedAPIResourceListViewModel viewModel;
		#endregion

		// イベントハンドラ

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="nameCaption">名称キャプション</param>
		/// <param name="namedAPIResourceList">名前付きAPIリソースリスト</param>
		public NamedAPIResourceListWindow(string nameCaption, NamedAPIResourceList namedAPIResourceList)
		{
			InitializeComponent();
			viewModel = new NamedAPIResourceListViewModel(nameCaption, namedAPIResourceList);
		}
		#endregion

		#region ロード
		/// <summary>
		/// ロード
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			// ViewModel関連付け
			DataContext = viewModel;

			// 名前付きAPIリソースリスト取得
			viewModel.GetNamedAPIResourceList();

			// 先頭行選択
			namedAPIResourceListDataGrid.SelectedIndex = 0;

			// 初期フォーカス設定
			_ = namedAPIResourceListDataGrid.Focus();
		}
		#endregion

		#region 閉じるボタン クリック
		/// <summary>
		/// 閉じるボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void closeButton_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
		#endregion
	}
}
