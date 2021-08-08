using Domain.Contracts.FORG;
using Domain.Entities.FORG;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Xml;

namespace EndPoint.WebUI.App_Class
{
    public static class Authentication
    {
        //private static IHttpContextAccessor _contextAccessor;
        public static IUserExtentionRepository _UserExtentionRepos;
        public static Cookie SetToken(Guid userId, string displayName, IEnumerable<string> accessLevel, List<string> roles, IUserExtentionRepository _UserExtentionRepos)/*, string SipExtension, string SipPassword*/
        {
            Guid token = Guid.NewGuid();
            string strAccessLevel = string.Empty;
            foreach (string item in accessLevel)
            {
                strAccessLevel += item + ',';
            }
            string strRoles = string.Empty;
            foreach (string item in roles)
            {
                strRoles += item + ',';
            }

            //string extensionDetail = string.Format("<UX SipExtension=\"{0}\" SipPassword=\"{1}\" />", SipExtension, SipPassword);

            UserExtention ue = new UserExtention()
            {
                UserId = userId,
                Token = token,
                TagName = strAccessLevel,
                DisplayName = displayName,
                Roles = strRoles,
                //  ExtensionDetail = extensionDetail
            };

            UserExtention temp = _UserExtentionRepos.FindUserExtention(userId);
            if (temp != null)
                _UserExtentionRepos.Update(ue);
            else
                _UserExtentionRepos.Insert(ue);

            Cookie Fanus_FMS_Cooki = new Cookie("Fanus_FMS_Cooki", token.ToString());
            Fanus_FMS_Cooki.Expires = DateTime.Now.AddDays(100);
            return Fanus_FMS_Cooki;
        }

        public static UserExtentionX CurrentUser(string cookie)
        {
            if (cookie != null)
            {
                Guid token = new Guid(cookie.ToString());
                List<UserExtention> lst = _UserExtentionRepos.GetUserExtentionToken(token);
                UserExtention tempUser;
                if (lst != null && lst.Count > 0)
                {
                    tempUser = lst.FirstOrDefault();
                    UserExtentionX outputUser = new UserExtentionX()
                    {
                        UserId = tempUser.UserId,
                        Token = tempUser.Token,
                        TagName = tempUser.TagName,
                        DisplayName = tempUser.DisplayName,
                        Roles = tempUser.Roles,
                        ExtensionDetail = tempUser.ExtensionDetail
                    };
                    return outputUser;
                }
            }
            return null;
        }


    }
    public class UserExtentionX : UserExtention
    {
        public string SipExtension
        {
            get
            {
                XmlDocument doc = new XmlDocument();
                // doc.LoadXml(ExtensionDetail);
                XmlNode node = doc.DocumentElement;
                return node.Attributes["SipExtension"].InnerText;
            }
        }

        public string SipPassword
        {
            get
            {
                XmlDocument doc = new XmlDocument();
                // doc.LoadXml(ExtensionDetail);
                XmlNode node = doc.DocumentElement;
                return node.Attributes["SipPassword"].InnerText;
            }
        }

        //private LibGRS.DatabaseContext.User user = new User();
        //public int? PersonId
        //{
        //    get
        //    {
        //        int? personId = null;
        //        try
        //        {
        //            personId = user.List<LibGRS.DatabaseContext.User>(String.Format("Where UserId = {0}", UserId)).FirstOrDefault().PersonId;
        //        }
        //        catch
        //        {
        //        }
        //        return personId;
        //    }
        //}
    }

    public class CAuthoriseAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            //UserExtention curUser = Authentication.CurrentUser(filterContext.HttpContext.Request.Cookies["Fanus_FMS_Cooki"]);
            //if (curUser != null)
            //{
            //    (filterContext.Controller as Controller).ViewBag.DisplayName = curUser.DisplayName;
            //    base.OnActionExecuting(filterContext);
            //}
            //else
            //{
            //    PathString url = filterContext.HttpContext.Request.Path; //Url.AbsolutePath;

            //    filterContext.Result = new RedirectToRouteResult(
            //             new RouteValueDictionary(
            //                 new
            //                 {
            //                     controller = "Home",
            //                     action = "Index",
            //                     returnUrl = url.Value
            //                 }));
            //}
        }
    }
}
