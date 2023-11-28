using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AWP_Individual_Project_1.Pages
{
    [BindProperties]
    public class ContactModel : PageModel
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public string message { get; set; }


        public string fnameMsg { get; set; }
        public string lnameMsg { get; set; }
        public string emailMsg { get; set; }

        public string messageMsg { get; set; }
        public string userSubmitMsg { get; set; }

        public string MsgColor;
        public void OnGet()
        {
        }
        public void OnPostSubmit()
        {
            MsgColor = "#59165a";
            userSubmitMsg = "User submited data:";
            fnameMsg = "First Name: " + fname;
            lnameMsg = "Last Name: " + lname;
            emailMsg = "Email: " + email;
            messageMsg = "Message: " + message;
        }
    }
}
