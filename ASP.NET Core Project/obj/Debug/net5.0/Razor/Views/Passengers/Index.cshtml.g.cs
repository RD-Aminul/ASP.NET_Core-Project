#pragma checksum "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d87096e23c516724e6aea60195090acd735c18c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ASP.NET_Core_Project.Passengers.Views_Passengers_Index), @"mvc.1.0.view", @"/Views/Passengers/Index.cshtml")]
namespace ASP.NET_Core_Project.Passengers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\_ViewImports.cshtml"
using ASP.NET_Core_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\_ViewImports.cshtml"
using ASP.NET_Core_Project.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\_ViewImports.cshtml"
using ASP.NET_Core_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\_ViewImports.cshtml"
using ASP.NET_Core_Project.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d87096e23c516724e6aea60195090acd735c18c7", @"/Views/Passengers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4efcee55a3ad25c8d321ce47036199d8e71b4ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Passengers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Passsenger>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/twitter-bootstrap/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Passengers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position:static"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Pager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
  
    ViewData["Title"] = "| Passenger";
    Pager pager = new Pager();
    int pageNo = 0;
    if (ViewBag.Pager != null)
    {
        pager = ViewBag.Pager;
        pageNo = pager.CurrentPage;
    }
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d87096e23c516724e6aea60195090acd735c18c78474", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h1>List of Passenger</h1>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d87096e23c516724e6aea60195090acd735c18c79631", async() => {
                WriteLiteral("Create New Passenger");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d87096e23c516724e6aea60195090acd735c18c711129", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div>
                    <input class=""form-control"" type=""text"" name=""searchText"" placeholder=""Search..."" />
                </div>
                <input class=""p-1 ml-2 btn btn-outline-info btn-light"" type=""submit"" value=""Search"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <table class=""table table-bordered"">
        <thead>
            <tr style=""text-align:center"">
                <th>ID</th>
                <th>Name</th>
                <th>Email</th>
                <th>Journey Date</th>
                <th>Train Name</th>
                <th>Route Name</th>
                <th>Class Name</th>
                <th>Fee</th>
                <th>Photo</th>
                <th>Operations</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 46 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"text-align:center\">\r\n                    <td>");
#nullable restore
#line 49 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
                   Write(item.PassengerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
                   Write(item.PassengerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
                   Write(item.PassengerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
                   Write(Convert.ToString(string.Format("{0:dd-MMM-yyyy}", item.JourneyDate)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 55 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
                   Write(item.Train.TrainName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 56 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
                   Write(item.Route.RouteName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 57 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
                   Write(item.Class.ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
                   Write(item.Fee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d87096e23c516724e6aea60195090acd735c18c716669", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/Images/");
#nullable restore
#line 60 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
                               WriteLiteral(item.PhotoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
#nullable restore
#line 60 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 63 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.PassengerID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 64 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.PassengerID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 65 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
                   Write(Html.ActionLink("Details", "_Details", new { id = item.PassengerID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 68 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n<div class=\"row\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d87096e23c516724e6aea60195090acd735c18c720779", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#nullable restore
#line 74 "D:\IDB_Course\Core_Course\Project\ASP.NET Core\ASP.NET Core Project\ASP.NET Core Project\Views\Passengers\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = pager;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Passsenger>> Html { get; private set; }
    }
}
#pragma warning restore 1591
