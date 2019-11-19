using System.Data.Entity.ModelConfiguration;

namespace AquaDoc.DataProvider
{
    public class BaseMapping<TEntiy> : EntityTypeConfiguration<TEntiy> where TEntiy : class
    {
    }

}
