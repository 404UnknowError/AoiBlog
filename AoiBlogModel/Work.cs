using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AoiBlogModel
{
    [Table("work")]
    public class Work
    {
        [Key]
        public int No { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 类型 0-随笔 1-好物推荐
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        [MaxLength(32)]
        public string Author { get; set; }
        /// <summary>
        /// 发表时间
        /// </summary>
        public DateTime RegTime { get; set; }
        /// <summary>
        /// 状态 0-待审批 1-通过 2-拒绝 3-冻结
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 点赞数
        /// </summary>
        public int Upvote { get; set; }
        /// <summary>
        /// 反对数
        /// </summary>
        public int Downvote { get; set; }
        /// <summary>
        /// 访问量
        /// </summary>
        public int Visits { get; set; }
        /// <summary>
        /// 是否置顶 1-置顶 0-不置顶
        /// </summary>
        public int IsTop { get; set; }
        public List<Tag> TagList { get; set; }
        public string JsonData { get; set; }
        public int R1 { get; set; }
        public int R2 { get; set; }
        public string R3 { get; set; }
        public string R4 { get; set; }
        public string R5 { get; set; }
    }
}
