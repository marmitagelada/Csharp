#pragma checksum "C:\Users\35711103822\Desktop\Senai.Financas.MVC.Web\Views\Transacao\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51bb640abf6ad326c0f8048f0b8f7bf849ed0389"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transacao_Cadastrar), @"mvc.1.0.view", @"/Views/Transacao/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transacao/Cadastrar.cshtml", typeof(AspNetCore.Views_Transacao_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51bb640abf6ad326c0f8048f0b8f7bf849ed0389", @"/Views/Transacao/Cadastrar.cshtml")]
    public class Views_Transacao_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 16, true);
            WriteLiteral("<html>\r\n        ");
            EndContext();
            BeginContext(16, 615, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42082f4f864a437694709b606f03a7a3", async() => {
                BeginContext(22, 602, true);
                WriteLiteral(@"
            <style>
                #formulario {
                    display: flex;
                    flex-direction: column;
                    justify-content: center;
                }

                form {
                    width: 50%;
                    display: flex;
                }

                * {
                    outline: none;
                }

                input, textarea {
                    padding: 10px;
                    border-radius: 20px;
                    border: 1px solid black;
                }
            </style>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(631, 188, true);
            WriteLiteral("\r\n            <h1>Formulário de Cadastro de pintos</h1>\r\n            \r\n            <a href=\"/Usuario/Cadastro\">Cadastrar</a>\r\n            <a href=\"/Usuario/Login\">Logar</a>\r\n\r\n            ");
            EndContext();
            BeginContext(820, 16, false);
#line 31 "C:\Users\35711103822\Desktop\Senai.Financas.MVC.Web\Views\Transacao\Cadastrar.cshtml"
       Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(836, 821, true);
            WriteLiteral(@"

            <section id=""formulario"">

            <form action=""/Transacao/Cadastrar"" method=""POST"">
                <label>
                    Descricao
                    <textarea type=""text"" name=""descricao""></textarea>
                </label>

                <label>
                    Valor
                    <input type=""number"" name=""valor"">
                </label>

                <select>
                    <option value=""despesa"">Despesa</option>
                    <option value=""receita"">Receita</option>
                </select>

                <label>
                    Data
                    <input type=""date"" name=""data"">
                </label>

                <button type=""submit"">Salvar</button>
            </form>
            </section>

</html>");
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
