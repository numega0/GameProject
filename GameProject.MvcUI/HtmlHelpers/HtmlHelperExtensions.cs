using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameProject.MvcUI.HtmlHelpers
{
    public static class HtmlHelperExtensions
    {
        public static string ActivePage(this HtmlHelper helper, string controller, string action)

        {

            string classValue = "";

            string currentController = helper.ViewContext.Controller.ValueProvider.GetValue("controller").RawValue.ToString();

            string currentAction = helper.ViewContext.Controller.ValueProvider.GetValue("action").RawValue.ToString();

            if (currentController == controller && currentAction == action)

            {

                classValue = "active";

            }

            return classValue;

        }



        public static string NestedActivePage(this HtmlHelper helper, string controller, string action)

        {

            string classValue = "";

            string currentController = helper.ViewContext.Controller.ValueProvider.GetValue("controller").RawValue.ToString();

            string currentAction = helper.ViewContext.ParentActionViewContext.RouteData.Values["action"].ToString();

            if (currentController == controller && currentAction == action)

            {

                classValue = "active";

            }

            return classValue;

        }

    }
}