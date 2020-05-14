namespace ObjectOriented_DataTransferObject
{
	using System;
	using System.Data.Entity;
	using System.Data.SqlClient;
	/// <summary>
	/// EduBase���ݿ������ģ�����SQL Server����
	/// </summary>
	public partial class EduBaseSql : MyDbContext
	{
		/// <summary>
		/// ���캯��
		/// </summary>
		public EduBaseSql()
			: base("name=Sql")
		{
		}
		/// <summary>
		/// ʵ�弯����ɫ����
		/// </summary>
		public virtual DbSet<Role> Role { get; set; }
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
			modelBuilder.HasDefaultSchema("dbo");
			modelBuilder.Entity<Role>().ToTable("tb_Role");
			modelBuilder.Entity<User>().ToTable("tb_User");
			modelBuilder.Entity<Role>()
				.HasMany(r => r.User)
				.WithRequired(u => u.Role);
			//modelBuilder.Entity<User>()
			//	.HasRequired(u => u.Role)
			//	.WithMany(r => r.User);

			modelBuilder.Entity<Role>()
				.Property(e => e.Name)
				.IsUnicode(false);
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
