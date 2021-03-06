﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personal_Website.Models
{
    public class Om_mig_text_object
    {
        public string subject { get; set; }
        public JToken text { get; set; }

        public Om_mig_text_object(string subject, JToken text)
        {
            this.subject = subject;
            this.text = text;
        }

        public override string ToString()
        {
            //return string.Format("{0}", "{1}", subject, text);
            return $"{subject}, {text}";
        }
    }
}
