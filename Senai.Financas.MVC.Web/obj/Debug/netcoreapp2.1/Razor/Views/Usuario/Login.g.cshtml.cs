#pragma checksum "C:\Users\35711103822\Desktop\Senai.Financas.MVC.Web\Views\Usuario\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3071c677a56cfd332d493a41ab796e060f4458b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Login), @"mvc.1.0.view", @"/Views/Usuario/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Login.cshtml", typeof(AspNetCore.Views_Usuario_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3071c677a56cfd332d493a41ab796e060f4458b2", @"/Views/Usuario/Login.cshtml")]
    public class Views_Usuario_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 57, true);
            WriteLiteral("    <link href=\"/css/login.css\" rel=\"stylesheet\">\r\n    \r\n");
            EndContext();
#line 3 "C:\Users\35711103822\Desktop\Senai.Financas.MVC.Web\Views\Usuario\Login.cshtml"
      
        Layout = "MasterPageDeslogado";
    

#line default
#line hidden
            BeginContext(113, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(120, 16, false);
#line 7 "C:\Users\35711103822\Desktop\Senai.Financas.MVC.Web\Views\Usuario\Login.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(136, 438, true);
            WriteLiteral(@"
    
    <h1>Login</h1>

    <form action=""/Usuario/Login"" method=""POST"">
        <label class=""cor-amarela"">
            E-mail
            <input type=""email"" name=""email""
            required maxlength=""80"">
        </label>

        <label>
            Senha
            <input type=""password"" name=""senha""
            required maxlength=""50"">
        </label>

        <button>Entrar no sitema</button>
    </form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591