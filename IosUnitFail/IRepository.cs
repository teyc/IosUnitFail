using System;
using System.Linq.Expressions;

namespace IosUnitFail
{
    public interface IRepository<T>
    {
        T GetValue();

        void GetExpression(Expression expr);
    }
}

