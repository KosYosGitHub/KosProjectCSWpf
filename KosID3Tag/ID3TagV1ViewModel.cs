using KosMVVM;

namespace KosID3Tag
{
	public class ID3TagV1ViewModel : KosViewModel
	{
		// public プロパティ

		#region 存在フラグ
		/// <summary>
		/// 存在フラグ
		/// </summary>
		public bool IsExists => Model.IsExists;
		#endregion

		#region バージョン
		/// <summary>
		/// バージョン
		/// </summary>
		public ID3TagV1Version Version
		{
			get => Model.Version;
			private set {
				Model.Version = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 曲名
		/// <summary>
		/// 曲名
		/// </summary>
		public string SongTitle
		{
			get => Model.SongTitle;
			set {
				Model.SongTitle = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region アーティスト
		/// <summary>
		/// アーティスト
		/// </summary>
		public string Artist
		{
			get => Model.Artist;
			set {
				Model.Artist = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region アルバム
		/// <summary>
		/// アルバム
		/// </summary>
		public string Album
		{
			get => Model.Album;
			set {
				Model.Album = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 西暦
		/// <summary>
		/// 西暦
		/// </summary>
		public string Year
		{
			get => Model.Year;
			set {
				Model.Year = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region コメント
		/// <summary>
		/// コメント
		/// </summary>
		public string Comment
		{
			get => Model.Comment;
			set {
				Model.Comment = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region トラック番号
		/// <summary>
		/// トラック番号
		/// </summary>
		public byte TrackNo
		{
			get => Model.TrackNo;
			set {
				Model.TrackNo = value;
				RaisePropertyChanged();

				if(Model.TrackNo == 0) {
					Version = ID3TagV1Version.ID3v1_1;
				}
				else {
					Version = ID3TagV1Version.ID3v1_1;
					// Todo: コメントをShift-JISで28byteでLeftする必要あり(泣き別れ注意)
				}
			}
		}
		#endregion

		#region ジャンル番号
		/// <summary>
		/// ジャンル番号
		/// </summary>
		public byte GenreNo
		{
			get => Model.GenreNo;
			set {
				Model.GenreNo = value;
				RaisePropertyChanged();
				RaisePropertyChanged(nameof(Genre));
			}
		}
		#endregion

		#region ジャンル
		/// <summary>
		/// ジャンル
		/// </summary>
		public string Genre => Model.Genre;
		#endregion

		// public メソッド

		#region ファイルの読込
		/// <summary>
		/// ファイルの読込
		/// </summary>
		/// <param name="path"></param>
		public void ReadFile(string path)
		{
			// ID3v1の読込
			Model.ReadFile(path);

			// プロパティ更新
			RaisePropertyChanged(nameof(IsExists));
			RaisePropertyChanged(nameof(Version));
			RaisePropertyChanged(nameof(SongTitle));
			RaisePropertyChanged(nameof(Artist));
			RaisePropertyChanged(nameof(Album));
			RaisePropertyChanged(nameof(Year));
			RaisePropertyChanged(nameof(Comment));
			RaisePropertyChanged(nameof(TrackNo));
			RaisePropertyChanged(nameof(GenreNo));
			RaisePropertyChanged(nameof(Genre));
		}
		#endregion

		// private プロパティ

		#region モデル
		/// <summary>
		/// モデル
		/// </summary>
		private ID3TagV1Model Model { get; } = new ID3TagV1Model();
		#endregion
	}
}
