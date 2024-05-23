using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Data;

namespace WebApplication1.Models
{
    public class MemberActs
    {
        public Member GetMember(int paramMemberNumber)
        {
            MemberData memberData = new MemberData();
            return memberData.Members.Where(x => x.Member_Number == paramMemberNumber)
                .SingleOrDefault();
        }
    }
}