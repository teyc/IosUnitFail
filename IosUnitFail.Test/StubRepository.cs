using System;
using System.Linq.Expressions;
using IosUnitFail;

namespace IosUnitFail.Test
{
    public class StubRepositoryCustomer: IRepository<Customer>
    {
        void IRepository<Customer>.GetExpression(Expression expr)
        {
            return;
        }
    }
}

