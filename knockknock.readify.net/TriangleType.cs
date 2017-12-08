using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace knockknock.readify.net
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [DataContract(Name = "TriangleType", Namespace = "http://KnockKnock.readify.net")]
    public enum TriangleType : int
    {
        [EnumMemberAttribute()]
        Error = 0,

        [EnumMemberAttribute()]
        Equilateral = 1,

        [EnumMemberAttribute()]
        Isosceles = 2,

        [EnumMemberAttribute()]
        Scalene = 3,
    }
}