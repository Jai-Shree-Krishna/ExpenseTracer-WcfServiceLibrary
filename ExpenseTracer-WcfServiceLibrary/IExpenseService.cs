using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracer_WcfServiceLibrary
{
    [ServiceContract]
    public interface IExpenseService
    {
        [OperationContract]
        bool AddExpense(float amount, string category, string description, int userId, string paymentMethod);

        [OperationContract]
        DataSet GetAllExpenses();

        [OperationContract]
        DataSet GetExpensesByUserId(int userId);
    }
}
