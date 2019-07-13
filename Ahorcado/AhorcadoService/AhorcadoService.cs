using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoService
{
    [DataContract]
    public class Name
    {
        [DataMember]
        public string First;
        [DataMember]
        public string Last;
    }

    [ServiceContract]
    public interface IAhorcado
    {
        [OperationContract]
        string SayHello(Name person);
    }

    public class AhorcadoService : IAhorcado
    {
        public string SayHello(Name person)
        {
            return string.Format("Hello {0} {1}",
            person.First, person.Last);
        }
    }
}
