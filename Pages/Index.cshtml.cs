﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Personal_Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string Om_mig_title { get; private set; }
        public string Om_mig_text { get; private set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Om_mig_title = "Om mig";
            Om_mig_text = "insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here ";
        }
    }
}
