using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace questionAnswer
{
    class Question
    {
        public string TextQuestion { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return this.TextQuestion;
        }
        public static XElement CreateXML(Question question)
        {
            return new XElement(
                "Answer",
                    new XElement("ID", question.ID),
                    new XElement("Text", question.TextQuestion));
                    
        }
    }
}
