using FirstDB;
using SecondDB;
using System;
using System.Data.Entity.Migrations;
using System.ServiceModel;

namespace Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    class Contract : IContract
    {
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = false)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public void UpdateData(string name)
        {
            try
            {
                UpdateFirstDb(name);
                UpdateSecondDb(name);

                OperationContext.Current.SetTransactionComplete();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = false)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public void UpdateFirstDb(string str)
        {
            FirstContext context = new FirstContext();

            FirstDB.Test test = context.Tests.Find(1);
            Console.WriteLine("Data from table {0}", test.name);

            test.name = str;
            Console.WriteLine("Data in table changed to {0}", test.name);

            context.Tests.AddOrUpdate(test);
            context.SaveChanges();

            Console.WriteLine("Changes has been saved!");
            OperationContext.Current.SetTransactionComplete();
        }

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = false)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public void UpdateSecondDb(string str)
        {
            SecondContext context = new SecondContext();

            SecondDB.Test test = context.Tests.Find(1);
            Console.WriteLine("Data from table {0}", test.name);

            test.name = str;
            Console.WriteLine("Data in table changed to {0}", test.name);

            context.Tests.AddOrUpdate(test);
            context.SaveChanges();

            Console.WriteLine("Changes has been saved!");
            OperationContext.Current.SetTransactionComplete();
        }
    }
}
