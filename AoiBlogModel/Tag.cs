using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AoiBlogModel
{
    [Table("tag")]
    public class Tag
    {
        [Key]
        public int No { get; set; }
        /// <summary>
        /// 标签名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 创建者
        /// </summary>
        public string Creator { get; set; }
        public DateTime RegTime { get; set; }
    }
}
