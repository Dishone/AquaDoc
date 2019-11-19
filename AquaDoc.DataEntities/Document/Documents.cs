using System;

namespace AquaDoc.DataEntities
{
    public class Documents
    {
        /// 主键
        public string Id { get; set; }
        /// 项目主键
        public string ApplicationId { get; set; }
        /// 标题
        public string Title { get; set; }
        /// 上级目录主键
        public string DirectoryId { get; set; }
        /// 排序
        public int Sort { get; set; }
        /// 文档内容
        public string Document { get; set; }
        /// 创建时间
        public DateTime CreateTime { get; set; }
        /// 启用标识
        public bool IsEnabled { get; set; } = true;

    }
}
