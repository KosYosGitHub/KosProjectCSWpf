namespace KosGeneric
{
	/// <summary>
	/// 拡張メソッド
	/// </summary>
	public static class Extensions
	{
		// bool? 拡張メソッド

		#region nullはfalseとして判定
		/// <summary>
		/// nullはfalseとして判定
		/// </summary>
		/// <param name="val">値</param>
		/// <returns>true/false</returns>
		public static bool IsTrue(this bool? val)
		{
			return val ?? false;
		}
		#endregion
	}
}
