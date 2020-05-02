using System.Windows;
using PokeAPI;

namespace PokeAPIView
{
	/// <summary>
	/// PokemonSpeciesWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class PokemonSpeciesWindow : Window
	{
		// public static メソッド

		#region 表示
		/// <summary>
		/// 表示
		/// </summary>
		/// <param name="url">URL</param>
		/// <param name="owner">親ウィンドウ</param>
		/// <returns>ShowDialogの結果</returns>
		public static bool? Show(string url, Window owner)
		{
			PokemonSpeciesWindow window = new PokemonSpeciesWindow(url) {
				Owner = owner
			};

			return window.ShowDialog();
		}
		#endregion

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

		#region evolves_from_species 詳細クリック
		/// <summary>
		/// evolves_from_species 詳細クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EvolvesFromSpeciesDetail_Click(object sender, RoutedEventArgs e)
		{
			if(!string.IsNullOrWhiteSpace(viewModel.EvolvesFromSpecies.Name)) {
				_ = Show(viewModel.EvolvesFromSpecies.URL, this);
			}
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

		#region names language詳細 クリック
		/// <summary>
		/// names language詳細 クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NamesGridLanguageDetail_Click(object sender, RoutedEventArgs e)
		{
			if(namesGrid.SelectedItem is Name name) {
				_ = LanguageWindow.Show(name.LanguageURL, this);
			}
		}
		#endregion

		#region flavor_text language詳細 クリック
		/// <summary>
		/// flavor_text language詳細 クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FlavorTextLanguageDetail_Click(object sender, RoutedEventArgs e)
		{
			if(flavorTextEntriesGrid.SelectedItem is FlavorText flavorText) {
				_ = LanguageWindow.Show(flavorText.Language.URL, this);
			}
		}
		#endregion

		#region form_descriptions language詳細 クリック
		/// <summary>
		/// form_descriptions language詳細 クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormDescriptionsGridLanguageDetail_Click(object sender, RoutedEventArgs e)
		{
			if(formDescriptionGrid.SelectedItem is Description item) {
				_ = LanguageWindow.Show(item.Language.URL, this);
			}
		}
		#endregion

		#region genera language詳細 クリック
		/// <summary>
		/// genera language詳細 クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GeneraGridLanguageDetail_Click(object sender, RoutedEventArgs e)
		{
			if(generaGrid.SelectedItem is Genus genus) {
				_ = LanguageWindow.Show(genus.Language.URL, this);
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
