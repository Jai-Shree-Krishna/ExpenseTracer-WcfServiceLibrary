using ExpenseTracer_WcfServiceLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ExpenseTracer_WcfServiceLibrary
{
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        bool AddCategory(string category, int UserId);

        [OperationContract]
        DataSet GetCategories(int UserId);

        [OperationContract]
        DataSet GetAllCategories();
    }
}
