using System;
using System.Linq.Expressions;
using IosUnitFail;

namespace IosUnitFail.Test
{
    public class StubRepositoryCustomer: IRepository<Customer>
    {
        Customer IRepository<Customer>.GetValue()
        {
            return new Customer();
        }

        void IRepository<Customer>.GetExpression(Expression expr)
        {
            return;
        }
    }
}

