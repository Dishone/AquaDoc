using System;
using System.Linq.Expressions;

namespace AquaDoc.Framework
{
    public interface ISpecification<TEntity>
             where TEntity : class
    {
        Expression<Func<TEntity, bool>> SatisfiedBy();
    }
}
