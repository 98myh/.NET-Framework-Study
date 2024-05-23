using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class MemberData
    {
        public List<Member> Members
        {
            get
            {
                return new List<Member>
                {
                    new Member{Member_Number=1, Id="test", Password="1234" , Name="test~1"},
                    new Member{Member_Number=2, Id="test2", Password="2222" , Name="test~2"},
                    new Member{Member_Number=3, Id="test3", Password="3333" , Name="test~3"},
                };
            }
        }
    }
}