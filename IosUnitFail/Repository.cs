using System;
using System.Linq.Expressions;
namespace IosUnitFail
{
    public class RepositoryCustomer: IRepository<Customer>
    {
       
        void IRepository<Customer>.GetExpression(Expression expr)
        {
            return;
        }
    }
}

