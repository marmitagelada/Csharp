#pragma checksum "C:\Users\35711103822\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5670d79b7fb2fb026e6bbf9814f51c1e213b1d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listar), @"mvc.1.0.view", @"/Views/Usuario/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Listar.cshtml", typeof(AspNetCore.Views_Usuario_Listar))]
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
#line 2 "C:\Users\35711103822\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Listar.cshtml"
using Senai.Financas.Mvc.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5670d79b7fb2fb026e6bbf9814f51c1e213b1d8", @"/Views/Usuario/Listar.cshtml")]
    public class Views_Usuario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\35711103822\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Listar.cshtml"
  
    Layout = "MasterPageDeslogado";

#line default
#line hidden
            BeginContext(85, 33, true);
            WriteLiteral("<h3>Listagem de Usuários</h3>\r\n\r\n");
            EndContext();
            BeginContext(119, 20, false);
#line 8 "C:\Users\35711103822\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Listar.cshtml"
Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(139, 179, true);
            WriteLiteral("\r\n\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <td>Nome</td>\r\n            <td>E-mail</td>\r\n            <td>Data de nascimento</td>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 19 "C:\Users\35711103822\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Listar.cshtml"
         foreach(UsuarioModel usuario in ViewData["Usuarios"] as List<UsuarioModel>)
        {

#line default
#line hidden
            BeginContext(415, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(476, 12, false);
#line 23 "C:\Users\35711103822\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Listar.cshtml"
               Write(usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(488, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(556, 13, false);
#line 26 "C:\Users\35711103822\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Listar.cshtml"
               Write(usuario.Email);

#line default
#line hidden
            EndContext();
            BeginContext(569, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(637, 42, false);
#line 29 "C:\Users\35711103822\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Listar.cshtml"
               Write(usuario.DataNascimento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(679, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 748, "\"", 786, 2);
            WriteAttributeValue("", 755, "/Usuario/Excluir?id=", 755, 20, true);
#line 32 "C:\Users\35711103822\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 775, usuario.ID, 775, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(787, 36, true);
            WriteLiteral(">Excluir</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 823, "\"", 860, 2);
            WriteAttributeValue("", 830, "/Usuario/Editar?id=", 830, 19, true);
#line 33 "C:\Users\35711103822\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 849, usuario.ID, 849, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(861, 55, true);
            WriteLiteral(">Editar</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 36 "C:\Users\35711103822\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Listar.cshtml"
        }

#line default
#line hidden
            BeginContext(927, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(1004, 12, true);
            WriteLiteral("\r\n<select>\r\n");
            EndContext();
#line 43 "C:\Users\35711103822\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Listar.cshtml"
     foreach (UsuarioModel usuario in ViewData["Usuarios"] as List<UsuarioModel>)
    {

#line default
#line hidden
            BeginContext(1106, 30, true);
            WriteLiteral("        <option>\r\n            ");
            EndContext();
            BeginContext(1137, 12, false);
#line 46 "C:\Users\35711103822\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Listar.cshtml"
       Write(usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1149, 21, true);
            WriteLiteral("\r\n        </option>\r\n");
            EndContext();
#line 48 "C:\Users\35711103822\Desktop\Senai_Financas_Web_Mvc_Tarde\Views\Usuario\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(1177, 11, true);
            WriteLiteral("</select>\r\n");
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
