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
    public interface IAuthService
    {
        [OperationContract]
        int SignIn(string email, string password);

        [OperationContract]
        int SignUp(string email, string password, string username);

        [OperationContract]
        DataSet GetAllUser();
    }
}
