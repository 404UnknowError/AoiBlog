using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AoiBlogModel
{
    [Table("user")]
    public class User
    {
        [Key]
        public int No { get; set; }
        /// <summary>
        /// 账户名
        /// </summary>
        [MaxLength(32)]
        public string Account { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string FriendName { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime RegTime { get; set; }
        /// <summary>
        /// 状态 0-正常 1-冻结
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 权限 0-游客 1-会员 2-管理员 99-超级管理员
        /// </summary>
        public int Power { get; set; }
    }
}
