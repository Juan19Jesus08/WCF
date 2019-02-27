using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1
{
    [DataContract]
    public class Person
    {
        [DataMember]

        public int Id { get; set; }

        [DataMember]

        public string Name { get; set; }

        [DataMember]

        public int Age { get; set; }
    }
}