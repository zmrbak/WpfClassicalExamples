using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.DataModels
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public String ID { set; get; }
        [DataMember]
        public String FirstName { set; get; }
        [DataMember]
        public String LastName { set; get; }
        [DataMember]
        public String Department { set; get; }
    }
}