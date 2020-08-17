using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AoiBlogModel
{
    [Table("picture")]
    public class Picture
    {
        [Key]
        public int No { get; set; }
        /// <summary>
        /// 源文件路径
        /// </summary>
        public string SourcePath { get; set; }
        /// <summary>
        /// 缩略图路径
        /// </summary>
        public string TumpPath { get; set; }
        /// <summary>
        /// 类型 0-普通 1-轻骑 2-R18 3-图床用
        /// </summary>
        public int Type { get; set; }
        public DateTime RegTime { get; set; }
    }
}
