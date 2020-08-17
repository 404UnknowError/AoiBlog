using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AoiBlogModel
{
    /// <summary>
    /// 回复信息类
    /// </summary>
    [Table("message")]
    public class Message
    {
        [Key]
        public int No { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string FriendName { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// 回复的消息no,为0时是直接回复
        /// </summary>
        public int ReplyNo { get; set; }
        /// <summary>
        /// 消息类型  0-随笔/好物推荐消息 1-留言板消息 
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 0-正常 1-冻结/隐藏
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 回复时间
        /// </summary>
        public DateTime RegTime { get; set; }
        public string JsonData { get; set; }
        public int R1 { get; set; }
        public int R2 { get; set; }
        public string R3 { get; set; }
        public string R4 { get; set; }
        public string R5 { get; set; }
    }
}
