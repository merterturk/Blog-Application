#pragma checksum "C:\Users\merturk\Desktop\Blog\BlogApp\BlogApp.Web\Areas\Admin\Views\Shared\LayoutPartials\_LayoutCssPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29ff047a9036fdb216035897695e8b200ebbfb36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_LayoutPartials__LayoutCssPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/LayoutPartials/_LayoutCssPartial.cshtml")]
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
#line 2 "C:\Users\merturk\Desktop\Blog\BlogApp\BlogApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BlogApp.Entities.Dtos.UsersDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\merturk\Desktop\Blog\BlogApp\BlogApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BlogApp.Entities.Dtos.ArticlesDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\merturk\Desktop\Blog\BlogApp\BlogApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BlogApp.Entities.Dtos.CategoriesDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\merturk\Desktop\Blog\BlogApp\BlogApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BlogApp.Entities.Dtos.CommentsDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\merturk\Desktop\Blog\BlogApp\BlogApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BlogApp.Entities.Dtos.RolesDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29ff047a9036fdb216035897695e8b200ebbfb36", @"/Areas/Admin/Views/Shared/LayoutPartials/_LayoutCssPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a89f5125a5d352a46855428641978b11f9ae614", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_LayoutPartials__LayoutCssPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "29ff047a9036fdb216035897695e8b200ebbfb364655", async() => {
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
            WriteLiteral(@"
<link href=""https://cdn.datatables.net/1.10.21/css/dataTables.bootstrap4.min.css"" rel=""stylesheet"" crossorigin=""anonymous"" />
<script src=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/js/all.min.js"" crossorigin=""anonymous""></script>
<link href=""https://cdn.datatables.net/buttons/1.6.3/css/buttons.bootstrap4.min.css"" rel=""stylesheet"" crossorigin=""anonymous"" />
<link href=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.css"" rel=""stylesheet"" crossorigin=""anonymous"" />


");
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
