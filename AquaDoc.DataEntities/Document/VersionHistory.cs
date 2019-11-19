using System;

namespace AquaDoc.DataEntities
{
    public class VersionHistory
    {
        public string Id { get; set; }
        /// 修改时间
        public DateTime ModifyTime { get; set; } = DateTime.Now;
        /// 用户主键
        public string UserId { get; set; }
        /// 历史文档内容
        public string Document { get; set; }
    }
}
