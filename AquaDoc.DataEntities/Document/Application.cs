using System;

namespace AquaDoc.DataEntities
{
    public class Application
    {
        // 主键
        public string Id { get; set; }
        // 项目名称
        public string ProjectName { get; set; }
        // 描述
        public string Description { get; set; }
        // 用户主键
        public string UserId { get; set; }
        // 启用标识
        public bool IsEnabled { get; set; } = true;
        // 创建时间
        public DateTime CreateTime { get; set; } = DateTime.Now;
        // 导航属性
        public User User { get; set; }
    }
}
