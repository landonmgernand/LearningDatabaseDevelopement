namespace ObjectOriented_DataTransferObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
	/// <summary>
	/// �û���
	/// </summary>
    [Table("User")]
    public partial class User
    {
		/// <summary>
		/// �û��ţ�
		/// </summary>
        [Key]
        [StringLength(10)]
        public string No { get; set; }
		/// <summary>
		/// ���룻
		/// </summary>
        [Required]
        [MaxLength(128)]
        public byte[] Password { get; set; }
		/// <summary>
		/// �Ƿ񼤻
		/// </summary>
        public bool IsActivated { get; set; }
		/// <summary>
		/// ��¼ʧ�ܼ�����
		/// </summary>
        public int LoginFailCount { get; set; }
		/// <summary>
		/// ��ɫ��ţ�
		/// </summary>
        public int RoleNo { get; set; }
		/// <summary>
		/// ��ɫ��
		/// </summary>
        public virtual Role Role { get; set; }
    }
}
