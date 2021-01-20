using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PhoneBookApp002.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace PhoneBookApp002.Controllers
{
    public class AccountController : ApiController
    {
        [ResponseType(typeof(AccountModel))]
        [Route("api/user/register")]
        [HttpPost]
        public IdentityResult Register(AccountModel model)
        {
            var userStore = new UserStore<IdentityUser>(new PhoneBookDBContext());
            var userManager = new UserManager<IdentityUser>(userStore);
            

            // set my custome validation. default is 6
            userManager.PasswordValidator = new PasswordValidator { RequiredLength = 3 };


            // save recived data
            var user = new IdentityUser();
            user.UserName = model.UserName;
            user.Email = model.Email;

            IdentityResult identityResult = userManager.Create(user, model.Password);
            return identityResult;

        }


    }
}
