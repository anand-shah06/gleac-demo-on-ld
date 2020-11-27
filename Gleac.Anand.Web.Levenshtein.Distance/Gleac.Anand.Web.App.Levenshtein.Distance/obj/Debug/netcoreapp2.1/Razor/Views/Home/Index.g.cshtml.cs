#pragma checksum "C:\A_Workarea\Local_Repository_Git\dot_net_stack\GLEAC-DEMO-ON-LD\Gleac.Anand.Web.Levenshtein.Distance\Gleac.Anand.Web.App.Levenshtein.Distance\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6b10513e834eaa02444d8ee302e5f021c818058"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\A_Workarea\Local_Repository_Git\dot_net_stack\GLEAC-DEMO-ON-LD\Gleac.Anand.Web.Levenshtein.Distance\Gleac.Anand.Web.App.Levenshtein.Distance\Views\_ViewImports.cshtml"
using Gleac.Anand.Web.App.Levenshtein.Distance;

#line default
#line hidden
#line 2 "C:\A_Workarea\Local_Repository_Git\dot_net_stack\GLEAC-DEMO-ON-LD\Gleac.Anand.Web.Levenshtein.Distance\Gleac.Anand.Web.App.Levenshtein.Distance\Views\_ViewImports.cshtml"
using Gleac.Anand.Web.App.Levenshtein.Distance.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6b10513e834eaa02444d8ee302e5f021c818058", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f251d3bc9973659823948932b5a7f75287268866", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LevenshteinDistanceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LevenshteinDistanceCriteriaPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LevenshteinTableResultPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LevenshteinDistanceTokenPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\A_Workarea\Local_Repository_Git\dot_net_stack\GLEAC-DEMO-ON-LD\Gleac.Anand.Web.Levenshtein.Distance\Gleac.Anand.Web.App.Levenshtein.Distance\Views\Home\Index.cshtml"
  

    string sessionJwtToken = null;
    ViewData["Title"] = "Calulating Levenshtein Distance";
    if(ViewData["JWTToken"] != null)
    {
        sessionJwtToken = ViewData["JWTToken"].ToString();
    }


#line default
#line hidden
#line 13 "C:\A_Workarea\Local_Repository_Git\dot_net_stack\GLEAC-DEMO-ON-LD\Gleac.Anand.Web.Levenshtein.Distance\Gleac.Anand.Web.App.Levenshtein.Distance\Views\Home\Index.cshtml"
 if(!string.IsNullOrEmpty(sessionJwtToken)){ 

#line default
#line hidden
            BeginContext(305, 128, true);
            WriteLiteral("    <!--- LevenshteinDistance criteria Section-->\r\n    <section id=\"LDSection\">\r\n        <!-- Area for partial page-->\r\n        ");
            EndContext();
            BeginContext(433, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ce080407d4fc46ffbc05bd13a41e7fbb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 17 "C:\A_Workarea\Local_Repository_Git\dot_net_stack\GLEAC-DEMO-ON-LD\Gleac.Anand.Web.Levenshtein.Distance\Gleac.Anand.Web.App.Levenshtein.Distance\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.StringsAsCriteria;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(518, 143, true);
            WriteLiteral("\r\n    </section>\r\n    <!--- LevenshteinDistance result Section-->\r\n    <section id=\"LDResult\">\r\n        <!-- Area for partial page-->\r\n        ");
            EndContext();
            BeginContext(661, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66625e8229504d95a25381aa905a605a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 22 "C:\A_Workarea\Local_Repository_Git\dot_net_stack\GLEAC-DEMO-ON-LD\Gleac.Anand.Web.Levenshtein.Distance\Gleac.Anand.Web.App.Levenshtein.Distance\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(723, 18, true);
            WriteLiteral("\r\n    </section>\r\n");
            EndContext();
#line 24 "C:\A_Workarea\Local_Repository_Git\dot_net_stack\GLEAC-DEMO-ON-LD\Gleac.Anand.Web.Levenshtein.Distance\Gleac.Anand.Web.App.Levenshtein.Distance\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(753, 123, true);
            WriteLiteral("    <!--- LevenshteinDistance token Section-->\r\n    <section id=\"LDToken\">\r\n        <!-- Area for partial page-->\r\n        ");
            EndContext();
            BeginContext(876, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8384a2488a8e414fad8180969fed5b16", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(926, 20, true);
            WriteLiteral("\r\n\r\n    </section>\r\n");
            EndContext();
#line 33 "C:\A_Workarea\Local_Repository_Git\dot_net_stack\GLEAC-DEMO-ON-LD\Gleac.Anand.Web.Levenshtein.Distance\Gleac.Anand.Web.App.Levenshtein.Distance\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(949, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(969, 180, true);
                WriteLiteral("   \r\n<script type=\"text/javascript\">\r\n    $(document).ready(function () {\r\n        console.log(\'Jquery is working\');\r\n        ComputeLevenDist.init();\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LevenshteinDistanceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
