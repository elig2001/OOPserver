using System;
using System.Collections.Generic;
using System.Text;

namespace try2.Models
{
    class Token
    {
        public int Id { set; get; }
        public string acces_token { set; get; }
        public string error_description { set; get; }


        public Token() { }
    }
}
