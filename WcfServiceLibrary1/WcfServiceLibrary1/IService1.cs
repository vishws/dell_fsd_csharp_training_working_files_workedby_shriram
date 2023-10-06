using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int Addition(int a, int b);

        [OperationContract]
        int Substract(int a, int b);
        [OperationContract]
        int Multiplication(int a, int b);
        [OperationContract]
        int Division(int a, int b);
    }
}
