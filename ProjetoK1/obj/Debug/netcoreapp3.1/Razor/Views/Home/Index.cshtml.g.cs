#pragma checksum "C:\Users\abrah\Desktop\Projeto-K1-main\Projeto-K1-main\ProjetoK1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4754e4e61948db84552b9875d97e11530fc0eb60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\abrah\Desktop\Projeto-K1-main\Projeto-K1-main\ProjetoK1\Views\_ViewImports.cshtml"
using ProjetoK1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abrah\Desktop\Projeto-K1-main\Projeto-K1-main\ProjetoK1\Views\_ViewImports.cshtml"
using ProjetoK1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\abrah\Desktop\Projeto-K1-main\Projeto-K1-main\ProjetoK1\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4754e4e61948db84552b9875d97e11530fc0eb60", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b962a817af635ec60093b64b9fcf4ea0b9947d20", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\abrah\Desktop\Projeto-K1-main\Projeto-K1-main\ProjetoK1\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-inicio text-center\">\n    <h3 class=\"display-4\">Projeto K</h3>\n    <br />\n    <p>\n        Aplicação para Cadastro de Produtos e Gestão de Estoque:<br />\n        <hr />\n    </p>\n</div>\n\n");
#nullable restore
#line 16 "C:\Users\abrah\Desktop\Projeto-K1-main\Projeto-K1-main\ProjetoK1\Views\Home\Index.cshtml"
 if (!SignInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\" style=\"padding-top:100px;\">\n\n    <h5><b> Cadastre-se ou faça Login para começar. </b></h5>\n</div>\n");
#nullable restore
#line 22 "C:\Users\abrah\Desktop\Projeto-K1-main\Projeto-K1-main\ProjetoK1\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
