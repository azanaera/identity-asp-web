#pragma checksum "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c394f15a3a8b77435202b4292e9c7562de7001f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\era\source\repos\test_asp\test_asp\Views\_ViewImports.cshtml"
using test_asp;

#line default
#line hidden
#line 2 "C:\Users\era\source\repos\test_asp\test_asp\Views\_ViewImports.cshtml"
using test_asp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c394f15a3a8b77435202b4292e9c7562de7001f4", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff8e5e745509b405ddfa725fb655dd073bf75d68", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<test_asp.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(85, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(114, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42644dbe02af413287bb1c03a3f4cc34", async() => {
                BeginContext(137, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(151, 387, true);
            WriteLiteral(@"
</p>


<div class=""row"">
    <div class=""col-md-8"">
        <div class=""card"">
            <div class=""card-header"">
                <h3 class=""card-title"">Bordered Table</h3>
            </div>
            <!-- /.card-header -->
            <div class=""card-body"">
                <table class=""table table-bordered"">
                    <tr>
                        <th>");
            EndContext();
            BeginContext(539, 44, false);
#line 24 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(583, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(619, 42, false);
#line 25 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Access));

#line default
#line hidden
            EndContext();
            BeginContext(661, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(697, 42, false);
#line 26 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(739, 34, true);
            WriteLiteral("</th>\r\n                    </tr>\r\n");
            EndContext();
#line 28 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(846, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(909, 43, false);
#line 31 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
            EndContext();
            BeginContext(952, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(992, 41, false);
#line 32 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Access));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 201, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                <input type=\"checkbox\" class=\"icheckbox_flat-green\" checked>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 37 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1257, 4851, true);
            WriteLiteral(@"                </table>
            </div>
            <!-- /.card-body -->
            <div class=""card-footer clearfix"">
                <ul class=""pagination pagination-sm m-0 float-right"">
                    <li class=""page-item""><a class=""page-link"" href=""#"">&laquo;</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">&raquo;</a></li>
                </ul>
            </div>
        </div>
        <!-- /.card -->

    </div> <!-- .col-md-6-->

    <div class=""col-md-4"">

        <!-- iCheck -->
        <div class=""card card-success"">
            <div class=""card-header"">
                <h3 class=""card-title"">iCheck - Checkbox &amp; Radio Inputs</h3>
            </div>
            <div class=""card-body"">
 ");
            WriteLiteral(@"               <!-- Minimal style -->
                <!-- checkbox -->
                <div class=""form-group"">
                    <label>
                        <input type=""checkbox"" class=""icheckbox_flat-green"" checked>
                    </label>
                    <label>
                        <input type=""checkbox"" class=""minimal"">
                    </label>
                    <label>
                        <input type=""checkbox"" class=""minimal"" disabled>
                        Minimal skin checkbox
                    </label>
                </div>

                <!-- radio -->
                <div class=""form-group"">
                    <label>
                        <input type=""radio"" name=""r1"" class=""minimal"" checked>
                    </label>
                    <label>
                        <input type=""radio"" name=""r1"" class=""minimal"">
                    </label>
                    <label>
                        <input type=""radio"" name=""r1"" class=");
            WriteLiteral(@"""minimal"" disabled>
                        Minimal skin radio
                    </label>
                </div>

                <!-- Minimal red style -->
                <!-- checkbox -->
                <div class=""form-group"">
                    <label>
                        <input type=""checkbox"" class=""minimal-red"" checked>
                    </label>
                    <label>
                        <input type=""checkbox"" class=""minimal-red"">
                    </label>
                    <label>
                        <input type=""checkbox"" class=""minimal-red"" disabled>
                        Minimal red skin checkbox
                    </label>
                </div>

                <!-- radio -->
                <div class=""form-group"">
                    <label>
                        <input type=""radio"" name=""r2"" class=""minimal-red"" checked>
                    </label>
                    <label>
                        <input type=""radio"" name=""r2"" clas");
            WriteLiteral(@"s=""minimal-red"">
                    </label>
                    <label>
                        <input type=""radio"" name=""r2"" class=""minimal-red"" disabled>
                        Minimal red skin radio
                    </label>
                </div>

                <!-- Minimal red style -->
                <!-- checkbox -->
                <div class=""form-group"">
                    <label>
                        <input type=""checkbox"" class=""flat-red"" checked>
                    </label>
                    <label>
                        <input type=""checkbox"" class=""flat-red"">
                    </label>
                    <label>
                        <input type=""checkbox"" class=""flat-red"" disabled>
                        Flat green skin checkbox
                    </label>
                </div>

                <!-- radio -->
                <div class=""form-group"">
                    <label>
                        <input type=""radio"" name=""r3"" class=""flat-");
            WriteLiteral(@"red"" checked>
                    </label>
                    <label>
                        <input type=""radio"" name=""r3"" class=""flat-red"">
                    </label>
                    <label>
                        <input type=""radio"" name=""r3"" class=""flat-red"" disabled>
                        Flat green skin radio
                    </label>
                </div>
            </div>
            <!-- /.card-body -->
            <div class=""card-footer"">
                Many more skins available. <a href=""http://fronteed.com/iCheck/"">Documentation</a>
            </div>
        </div>
    </div> <!-- ./col-md-4 -->
</div><!-- .row -->
<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
            EndContext();
            BeginContext(6109, 44, false);
#line 161 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(6153, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(6209, 44, false);
#line 164 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(6253, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(6309, 42, false);
#line 167 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Access));

#line default
#line hidden
            EndContext();
            BeginContext(6351, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(6407, 42, false);
#line 170 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(6449, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 176 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(6584, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6645, 43, false);
#line 180 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
            EndContext();
            BeginContext(6688, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6756, 43, false);
#line 183 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
            EndContext();
            BeginContext(6799, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6867, 41, false);
#line 186 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Access));

#line default
#line hidden
            EndContext();
            BeginContext(6908, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6976, 41, false);
#line 189 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(7017, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(7084, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08185c10eed2460d86d1cd842c759f99", async() => {
                BeginContext(7129, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 192 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
                                           WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7137, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(7161, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "499f352671354c9689c0891651709258", async() => {
                BeginContext(7209, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 193 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
                                              WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7220, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(7244, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e39014d09722488091883fb072370386", async() => {
                BeginContext(7291, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 194 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
                                             WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7301, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 197 "C:\Users\era\source\repos\test_asp\test_asp\Views\Users\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(7356, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<test_asp.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591