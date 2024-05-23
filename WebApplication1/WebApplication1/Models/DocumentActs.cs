using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Data;

namespace WebApplication1.Models
{
//데이터 처리 담당 -> return 해서 controller로 전달해줌
    public class DocumentActs
    {
        public List<Document> GetDocuments()
        {
            DocumentData documentData = new DocumentData();
            return documentData.Documents;
        }
    }
}