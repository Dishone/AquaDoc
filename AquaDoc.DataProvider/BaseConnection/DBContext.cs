using System.Data;
using System.Data.Entity;


namespace AquaDoc.DataProvider
{
    public class DBContext<TEntiy> : DbContext where TEntiy : class
    {
        static DBContext()
        {
            Database.SetInitializer<DBContext<TEntiy>>(null);
        }
        private static string ConnectStr()
        {
            string connect = "Server=.;Database=AquaDoc;Trusted_Connection=True;MultipleActiveResultSets=true";
            return connect;
        }
            
        public DBContext()
           : base(ConnectStr())
        {
        }
        public DbSet<TEntiy> Entity { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
