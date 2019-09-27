namespace ObjectOriented_EntityFramework
{
	using Npgsql;
	using System;
	using System.Data.Entity;
	/// <summary>
	/// EduBase���ݿ������ģ�����PostgreSQL����
	/// </summary>
	public partial class EduBasePgsql : MyDbContext
	{
		/// <summary>
		/// ���캯��
		/// </summary>
		public EduBasePgsql()
			: base("name=Pgsql")
		{
		}
		/// <summary>
		/// ʵ�弯���û�����
		/// </summary>
		public virtual DbSet<User> User { get; set; }
		/// <summary>
		/// ����ģ��ʱ��
		/// </summary>
		/// <param name="modelBuilder">ģ�ͽ�����</param>
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema("public");
			modelBuilder.Entity<User>()
				.Property(e => e.No)
				.IsFixedLength()
				.IsUnicode(false);
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
