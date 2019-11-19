using System;

namespace AquaDoc.DataEntities
{
    public class User
    {
        // 主键
        public string Id { get; set; }
        // 用户名
        public string UserName { get; set; }
        // 登录账号
        public string Email { get; set; }
        // 登录密码
        public string Password { get; set; }
        // 创建时间 = 默认
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public int roleid { get; set; }
        // 是否是管理员
        public bool IsAdmin { get; set; } = false;
        // 启用标识 
        public bool IsEnabled { get; set; } = true;
    }
}
