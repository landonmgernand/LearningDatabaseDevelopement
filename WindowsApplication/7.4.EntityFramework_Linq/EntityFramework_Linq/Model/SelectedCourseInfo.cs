namespace EntityFramework_Linq
{
	/// <summary>
	/// ��ѡ�γ���Ϣ��
	/// </summary>
	public partial class SelectedCourseInfo
	{
		/// <summary>
		/// �γ̺ţ�
		/// </summary>
		public string No { get; set; }
		/// <summary>
		/// �γ����ƣ�
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// ѧ�֣�
		/// </summary>
		public decimal Credit { get; set; }
		/// <summary>
		/// �ɷ��Ƴ���
		/// </summary>
		public bool CanBeRemoved => this.State == EntityInfoState.Added;
		/// <summary>
		/// �Ƿ񶩹��̲ģ�
		/// </summary>
		private bool _OrderBook;
		public bool OrderBook
		{
			get => this._OrderBook;
			set
			{
				this._OrderBook = value;
				if (this.State != EntityInfoState.Added)
				{
					this.State = EntityInfoState.Modified;
				}
			}
		}
		/// <summary>
		/// ״̬��
		/// </summary>
		public EntityInfoState State { get; set; }
	}
}
