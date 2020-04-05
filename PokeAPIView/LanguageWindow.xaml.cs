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
	/// LanguageWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class LanguageWindow : Window
	{
		// メンバ変数

		#region 情報URL
		/// <summary>
		/// 情報URL
		/// </summary>
		private string url = string.Empty;
		#endregion

		#region ビューモデル
		/// <summary>
		/// 言語ビューモデル
		/// </summary>
		private Language lang = new Language();
		#endregion

		// イベントハンドラ

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public LanguageWindow(string url)
		{
			InitializeComponent();

			this.url = url;
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
			lang.GetLanguage(url);

			DataContext = lang;
		}
		#endregion

		#region 閉じる
		/// <summary>
		/// 閉じる
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
