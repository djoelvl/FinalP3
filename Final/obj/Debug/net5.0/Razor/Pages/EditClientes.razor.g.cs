#pragma checksum "C:\Users\JOEL\Desktop\Final-main\Final\Pages\EditClientes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2444c6d6edb2f0e2ccbebc5fc6c019bb40a1bf1b"
// <auto-generated/>
#pragma warning disable 1591
namespace Final.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\JOEL\Desktop\Final-main\Final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JOEL\Desktop\Final-main\Final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JOEL\Desktop\Final-main\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JOEL\Desktop\Final-main\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JOEL\Desktop\Final-main\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\JOEL\Desktop\Final-main\Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JOEL\Desktop\Final-main\Final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\JOEL\Desktop\Final-main\Final\_Imports.razor"
using Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\JOEL\Desktop\Final-main\Final\_Imports.razor"
using Final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JOEL\Desktop\Final-main\Final\Pages\EditClientes.razor"
using Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditClientes/{CurrentID}")]
    public partial class EditClientes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Actualizar Cliente</h2>\n<hr>\n\n\n\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group col-md-2");
            __builder.AddMarkupContent(6, "<label for=\"id\">ID</label>\n            ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "for", "Nombre");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "disabled");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\JOEL\Desktop\Final-main\Final\Pages\EditClientes.razor"
                                                                      cliente.Cliente_Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cliente.Cliente_Id = __value, cliente.Cliente_Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    <br>\n\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group col-md-4");
            __builder.AddMarkupContent(18, "<label for=\"RNC\">RNC</label>\n            ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "text");
            __builder.AddAttribute(21, "class", "form-control");
            __builder.AddAttribute(22, "id", "inputRNC");
            __builder.AddAttribute(23, "placeholder", "0017568...");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\JOEL\Desktop\Final-main\Final\Pages\EditClientes.razor"
                                                                                                   cliente.RNC

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cliente.RNC = __value, cliente.RNC));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-group col-md-4");
            __builder.AddMarkupContent(29, "<label for=\"Nombre\">Nombre</label>\n            ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "text");
            __builder.AddAttribute(32, "class", "form-control");
            __builder.AddAttribute(33, "id", "inputNombre");
            __builder.AddAttribute(34, "placeholder", "Nombre");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\JOEL\Desktop\Final-main\Final\Pages\EditClientes.razor"
                                                                                                  cliente.Nombre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cliente.Nombre = __value, cliente.Nombre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group col-md-4");
            __builder.AddMarkupContent(40, "<label for=\"Direccion\">Direccion</label>\n            ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "text");
            __builder.AddAttribute(43, "class", "form-control");
            __builder.AddAttribute(44, "id", "inputDireccion");
            __builder.AddAttribute(45, "placeholder", "Direccion");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\JOEL\Desktop\Final-main\Final\Pages\EditClientes.razor"
                                                                                                        cliente.Direccion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cliente.Direccion = __value, cliente.Direccion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n\n    <br>\n\n    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "row ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "form-group col-md-4");
            __builder.AddMarkupContent(53, "<label for=\"Latitud\">Latitud</label>\n            ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "text");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "id", "inputLatitud");
            __builder.AddAttribute(58, "placeholder", "Latitud");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\JOEL\Desktop\Final-main\Final\Pages\EditClientes.razor"
                                                                                                    cliente.Latitud

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cliente.Latitud = __value, cliente.Latitud));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n        ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "form-group col-md-4");
            __builder.AddMarkupContent(64, "<label for=\"Longitud\">Longitud</label>\n            ");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "type", "text");
            __builder.AddAttribute(67, "class", "form-control");
            __builder.AddAttribute(68, "id", "inputLongitud");
            __builder.AddAttribute(69, "placeholder", "Longitud");
            __builder.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\JOEL\Desktop\Final-main\Final\Pages\EditClientes.razor"
                                                                                                      cliente.Longitud

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cliente.Longitud = __value, cliente.Longitud));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\n\n\n\n\n        ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "form-group col-md-4");
            __builder.AddMarkupContent(75, "<label for=\"Correo\">Correo</label>\n            ");
            __builder.OpenElement(76, "input");
            __builder.AddAttribute(77, "type", "text");
            __builder.AddAttribute(78, "class", "form-control");
            __builder.AddAttribute(79, "id", "inputCorreo");
            __builder.AddAttribute(80, "placeholder", "Correo");
            __builder.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\JOEL\Desktop\Final-main\Final\Pages\EditClientes.razor"
                                                                                                  cliente.Correo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cliente.Correo = __value, cliente.Correo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\n\n    ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "row");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "form-group col-md-4");
            __builder.AddMarkupContent(88, "<label for=\"Fecha\">Fecha de Nacimiento</label>\n            ");
            __builder.OpenElement(89, "input");
            __builder.AddAttribute(90, "type", "date");
            __builder.AddAttribute(91, "class", "form-control");
            __builder.AddAttribute(92, "id", "inputFecha");
            __builder.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "C:\Users\JOEL\Desktop\Final-main\Final\Pages\EditClientes.razor"
                                                                            cliente.Fecha

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cliente.Fecha = __value, cliente.Fecha, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\n\n    ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "row");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "col-md-4");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "form-group");
            __builder.OpenElement(102, "input");
            __builder.AddAttribute(103, "type", "button");
            __builder.AddAttribute(104, "class", "btn btn-primary");
            __builder.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\JOEL\Desktop\Final-main\Final\Pages\EditClientes.razor"
                                                                        UpdateCliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(106, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\n                ");
            __builder.OpenElement(108, "input");
            __builder.AddAttribute(109, "type", "button");
            __builder.AddAttribute(110, "class", "btn btn-danger");
            __builder.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\JOEL\Desktop\Final-main\Final\Pages\EditClientes.razor"
                                                                       Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(112, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\JOEL\Desktop\Final-main\Final\Pages\EditClientes.razor"
       
    [Parameter]
    public string CurrentID { get; set; }
    ClienteFinal cliente = new ClienteFinal();


    protected override async Task OnInitializedAsync()
    {
        cliente = await Task.Run(() => Service.GetClienteById(Convert.ToInt32(CurrentID)));

    }

    protected void UpdateCliente()
    {
        Service.UpdateCliente(cliente);
        NavigationManager.NavigateTo("ClienteInfo");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("ClienteInfo");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClienteService Service { get; set; }
    }
}
#pragma warning restore 1591
