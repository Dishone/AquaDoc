using System;

namespace AquaDoc.DataEntities
{
    public class Directories
    {
        // 主键
        public string Id { get; set; }
        // 项目主键
        public string ApplicationId { get; set; }
        // 目录名称
        public string DirectoryName { get; set; }
        // 上级目录主键
        public string DirectoryId { get; set; }
        // 排序
        public int Sort { get; set; }
        // 创建时间
        public DateTime CreateTime { get; set; } = DateTime.Now;
        // 启用标识
        public bool IsEnabled { get; set; } = true;
    }
}
