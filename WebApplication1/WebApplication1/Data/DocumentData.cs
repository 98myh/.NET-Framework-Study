using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DocumentData 
    {
        public List<Document> Documents
        {
            get
            {
                return new List<Document>
                {
                    new Document{Document_Number=1,Title="공지사항 입니다.",Writer="홍길동" },
                    new Document{Document_Number=2,Title="제목입니다 #1.",Writer="이순신" },
                    new Document{Document_Number=3,Title="제목입니다.#2.",Writer="신사임당" },
                    new Document{Document_Number=4,Title="제목입니다.#3.",Writer="이율곡" },
                    new Document{Document_Number=5,Title="제목입니다.#4.",Writer="정약용" },
                };
            }
        }
    }
}