using System.Collections.Generic;
using System.Text;

namespace builderpatterndemo
{
    public class HTMLElementBuilderDemo
    {
        public string BuildList()
        {
            var builder = new HTMLElementBuilder("ui").AddChild("li").AddChild("li");
            return builder.ToString();
        }
    }

     public class HTMLElement
    {
        public List<HTMLElement> children;
        public string htmlTag;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('<').Append(htmlTag).Append('>');

            foreach (var child in children)
            {
                sb.Append('<').Append(child.htmlTag).Append('>');
                sb.Append("</").Append(child.htmlTag).Append('>');
            }

            sb.Append("</").Append(htmlTag).Append('>');

            return sb.ToString();
        }
    }

    public class HTMLElementBuilder : HTMLElement
    {
        public HTMLElementBuilder(string rootTag)
        {
            this.children = new List<HTMLElement>();
            this.htmlTag = rootTag;
        }

        public HTMLElementBuilder AddChild(string tag)
        {
            this.children.Add(new HTMLElement { htmlTag = tag });
            return this;
        }
    }
}
