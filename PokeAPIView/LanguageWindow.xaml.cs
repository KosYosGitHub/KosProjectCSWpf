using System.Windows;
using PokeAPI;

namespace PokeAPIView
{
	/// <summary>
	/// LanguageWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class LanguageWindow : Window
	{
		// プロパティ

		#region 情報URL
		/// <summary>
		/// 情報URL
		/// </summary>
		private string Url { get; } = string.Empty;
		#endregion

		// イベントハンドラ

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public LanguageWindow(string url)
		{
			InitializeComponent();

			Url = url;
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
			viewModel.GetLanguage(Url);
		}
		#endregion

		#region 言語詳細ボタン クリック
		/// <summary>
		/// 言語詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NamesDetailButton_Click(object sender, RoutedEventArgs e)
		{
			if(namesGrid.SelectedItem is Name name) {
				LanguageWindow window = new LanguageWindow(name.LanguageURL) {
					Owner = this
				};
				window.ShowDialog();
			}
		}
		#endregion

		#region 閉じるボタン クリック
		/// <summary>
		/// 閉じるボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CloseButton_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
		#endregion
	}
}
