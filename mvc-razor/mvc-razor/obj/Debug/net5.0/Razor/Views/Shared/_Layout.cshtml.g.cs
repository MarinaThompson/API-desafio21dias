#pragma checksum "C:\Users\marin\Desktop\desafio21dias\mvc-razor\mvc-razor\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66ef7610f70744fd2e522f74fea72f06d275e1a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\marin\Desktop\desafio21dias\mvc-razor\mvc-razor\Views\_ViewImports.cshtml"
using mvc_razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marin\Desktop\desafio21dias\mvc-razor\mvc-razor\Views\_ViewImports.cshtml"
using mvc_razor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66ef7610f70744fd2e522f74fea72f06d275e1a7", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb749d80e789bd672d233ba72c72fd1013618ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ef7610f70744fd2e522f74fea72f06d275e1a73910", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta name=""description"" content=""Creative - Bootstrap 3 Responsive Admin Template"">
    <meta name=""author"" content=""GeeksLabs"">
    <meta name=""keyword"" content=""Creative, Dashboard, Admin, Template, Theme, Bootstrap, Responsive, Retina, Minimal"">
    <link rel=""shortcut icon"" href=""img/favicon.png"">

    <title>");
#nullable restore
#line 12 "C:\Users\marin\Desktop\desafio21dias\mvc-razor\mvc-razor\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - Desafio 21 dias C# API</title>

    <!-- Bootstrap CSS -->
    <link href=""/css/bootstrap.min.css"" rel=""stylesheet"">
    <!-- bootstrap theme -->
    <link href=""/css/bootstrap-theme.css"" rel=""stylesheet"">
    <!--external css-->
    <!-- font icon -->
    <link href=""/css/elegant-icons-style.css"" rel=""stylesheet"" />
    <link href=""/css/font-awesome.min.css"" rel=""stylesheet"" />
    <!-- full calendar css-->
    <link href=""/assets/fullcalendar/fullcalendar/bootstrap-fullcalendar.css"" rel=""stylesheet"" />
    <link href=""/assets/fullcalendar/fullcalendar/fullcalendar.css"" rel=""stylesheet"" />
    <!-- easy pie chart-->
    <link href=""/assets/jquery-easy-pie-chart/jquery.easy-pie-chart.css"" rel=""stylesheet"" type=""text/css"" media=""screen"" />
    <!-- owl carousel -->
    <link rel=""stylesheet"" href=""/css/owl.carousel.css"" type=""text/css"">
    <link href=""/css/jquery-jvectormap-1.2.2.css"" rel=""stylesheet"">
    <!-- Custom styles -->
    <link rel=""stylesheet"" href=""/css/fullcalendar.css"">
 ");
                WriteLiteral(@"   <link href=""/css/widgets.css"" rel=""stylesheet"">
    <link href=""/css/style.css"" rel=""stylesheet"">
    <link href=""/css/style-responsive.css"" rel=""stylesheet"" />
    <link href=""/css/xcharts.min.css"" rel="" stylesheet"">
    <link href=""/css/jquery-ui-1.10.4.min.css"" rel=""stylesheet"">
    <!-- =======================================================
      Theme Name: NiceAdmin
      Theme URL: https://bootstrapmade.com/nice-admin-bootstrap-admin-html-template/
      Author: BootstrapMade
      Author URL: https://bootstrapmade.com
    ======================================================= -->
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ef7610f70744fd2e522f74fea72f06d275e1a77302", async() => {
                WriteLiteral("\r\n    <!-- container section start -->\r\n    <section id=\"container\"");
                BeginWriteAttribute("class", " class=\"", 2211, "\"", 2219, 0);
                EndWriteAttribute();
                WriteLiteral(@">


        <header class=""header dark-bg"">
            <div class=""toggle-nav"">
                <div class=""icon-reorder tooltips"" data-original-title=""Toggle Navigation"" data-placement=""bottom""><i class=""icon_menu""></i></div>
            </div>

            <!--logo start-->
            <a href=""/"" class=""logo"">Desafio 21 dias C# API <span class=""lite"">Admin</span></a>
            <!--logo end-->

            <div class=""nav search-row"" id=""top_menu"">
                <!--  search form start -->
                <ul class=""nav top-menu"">
                    <li>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ef7610f70744fd2e522f74fea72f06d275e1a78417", async() => {
                    WriteLiteral("\r\n                            <input class=\"form-control\" placeholder=\"Search\" type=\"text\">\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </li>
                </ul>
                <!--  search form end -->
            </div>

            <div class=""top-nav notification-row"">
                <!-- notificatoin dropdown start-->
                <ul class=""nav pull-right top-menu"">
                    <!-- user login dropdown start-->
                    <li class=""dropdown"">
                        <a data-toggle=""dropdown"" class=""dropdown-toggle"" href=""#"">
                            <span class=""profile-ava"">
                                <img");
                BeginWriteAttribute("alt", " alt=\"", 3530, "\"", 3536, 0);
                EndWriteAttribute();
                WriteLiteral(" src=\"/img/avatar1_small.jpg\">\r\n                            </span>\r\n                            <span class=\"username\">");
#nullable restore
#line 80 "C:\Users\marin\Desktop\desafio21dias\mvc-razor\mvc-razor\Views\Shared\_Layout.cshtml"
                                              Write(TempData["usuarioLogado"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                            <b class=""caret""></b>
                        </a>
                        <ul class=""dropdown-menu extended logout"">
                            <div class=""log-arrow-up""></div>
                            <li class=""eborder-top"">
                                <a href=""/administradores/1/editar""><i class=""icon_profile""></i> Editar perfil</a>
                            </li>
                            <li>
                                <a href=""/login/sair""><i class=""icon_key_alt""></i> Sair</a>
                            </li>
                        </ul>
                    </li>
                    <!-- user login dropdown end -->
                </ul>
                <!-- notificatoin dropdown end-->
            </div>
        </header>
        <!--header end-->
        <!--sidebar start-->
        <aside>
            <div id=""sidebar"" class=""nav-collapse "">
                <!-- sidebar menu start-->
                <ul class=""sidebar-menu""");
                WriteLiteral(">\r\n                    <li class=\"active\">\r\n                        <a");
                BeginWriteAttribute("class", " class=\"", 4777, "\"", 4785, 0);
                EndWriteAttribute();
                WriteLiteral(@" href=""/"">
                            <i class=""icon_house_alt""></i>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""sub-menu"">
                        <a href=""javascript:;""");
                BeginWriteAttribute("class", " class=\"", 5056, "\"", 5064, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <i class=""icon_document_alt""></i>
                            <span>Administra????o</span>
                            <span class=""menu-arrow arrow_carrot-right""></span>
                        </a>
                        <ul class=""sub"">
                            <li><a href=""/administradores""><i class=""icon_table""></i>Administradores</a></li>
                            <li><a href=""/login/sair""><i class=""icon_key_alt""></i>Sair</a></li>
                        </ul>
                    <li><a href=""/alunos""><i class=""icon_table""></i>Alunos</a></li>
                    <li><a href=""/materiais""><i class=""icon_table""></i>Materiais</a></li>
                    <li><a href=""/pais""><i class=""icon_table""></i>Pais</a></li>
                    </li>
                </ul>
                <!-- sidebar menu end-->
            </div>
        </aside>
        <!--sidebar end-->
        <!--main content start-->
        <section id=""main-content"">
            <section cl");
                WriteLiteral(@"ass=""wrapper"">
                <!--overview start-->
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <h3 class=""page-header""><i class=""fa fa-laptop""></i> Dashboard</h3>
                        <ol class=""breadcrumb"">
                            <li><i class=""fa fa-home""></i><a href=""/"">Home</a></li>
                            <li><i class=""fa fa-laptop""></i>Dashboard</li>
                        </ol>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <section class=""panel"" style=""padding: 20px"">
                            ");
#nullable restore
#line 145 "C:\Users\marin\Desktop\desafio21dias\mvc-razor\mvc-razor\Views\Shared\_Layout.cshtml"
                       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </section>
                    </div>
                </div>
            </section>
            <div class=""text-right"">
                <div class=""credits"">
                    Designed by <a href=""https://bootstrapmade.com/"">BootstrapMade</a>
                </div>
            </div>
        </section>
        <!--main content end-->
    </section>
    <!-- container section start -->
    <!-- javascripts -->
    <script src=""/js/jquery.js""></script>
    <script src=""/js/jquery-ui-1.10.4.min.js""></script>
    <script src=""/js/jquery-1.8.3.min.js""></script>
    <script type=""text/javascript"" src=""/js/jquery-ui-1.9.2.custom.min.js""></script>
    <!-- bootstrap -->
    <script src=""/js/bootstrap.min.js""></script>
    <!-- nice scroll -->
    <script src=""/js/jquery.scrollTo.min.js""></script>
    <script src=""/js/jquery.nicescroll.js"" type=""text/javascript""></script>
    <!-- charts scripts -->
    <script src=""assets/jquery-knob/js/jquery.knob.js""></script>
 ");
                WriteLiteral(@"   <script src=""/js/jquery.sparkline.js"" type=""text/javascript""></script>
    <!-- jQuery full calendar -->
    <!-- Full Google Calendar - Calendar -->
    <!--script for this page only-->
    <script src=""/js/calendar-custom.js""></script>
    <script src=""/js/jquery.rateit.min.js""></script>
    <!-- custom select -->
    <script src=""/js/jquery.customSelect.min.js""></script>

    <!--custome script for all page-->
    <script src=""/js/scripts.js""></script>
    <!-- custom script for this page-->
    <script src=""/js/jquery.placeholder.min.js""></script>
    <script src=""/js/jquery.slimscroll.min.js""></script>
    <script>
      //knob
      $(function() {
        $("".knob"").knob({
          'draw': function() {
            $(this.i).val(this.cv + '%')
          }
        })
      });
      //carousel
      $(document).ready(function() {
        $(""#owl-slider"").owlCarousel({
          navigation: true,
          slideSpeed: 300,
          paginationSpeed: 400,
          singleIte");
                WriteLiteral(@"m: true
        });
      });
      //custom select box
      $(function() {
        $('select.styled').customSelect();
      });
      /* ---------- Map ---------- */
      $(function() {
        $('#map').vectorMap({
          map: 'world_mill_en',
          series: {
            regions: [{
              values: gdpData,
              scale: ['#000', '#000'],
              normalizeFunction: 'polynomial'
            }]
          },
          backgroundColor: '#eef3f7',
          onLabelShow: function(e, el, code) {
            el.html(el.html() + ' (GDP - ' + gdpData[code] + ')');
          }
        });
      });
    </script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
