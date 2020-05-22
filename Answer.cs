using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace questionAnswer
{
    public class Answer
    {
        public string Text { get; set; }
        public bool Correct { get; set; }

        public int ID { set; get; }

        public override string ToString()
        {
            return this.Text;
        }
        public static XElement CreateXML(Answer answer)
        {
            return new XElement(
                "Answer",
                    new XElement("ID", answer.ID),
                    new XElement("Text", answer.Text),
                    new XElement("Correct", answer.Correct));
        }
    }
}
