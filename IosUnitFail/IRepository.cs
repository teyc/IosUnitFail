using System;
using System.Linq.Expressions;

namespace IosUnitFail
{
    public interface IRepository<T>
    {
        void GetExpression(Expression expr);
    }
}

