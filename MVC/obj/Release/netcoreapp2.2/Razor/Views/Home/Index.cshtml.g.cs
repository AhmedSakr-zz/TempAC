#pragma checksum "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d19f32114fa88ff47caa7dfa26c75f1caa761f1"
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
#line 1 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#line 2 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#line 6 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
using ui.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d19f32114fa88ff47caa7dfa26c75f1caa761f1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ui.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
  
  ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(104, 425, true);
            WriteLiteral(@"


<!-- Button trigger modal -->
<button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
  Filter
</button>

<span id=""span_FilterMessage"" class="" alert-primary""></span>
<br />
<br />
<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">

");
            EndContext();
            BeginContext(2116, 439, true);
            WriteLiteral(@"


    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Filter</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <div class=""form-group"">
          <label for=""CustomerId"">Customer</label>
          ");
            EndContext();
            BeginContext(2555, 285, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d19f32114fa88ff47caa7dfa26c75f1caa761f16678", async() => {
                BeginContext(2605, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2619, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d19f32114fa88ff47caa7dfa26c75f1caa761f17076", async() => {
                    BeginContext(2637, 15, true);
                    WriteLiteral("Select customer");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2661, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 74 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
             foreach (var customer in Model.Customers)
            {

#line default
#line hidden
                BeginContext(2734, 14, true);
                WriteLiteral("              ");
                EndContext();
                BeginContext(2748, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d19f32114fa88ff47caa7dfa26c75f1caa761f18907", async() => {
                    BeginContext(2778, 17, false);
#line 76 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
                                      Write(customer.FullName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 76 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
                 WriteLiteral(customer.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2804, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 77 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(2821, 10, true);
                WriteLiteral("          ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 72 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2840, 110, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n          <label for=\"StatusId\">Status</label>\r\n          ");
            EndContext();
            BeginContext(2950, 226, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d19f32114fa88ff47caa7dfa26c75f1caa761f112820", async() => {
                BeginContext(2998, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(3012, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d19f32114fa88ff47caa7dfa26c75f1caa761f113219", async() => {
                    BeginContext(3030, 13, true);
                    WriteLiteral("Select status");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3052, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(3066, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d19f32114fa88ff47caa7dfa26c75f1caa761f114705", async() => {
                    BeginContext(3084, 9, true);
                    WriteLiteral("Connected");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3102, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(3116, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d19f32114fa88ff47caa7dfa26c75f1caa761f116186", async() => {
                    BeginContext(3134, 12, true);
                    WriteLiteral("Disconnected");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3155, 12, true);
                WriteLiteral("\r\n          ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 82 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StatusId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3176, 764, true);
            WriteLiteral(@"
        </div>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary"" id=""btn_Filter"" data-dismiss=""modal"">Filter</button>
        <input type=""hidden"" id=""hiden_CustomerId"" />
        <input type=""hidden"" id=""hiden_StatusId"" />
      </div>
    </div>
  </div>
</div>

<table id=""tbl_Cars"" class=""table table-striped"">
  <thead>
    <tr>
      <th>
        Customer Name
      </th>
      <th>
        Customer Address
      </th>
      <th>
        Vehicle Id
      </th>
      <th>
        Reregistration No
      </th>
      <th>
        Status
      </th>
    </tr>
  </thead>
  <tbody>
");
            EndContext();
#line 120 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
      
      foreach (CarForReturnDto car in Model.Cars)
      {
        var cssClass = car.Status == "Connected" ? "alert-success" : "alert-danger";

#line default
#line hidden
            BeginContext(4094, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4105, "\"", 4124, 2);
            WriteAttributeValue("", 4110, "tr", 4110, 2, true);
#line 124 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4112, car.CarId, 4112, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4125, 17, true);
            WriteLiteral(">\r\n          <td>");
            EndContext();
            BeginContext(4143, 16, false);
#line 125 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
         Write(car.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(4159, 21, true);
            WriteLiteral("</td>\r\n          <td>");
            EndContext();
            BeginContext(4181, 19, false);
#line 126 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
         Write(car.CustomerAddress);

#line default
#line hidden
            EndContext();
            BeginContext(4200, 21, true);
            WriteLiteral("</td>\r\n          <td>");
            EndContext();
            BeginContext(4222, 13, false);
#line 127 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
         Write(car.VehicleId);

#line default
#line hidden
            EndContext();
            BeginContext(4235, 21, true);
            WriteLiteral("</td>\r\n          <td>");
            EndContext();
            BeginContext(4257, 9, false);
#line 128 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
         Write(car.RegNo);

#line default
#line hidden
            EndContext();
            BeginContext(4266, 40, true);
            WriteLiteral("</td>\r\n          <td>\r\n            <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4306, "\"", 4323, 1);
#line 130 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4314, cssClass, 4314, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4324, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(4327, 10, false);
#line 130 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
                                Write(car.Status);

#line default
#line hidden
            EndContext();
            BeginContext(4337, 41, true);
            WriteLiteral("</span>\r\n            <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4378, "\"", 4396, 1);
#line 131 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4386, car.CarId, 4386, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4397, 37, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4434, "\"", 4457, 1);
#line 132 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4442, car.CustomerId, 4442, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4458, 37, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4495, "\"", 4516, 1);
#line 133 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4503, car.StatusId, 4503, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4517, 39, true);
            WriteLiteral(" />\r\n          </td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 137 "E:\Applications\OtherApplications\AhmedSakr.VisualStudio.net\AltenChanlenge\V2\vehicles\MVC\Views\Home\Index.cshtml"
      }
    

#line default
#line hidden
            BeginContext(4572, 25, true);
            WriteLiteral("  <tbody>\r\n\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4614, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(4618, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d19f32114fa88ff47caa7dfa26c75f1caa761f125143", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4678, 3288, true);
                WriteLiteral(@"
  <script type=""text/javascript"">
    $(function () {

      $(""#btn_Filter"").click(function () {

        //filter options
        var $filterCustomerId = $(""#CustomerId"").val();
        var $filrerStatusId = $(""#StatusId"").val();

        // update filter message
        $(""#span_FilterMessage"").html("""");
        var $filterMessage = """";
        if ($filrerStatusId != 0) {
          $filterMessage = ""Filtered by status = "" +$(""#StatusId option:selected"").text();
        }
        if ($filterCustomerId != 0) {
          if ($filrerStatusId != 0) {
            $filterMessage += "" and customer = "" + $(""#CustomerId option:selected"").text();
          } else {
            $filterMessage =""Filtered by customer = "" + $(""#CustomerId option:selected"").text();
          }

        }
        $(""#span_FilterMessage"").html($filterMessage);

        //fetching car tables to show only cars match filter options
        $('#tbl_Cars > tbody tr').each(function () {

          // car status Id
 ");
                WriteLiteral(@"         var $carStatusId = $(this).find('input').eq(2).val();

          //car customer Id
          var $carCustomerId = $(this).find('input').eq(1).val();

          //show or hide car row based on filter options
          if (($carStatusId == $filrerStatusId || $filrerStatusId == 0) && ($carCustomerId == $filterCustomerId || $filterCustomerId == 0)) {
            $(this).show();
          } else {
            $(this).hide();
          }

        });

      });
      //Connect to server hub: eventHub, transport type default would be: websocket
      var connection = new signalR.HubConnectionBuilder()
        .withUrl(""/eventHub"")
        .build();

      //Hook callback for listening message from server side
      connection.on(""SendNoticeEventToClient"",
        function (message) {

          //filter options
          var $filterCustomerId = $(""#CustomerId"").val();
          var $filrerStatusId = $(""#StatusId"").val();

          //car status object
          var $carStatusObj");
                WriteLiteral(@" = jQuery.parseJSON(message);

          //car tr Id
          var $carRow = ""#tr"" + $carStatusObj.CarId;

          //car status test
          var $status = $carStatusObj.StatusId === 1 ? ""Connected"" : ""Disconnected"";

          //car status cssClass
          var $cssClass = $carStatusObj.StatusId === 1 ? ""alert-success"" : ""alert-danger"";

          //car customer Id
          var $carCustomerId = $($carRow).find('input').eq(1).val();

          //change car status text and cssClass on cars table
          $($carRow).find('span').html($status).removeClass(""alert-success alert-danger"").addClass($cssClass).hide().fadeIn(""6000"");

          //update status Id
          $($carRow).find('input').eq(2).val($carStatusObj.StatusId);

          //show or hide car row based on filter options
          if (($carStatusObj.StatusId == $filrerStatusId || $filrerStatusId == 0) && ($carCustomerId == $filterCustomerId || $filterCustomerId == 0)) {

            $($carRow).show();
          } else {
");
                WriteLiteral("            $($carRow).hide();\r\n          }\r\n\r\n        });\r\n\r\n      //error logging\r\n      connection.start().catch(function (err) {\r\n        return console.error(err.toString());\r\n      });\r\n\r\n    });\r\n  </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ui.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
