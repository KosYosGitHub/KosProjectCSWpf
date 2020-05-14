using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosSQLServer
{
	public class Connection
	{
		// public プロパティ

		#region 接続先の SQL Server インスタンス名またはネットワークアドレス
		/// <summary>
		/// 接続先の SQL Server インスタンス名またはネットワークアドレス
		/// </summary>
		public string DataSource
		{
			get => SqlConnectionStringBuilder.DataSource;
			set => SqlConnectionStringBuilder.DataSource = value;
		}
		#endregion

		#region 接続先のデータベース名
		/// <summary>
		/// 接続先のデータベース名
		/// </summary>
		public string InitialCatalog
		{
			get => SqlConnectionStringBuilder.InitialCatalog;
			set => SqlConnectionStringBuilder.InitialCatalog = value;
		}
		#endregion

		#region 接続に使用するユーザーID
		/// <summary>
		/// 接続に使用するユーザーID
		/// </summary>
		public string UserID
		{
			get => SqlConnectionStringBuilder.UserID;
			set => SqlConnectionStringBuilder.UserID = value;
		}
		#endregion

		#region 接続に使用するパスワード
		/// <summary>
		/// 接続に使用するパスワード
		/// </summary>
		public string Password
		{
			get => SqlConnectionStringBuilder.Password;
			set => SqlConnectionStringBuilder.Password = value;
		}
		#endregion

		#region Windows アカウントの資格情報を認証に使用する場合はtrue、ユーザーIDとパスワードを指定する場合はfalse
		/// <summary>
		/// Windows アカウントの資格情報を認証に使用する場合はtrue、ユーザーIDとパスワードを指定する場合はfalse。
		/// </summary>
		public bool IntegratedSecurity
		{
			get => SqlConnectionStringBuilder.IntegratedSecurity;
			set => SqlConnectionStringBuilder.IntegratedSecurity = value;
		}
		#endregion

		#region 複数のアクティブな結果セットを保持する場合はtrue
		/// <summary>
		/// 複数のアクティブな結果セットを保持する場合はtrue。
		/// </summary>
		public bool MultipleActiveResultSets
		{
			get => SqlConnectionStringBuilder.MultipleActiveResultSets;
			set => SqlConnectionStringBuilder.MultipleActiveResultSets = value;
		}
		#endregion

		// public メソッド

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Connection(string dataSource = null, string initialCatalog = null, string userID = null, string password = null, bool? integratedSecurity = null, bool? multipleActiveResultSets = null)
		{
			if(dataSource != null) {
				DataSource = dataSource;
			}
			if(initialCatalog != null) {
				InitialCatalog = initialCatalog;
			}
			if(userID != null) {
				UserID = userID;
			}
			if(password != null) {
				Password = password;
			}
			if(integratedSecurity.HasValue) {
				IntegratedSecurity = integratedSecurity.Value;
			}
			if(multipleActiveResultSets.HasValue) {
				MultipleActiveResultSets = multipleActiveResultSets.Value;
			}
		}
		#endregion

		#region トランザクションの開始
		/// <summary>
		/// トランザクションの開始
		/// </summary>
		public void BeginTransaction()
		{
			// 多重トランザクションになる場合はエラー
			if(SqlTransaction != null) {
				throw new InvalidOperationException("トランザクション開始後にトランザクションを開始しようとしました。");
			}

			// 未接続の場合は接続する
			if(SqlConnection == null) {
				Open();
			}

			SqlTransaction = SqlConnection.BeginTransaction();
		}
		#endregion

		#region トランザクションの開始(分離レベル指定)
		/// <summary>
		/// トランザクションの開始(分離レベル指定)
		/// </summary>
		/// <param name="iso">トランザクションを実行する分離レベル</param>
		public void BeginTransaction(IsolationLevel iso)
		{
			// 多重トランザクションになる場合はエラー
			if(SqlTransaction != null) {
				throw new InvalidOperationException("トランザクション開始後にトランザクションを開始しようとしました。");
			}

			// 未接続の場合は接続する
			if(SqlConnection == null) {
				Open();
			}

			SqlTransaction = SqlConnection.BeginTransaction(iso);
		}
		#endregion

		#region トランザクションのコミット
		/// <summary>
		/// トランザクションのコミット
		/// </summary>
		public void CommitTransaction()
		{
			// トランザクションが開始されていない
			if(SqlTransaction == null) {
				throw new InvalidOperationException("トランザクションを開始する前にコミットしようとしました。");
			}

			SqlTransaction.Commit();
		}
		#endregion

		#region トランザクションのロールバック
		/// <summary>
		/// トランザクションのロールバック
		/// </summary>
		public void RollbackTransaction()
		{
			// トランザクションが開始されていない
			if(SqlTransaction == null) {
				throw new InvalidOperationException("トランザクションを開始する前にロールバックしようとしました。");
			}

			SqlTransaction.Rollback();
		}
		#endregion

		// private プロパティ

		#region SQL Serverへの接続文字列
		/// <summary>
		/// SQL Serverへの接続文字列
		/// </summary>
		private SqlConnectionStringBuilder SqlConnectionStringBuilder { get; } = new SqlConnectionStringBuilder();
		#endregion

		#region SQL Server コネクション
		/// <summary>
		/// SQL Server コネクション
		/// </summary>
		private SqlConnection SqlConnection { get; set; } = null;
		#endregion

		#region SQL Server トランザクション
		/// <summary>
		/// SQL Server トランザクション
		/// </summary>
		private SqlTransaction SqlTransaction { get; set; } = null;
		#endregion

		// private メソッド

		#region 接続オープン
		/// <summary>
		/// 接続オープン
		/// </summary>
		private void Open()
		{
			// 接続済
			if(SqlConnection != null) {
				return;
			}

			SqlConnection = new SqlConnection(SqlConnectionStringBuilder.ConnectionString);
			SqlConnection.Open();
		}
		#endregion

		#region 接続クローズ
		/// <summary>
		/// 接続クローズ
		/// </summary>
		private void Close()
		{
			// クローズ済
			if(SqlConnection == null) {
				return;
			}

			// トランザクション中の場合はロールバックする(明示的にコミットをしていないため)
			if(SqlTransaction != null) {
				SqlTransaction.Rollback();
			}

			SqlConnection.Close();
			SqlConnection.Dispose();
			SqlConnection = null;
		}
		#endregion
	}
}
