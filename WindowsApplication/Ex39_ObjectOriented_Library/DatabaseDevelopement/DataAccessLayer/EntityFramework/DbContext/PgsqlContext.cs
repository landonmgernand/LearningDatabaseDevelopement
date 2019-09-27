namespace SmartLinli.DatabaseDevelopement
{
	using Npgsql;
	using System;
	using System.Data.Entity;
	/// <summary>
	/// ���ݿ������ģ�����PostgreSQL����
	/// </summary>
	public partial class PgsqlContext : MyDbContext
	{
		/// <summary>
		/// ���캯��
		/// </summary>
		public PgsqlContext()
			: base("name=Pgsql")
		{
		}
		/// <summary>
		/// ������ģ�
		/// </summary>
		/// <param name="notUniqueErrorMessage">��Ψһ������Ϣ</param>
		/// <returns>��Ӱ������</returns>
		public override int SaveChanges(string notUniqueErrorMessage)
		{
			int rowAffected = 0;
			try
			{
				rowAffected = this.SaveChanges();
			}
			catch (Exception ex)
			{
				NpgsqlException pgsqlEx = ex.InnerException.InnerException as NpgsqlException;
				if (pgsqlEx.Message.Substring(0, 5) == "23505")
				{
					throw new ApplicationException(notUniqueErrorMessage);
				}
				throw;
			}
			return rowAffected;
		}
	}
}
