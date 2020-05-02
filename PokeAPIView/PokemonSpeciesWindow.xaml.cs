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
	/// PokemonSpeciesWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class PokemonSpeciesWindow : Window
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
		public PokemonSpeciesWindow(string url)
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
			viewModel.GetPokemonSpecies(Url);
		}
		#endregion

		#region growth_rate 詳細ボタン クリック
		/// <summary>
		/// growth_rate 詳細ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GrowthRateDetail_Click(object sender, RoutedEventArgs e)
		{

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
