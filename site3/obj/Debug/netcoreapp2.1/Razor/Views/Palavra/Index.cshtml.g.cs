#pragma checksum "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3e4b57f990019a62985a6abcc01013940e5d56a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Palavra_Index), @"mvc.1.0.view", @"/Views/Palavra/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Palavra/Index.cshtml", typeof(AspNetCore.Views_Palavra_Index))]
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
#line 3 "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 4 "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3e4b57f990019a62985a6abcc01013940e5d56a", @"/Views/Palavra/Index.cshtml")]
    public class Views_Palavra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<site3.Models.Palavra>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(107, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 7 "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(143, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml"
  
    ViewBag.Title = "Palavra - Listagem";

#line default
#line hidden
            BeginContext(195, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml"
 if (TempData["Mensagem"] != null)
{

#line default
#line hidden
            BeginContext(236, 60, true);
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(297, 20, false);
#line 18 "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(317, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 20 "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml"
}

#line default
#line hidden
            BeginContext(334, 185, true);
            WriteLiteral("\r\n\r\n<link href=\"/css/PagedList.css\" rel=\"stylesheet\" type=\"text/css\" />\r\n\r\n\r\n<a href=\"/palavra/cadastrar/1\" class=\"btn btn-primary\">Cadastrar</a>\r\n\r\n<span> <b> Total de registros: </b> ");
            EndContext();
            BeginContext(520, 20, false);
#line 28 "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml"
                               Write(Model.TotalItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(540, 280, true);
            WriteLiteral(@" </span>
<table class=""table"">
    <thead class=""table-dark"">
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Palavra</th>
            <th scope=""col"">Nivel</th>
            <th scope=""col"">A????o</th>
        </tr>
    </thead>
    <tbody>

");
            EndContext();
#line 40 "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml"
         foreach (var palavra in Model)
        {


#line default
#line hidden
            BeginContext(874, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(925, 10, false);
#line 44 "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml"
                           Write(palavra.Id);

#line default
#line hidden
            EndContext();
            BeginContext(935, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(963, 12, false);
#line 45 "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml"
               Write(palavra.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(975, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1003, 13, false);
#line 46 "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml"
               Write(palavra.Nivel);

#line default
#line hidden
            EndContext();
            BeginContext(1016, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1067, "\"", 1104, 2);
            WriteAttributeValue("", 1074, "/palavra/atualizar/", 1074, 19, true);
#line 48 "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml"
WriteAttributeValue("", 1093, palavra.Id, 1093, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1105, 47, true);
            WriteLiteral(" class=\"btn\">Editar</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1152, "\"", 1186, 2);
            WriteAttributeValue("", 1159, "/palavra/exluir/", 1159, 16, true);
#line 49 "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml"
WriteAttributeValue("", 1175, palavra.Id, 1175, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1187, 68, true);
            WriteLiteral(" class=\"btn\">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 52 "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1266, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(1293, 81, false);
#line 56 "C:\Users\David\source\repos\site3\site3\Views\Palavra\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<site3.Models.Palavra>> Html { get; private set; }
    }
}
#pragma warning restore 1591
