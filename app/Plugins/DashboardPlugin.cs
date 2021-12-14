using app.Controllers;
using app.Models;
using Devsense.PHP.Syntax;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Pchp.Core;
using Peachpie.AspNetCore.Mvc;
using PeachPied.WordPress.Standard;
using System;
using System.IO;
using System.Net;

namespace PeachPied.Demo.Plugins
{
    public class DashboardPlugin : IWpPlugin
    {
        public string Title { get; } = "Dashboard Widget";
        private WpApp myapp;
        private delegate string FuncTest();
        private delegate void FuncSubmit();

        public DashboardPlugin()
        {
        }

        public void Configure(WpApp app)
        {
            myapp = app;
            FuncTest func = new FuncTest(Test);
            FuncSubmit Sfunc = new FuncSubmit(Submit);

            //app.DashboardWidget("peachpied.widget.1", "Razor Partial View", writer =>
            //{
            //    app.Context.RenderPartial("DashboardWidget", this);
            //});

            //app.AddFilter("the_content", myfunc);
            app.AddShortcode("Test", func);
            app.AddFilter("wp_head", Sfunc);
        }
        private string Test()
        {
            myapp.Context.RenderPartial("Index");
            return "";
            //string url = "http://localhost:5004/wp-json/wp/v2/posts";

            //var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            //httpRequest.Method = "GET";
            //httpRequest.ContentType = "application/json";

            //var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    var result = streamReader.ReadToEnd();
            //    return result;
            //    //ViewModel v = new ViewModel();
            //    //v.Text = result;
            //    //myapp.Context.RenderPartial("Pages", v);
            //}
        }
        private void Submit()
        {
            //var x = new WP_REST_Request("GET", "http://localhost:5004/wp-json/wp/v2/posts", default);
            //var a = x.get_body_params();
            //var b = a.ToArray();
            //if (b.Count > 0)
            //{

            //}

            //if (Request.Form.Count > 0)
            //{

            //}
        }
    }

    /*
     * Tests dont wokred
     * 
     *app.AddAjaxAction("save_post", add2);
     *dynamic wp = PHP.Core.ScriptContext.CurrentContext.Globals;
     *var a = app.Context.Globals;
     * 
     * 
     *Different between Func & Action
     * 
     *Action<string> add = Test;
     *private void Test(string test)
        {

        }

      Func<string> add2 = Test2;
      private string Test2()
        {
            return "Hello from c#";
        }
     * 
     * 
     * */
}
