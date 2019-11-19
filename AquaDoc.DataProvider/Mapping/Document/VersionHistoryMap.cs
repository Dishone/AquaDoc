using AquaDoc.DataEntities;

namespace AquaDoc.DataProvider
{
    public class VersionHistoryMap : BaseMapping<VersionHistory>
    {
        public VersionHistoryMap()
        {
            this.HasKey(t => t.Id);
            this.ToTable("Application");
            this.Property(t => t.Id).HasColumnName("Id");

        }
    }
}
