using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCopany
{
    public class Story
    {
        private string _title;
        private string _body;
        private string _visualStyle;

        public Story(string title, string body)
        {
            _title = title;
            _body = body;
        }

        public string GetTitle()
        {
            return _title;
        }
        public void SetTitle(string title)
        {
            this._title = title;
        }
        public string GetBody()
        {
            return _body;
        }
        public void SetBody(string body)
        {
            this._body = body;
        }
        public string GetVS()
        {
            return _visualStyle;
        }
        public void SetVS(string visualStyle)
        {
            this._visualStyle = visualStyle;
        }

        public override string ToString()
        {
            return $"Title : {_title}/nVisual Style : {_visualStyle}/nBody : {_body}  ";
        }
    }
}
