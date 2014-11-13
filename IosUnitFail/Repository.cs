using System;
using System.Linq.Expressions;
namespace IosUnitFail
{
    public class RepositoryCustomer: IRepository<Customer>
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

