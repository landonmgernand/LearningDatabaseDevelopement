namespace SmartLinli.DatabaseDevelopement
{
	using System;
	using System.Data.Entity;
	using System.Data.SqlClient;
	/// <summary>
	/// ���ݿ������ģ�����SQL Server����
	/// </summary>
	public partial class SqlContext : MyDbContext
	{
		/// <summary>
		/// ���캯��
		/// </summary>
		public SqlContext()
			: base("name=Sql")
		{
		}
		/// <summary>
		/// ����ģ��ʱ��
		/// </summary>
		/// <param name="modelBuilder">ģ�ͽ�����</param>
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema("dbo");
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
				SqlException sqlEx = ex.InnerException.InnerException as SqlException;
				if (sqlEx.Number == 2627)
				{
					throw new ApplicationException(notUniqueErrorMessage);
				}
				throw;
			}
			return rowAffected;
		}
	}
}
