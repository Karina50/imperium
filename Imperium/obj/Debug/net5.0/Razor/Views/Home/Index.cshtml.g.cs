#pragma checksum "D:\Aps\WEB\from_diego\Imperium\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc576da5b3b103eaf0641dedb18c761f0139f738"
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
#line 1 "D:\Aps\WEB\from_diego\Imperium\Views\_ViewImports.cshtml"
using Imperium;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Aps\WEB\from_diego\Imperium\Views\_ViewImports.cshtml"
using Imperium.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc576da5b3b103eaf0641dedb18c761f0139f738", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbe9314605280a8c13ae5fbdfde02741eb5c7514", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Imperium.Models.RegistroUser>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Aps\WEB\from_diego\Imperium\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div id=""carousel"" class=""carousel slide"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
        <li data-target=""#carousel"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#carousel"" data-slide-to=""1""></li>
        <li data-target=""#carousel"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"">
        <div class=""carousel-item active"">
            <img src=""/Imagenes/new_images/carousel-1.jpg"" alt=""Carousel Image"">
            <div class=""carousel-caption"">
                <p class=""animated fadeInRight"">Vendedores profecionales</p>
                <h1 class=""animated fadeInLeft"">Encuentra lo que necesites</h1>

            </div>
        </div>

        <div class=""carousel-item"">
            <img src=""/Imagenes/new_images/carousel-2.jpg"" alt=""Carousel Image"">
            <div class=""carousel-caption"">
                <p class=""animated fadeInRight"">Compradores justos</p>
                <h1 class=""animated fadeInLeft"">Organizate con nosot");
            WriteLiteral(@"ros</h1>

            </div>
        </div>

        <div class=""carousel-item"">
            <img src=""/Imagenes/new_images/carousel-3.jpg"" alt=""Carousel Image"">
            <div class=""carousel-caption"">
                <p class=""animated fadeInRight"">Rentadores confiables</p>
                <h1 class=""animated fadeInLeft"">Contamos con excelentes hogares</h1>

            </div>
        </div>
    </div>

    <a class=""carousel-control-prev"" href=""#carousel"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Anterior</span>
    </a>
    <a class=""carousel-control-next"" href=""#carousel"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Siguiente</span>
    </a>
</div>
<!-- Carousel End -->
<!-- About Start -->
<div class=""about wow fadeInUp"" data-wow-delay=""0.1s"">
    <div class=""container"">
        <div cl");
            WriteLiteral(@"ass=""row align-items-center"">
            <div class=""col-lg-5 col-md-6"">
                <div class=""about-img"">
                    <img src=""/Imagenes/new_images/about.jpg"" alt=""Image"">
                </div>
            </div>
            <div class=""col-lg-7 col-md-6"">
                <div class=""section-header text-left"">
                    <p>Bienvenido a IMPERIUM</p>
                    <h2>25 años de experiencia</h2>
                </div>
                <div class=""about-text"">
                    <p>
                        Somos una empresa dedicada al apasionante mundo de la compra, venta y renta de
                        propiedades, con el objetivo principal de facilitar y garantizar un proceso de
                        urbanización eficiente y satisfactorio. Nuestra misión consiste en brindar soluciones
                        integrales y personalizadas a nuestros clientes, asegurando que encuentren la propiedad
                        perfecta que se ajuste a sus necesid");
            WriteLiteral(@"ades y deseos, ya sea para vivir, invertir o
                        desarrollar proyectos inmobiliarios.
                    </p>
                    <p>
                        Contamos con un equipo altamente calificado y comprometido, conformado por expertos en
                        el mercado inmobiliario, agentes de bienes raíces, abogados y especialistas en
                        financiamiento, que se encargan de guiar y asesorar a nuestros clientes en cada etapa
                        del proceso. Nos enorgullece mantenernos actualizados sobre las últimas tendencias y
                        regulaciones en el sector, lo que nos permite brindar un servicio de vanguardia y
                        adaptado a las necesidades cambiantes del mercado.
                    </p>
                    <a class=""btn"" href=""/Contactoes/Create"">Conoce más</a>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- About End -->
<!-- Fact Start -->
<div class=""fact"">
 ");
            WriteLiteral(@"   <div class=""container-fluid"">
        <div class=""row counters"">
            <div class=""col-md-6 fact-left wow slideInLeft"">
                <div class=""row"">
                    <div class=""col-6"">
                        <div class=""fact-icon"">
                            <i class=""flaticon-worker""></i>
                        </div>
                        <div class=""fact-text"">
                            <h2 data-toggle=""counter-up"">102</h2>
                            <p>Trabajadores expertos</p>
                        </div>
                    </div>
                    <div class=""col-6"">
                        <div class=""fact-icon"">
                            <i class=""flaticon-building""></i>
                        </div>
                        <div class=""fact-text"">
                            <h2 data-toggle=""counter-up"">244</h2>
                            <p>Clientes satisfechos</p>
                        </div>
                    </div>
                </div>");
            WriteLiteral(@"
            </div>
            <div class=""col-md-6 fact-right wow slideInRight"">
                <div class=""row"">
                    <div class=""col-6"">
                        <div class=""fact-icon"">
                            <i class=""flaticon-address""></i>
                        </div>
                        <div class=""fact-text"">
                            <h2 data-toggle=""counter-up"">1078</h2>
                            <p>Proyectos completados</p>
                        </div>
                    </div>
                    <div class=""col-6"">
                        <div class=""fact-icon"">
                            <i class=""flaticon-crane""></i>
                        </div>
                        <div class=""fact-text"">
                            <h2 data-toggle=""counter-up"">259</h2>
                            <p>Proyectos en proceso</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div");
            WriteLiteral(@">
</div>
<!-- Fact End -->
<!-- Service Start -->
<div class=""service"">
    <div class=""container"">
        <div class=""section-header text-center"">
            <p>Nuestros servicios</p>
            <h2>Podemos ofrecerte esto:</h2>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.1s"">
                <div class=""service-item"">
                    <div class=""service-img"">
                        <img src=""/Imagenes/new_images/service-1.jpg"" alt=""Image"">
                        <div class=""service-overlay"">
                            <p>
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus nec pretium
                                mi. Curabitur facilisis ornare velit non vulputate. Aliquam metus tortor, auctor
                                id gravida condimentum, viverra quis sem.
                            </p>
                        </div>
                    </div>
  ");
            WriteLiteral(@"                  <div class=""service-text"">
                        <h3>Building Construction</h3>
                        <a class=""btn"" href=""/Imagenes/new_images/service-1.jpg"" data-lightbox=""service"">+</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.2s"">
                <div class=""service-item"">
                    <div class=""service-img"">
                        <img src=""/Imagenes/new_images/service-2.jpg"" alt=""Image"">
                        <div class=""service-overlay"">
                            <p>
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus nec pretium
                                mi. Curabitur facilisis ornare velit non vulputate. Aliquam metus tortor, auctor
                                id gravida condimentum, viverra quis sem.
                            </p>
                        </div>
                    </div>
");
            WriteLiteral(@"                    <div class=""service-text"">
                        <h3>House Renovation</h3>
                        <a class=""btn"" href=""/Imagenes/new_images/service-2.jpg"" data-lightbox=""service"">+</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.3s"">
                <div class=""service-item"">
                    <div class=""service-img"">
                        <img src=""/Imagenes/new_images/service-3.jpg"" alt=""Image"">
                        <div class=""service-overlay"">
                            <p>
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus nec pretium
                                mi. Curabitur facilisis ornare velit non vulputate. Aliquam metus tortor, auctor
                                id gravida condimentum, viverra quis sem.
                            </p>
                        </div>
                    </div>
   ");
            WriteLiteral(@"                 <div class=""service-text"">
                        <h3>Architecture Design</h3>
                        <a class=""btn"" href=""/Imagenes/new_images/service-3.jpg"" data-lightbox=""service"">+</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.4s"">
                <div class=""service-item"">
                    <div class=""service-img"">
                        <img src=""/Imagenes/new_images/service-4.jpg"" alt=""Image"">
                        <div class=""service-overlay"">
                            <p>
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus nec pretium
                                mi. Curabitur facilisis ornare velit non vulputate. Aliquam metus tortor, auctor
                                id gravida condimentum, viverra quis sem.
                            </p>
                        </div>
                    </div>
   ");
            WriteLiteral(@"                 <div class=""service-text"">
                        <h3>Interior Design</h3>
                        <a class=""btn"" href=""/Imagenes/new_images/service-4.jpg"" data-lightbox=""service"">+</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.5s"">
                <div class=""service-item"">
                    <div class=""service-img"">
                        <img src=""/Imagenes/new_images/service-5.jpg"" alt=""Image"">
                        <div class=""service-overlay"">
                            <p>
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus nec pretium
                                mi. Curabitur facilisis ornare velit non vulputate. Aliquam metus tortor, auctor
                                id gravida condimentum, viverra quis sem.
                            </p>
                        </div>
                    </div>
       ");
            WriteLiteral(@"             <div class=""service-text"">
                        <h3>Fixing & Support</h3>
                        <a class=""btn"" href=""/Imagenes/new_images/service-5.jpg"" data-lightbox=""service"">+</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.6s"">
                <div class=""service-item"">
                    <div class=""service-img"">
                        <img src=""/Imagenes/new_images/service-6.jpg"" alt=""Image"">
                        <div class=""service-overlay"">
                            <p>
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus nec pretium
                                mi. Curabitur facilisis ornare velit non vulputate. Aliquam metus tortor, auctor
                                id gravida condimentum, viverra quis sem.
                            </p>
                        </div>
                    </div>
          ");
            WriteLiteral(@"          <div class=""service-text"">
                        <h3>Painting</h3>
                        <a class=""btn"" href=""/Imagenes/new_images/service-6.jpg"" data-lightbox=""service"">+</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Service End -->
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Imperium.Models.RegistroUser> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
