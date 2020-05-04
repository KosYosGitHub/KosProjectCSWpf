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

namespace PokeAPIView
{
	/// <summary>
	/// PokemonWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class PokemonWindow : Window
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
		public PokemonWindow(string url)
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
			viewModel.GetPokemon(Url);

			foreach(string spriteUrl in viewModel.Sprites) {
				_ = spritesStackPanel.Children.Add(new Image() { Source = new BitmapImage(new Uri(spriteUrl)) });
			}
		}
		#endregion

		#region 閉じるボタン クリック
		/// <summary>
		/// 閉じるボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Close_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
		#endregion
	}
}
