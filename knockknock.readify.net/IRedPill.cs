﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace knockknock.readify.net
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [ServiceContract(Namespace = "http://KnockKnock.readify.net", ConfigurationName = "IRedPill")]
    public interface IRedPill
    {
        [OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/WhatIsYourToken", ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatIsYourTokenResponse")]
        Guid WhatIsYourToken();

        [OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumber", ReplyAction = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberResponse")]
        [FaultContractAttribute(typeof(ArgumentOutOfRangeException), Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberArgumentOutOfRangeException" + "Fault", Name = "ArgumentOutOfRangeException", Namespace = "http://schemas.datacontract.org/2004/07/System")]
        long FibonacciNumber(long n);

        [OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis", ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisResponse")]
        TriangleType WhatShapeIsThis(int a, int b, int c);

        [OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/ReverseWords", ReplyAction = "http://KnockKnock.readify.net/IRedPill/ReverseWordsResponse")]
        [FaultContractAttribute(typeof(ArgumentNullException), Action = "http://KnockKnock.readify.net/IRedPill/ReverseWordsArgumentNullExceptionFault", Name = "ArgumentNullException", Namespace = "http://schemas.datacontract.org/2004/07/System")]
        string ReverseWords(string s);
    }
}