#pragma checksum "C:\Users\haven\Documents\Academics\413\Project1\Views\Home\Confirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbb3381f7ff6a0db84faffc2ccddf7f3b8711514"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Confirm), @"mvc.1.0.view", @"/Views/Home/Confirm.cshtml")]
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
#nullable restore
#line 1 "C:\Users\haven\Documents\Academics\413\Project1\Views\_ViewImports.cshtml"
using ProjectOne;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\haven\Documents\Academics\413\Project1\Views\_ViewImports.cshtml"
using ProjectOne.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbb3381f7ff6a0db84faffc2ccddf7f3b8711514", @"/Views/Home/Confirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"414b3adbc0f8c9edefe2606a3c5b1e918430eb4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Confirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmTime", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">

    <div class=""row mt-2"">

        <div class=""col-12"" align=""center"">
            <h2>Confirm Reservation</h2>
            <br />
            <br />
        </div>

    </div>

    <div class=""row"" align=""center"">
        <div class=""col-12 col-sm-5 card m-auto p-3"">
            <h4>Group Details</h4>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb3381f7ff6a0db84faffc2ccddf7f3b87115144524", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                <div class=\"form-group\">\r\n                    <input type=\"hidden\" /> ");
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"returnUrl\" /> ");
                WriteLiteral("\r\n");
                WriteLiteral(@"                    <div class=""form-group row"">
                        <label class=""col-sm-4 col-form-label"">Time of Tour: </label>
                        <div class=""col-sm-8"">
                            <input readonly class=""form-control-plaintext"" value=""8:00 A.M."" />
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-sm-4 col-form-label"">Name of Group: </label> ");
                WriteLiteral(@"
                        <div class=""col-sm-8"">
                            <input class=""form-control"" type=""text"" /><br />
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-sm-4 col-form-label"">Size of Group: </label> ");
                WriteLiteral(@"
                        <div class=""col-sm-8"">
                            <input class=""form-control"" type=""number"" /><br />
                        </div>
                    </div>
                    <h5>Contact Information</h5>
                    <div class=""form-group"">
                        <div class=""form-group row"">
                            <label class=""col-sm-4 col-form-label"">Email: </label> ");
                WriteLiteral(@"
                            <div class=""col-sm-8"">
                                <input class=""form-control"" type=""email"" /><br />
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-sm-4 col-form-label"">Phone Number: </label> ");
                WriteLiteral("\r\n                            <div class=\"col-sm-8\">\r\n                                <input class=\"form-control\" type=\"text\" /> ");
                WriteLiteral(@"<br />
                            </div>
                        </div>
                    </div>
                    <button type=""submit"" class=""btn btn-primary"">
                        Confirm Reservation
                    </button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
