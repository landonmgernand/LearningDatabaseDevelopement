namespace ObjectOriented_DataTransferObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
	/// <summary>
	/// ��ɫ��
	/// </summary>
    [Table("Role")]
    public partial class Role
    {
		/// <summary>
		/// ���캯����
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Role()
        {
            User = new HashSet<User>();
        }
		/// <summary>
		/// ��ţ�
		/// </summary>
        [Key]
        public int No { get; set; }
		/// <summary>
		/// ���ƣ�
		/// </summary>
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
		/// <summary>
		/// �û���
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<User> User { get; set; }
    }
}
