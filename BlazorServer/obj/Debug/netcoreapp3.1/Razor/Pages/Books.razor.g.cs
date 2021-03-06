#pragma checksum "C:\Training\ConnectingToMySQL\BlazorServer\Pages\Books.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa42dc5e2b1ee4a21171c6877438a78fe68f5abb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Training\ConnectingToMySQL\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Training\ConnectingToMySQL\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Training\ConnectingToMySQL\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Training\ConnectingToMySQL\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Training\ConnectingToMySQL\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Training\ConnectingToMySQL\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Training\ConnectingToMySQL\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Training\ConnectingToMySQL\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Training\ConnectingToMySQL\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Training\ConnectingToMySQL\BlazorServer\Pages\Books.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Training\ConnectingToMySQL\BlazorServer\Pages\Books.razor"
using BlazorServer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Training\ConnectingToMySQL\BlazorServer\Pages\Books.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/books")]
    public partial class Books : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Books</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Training\ConnectingToMySQL\BlazorServer\Pages\Books.razor"
                                          AddBook

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Add Book");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-warning");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Training\ConnectingToMySQL\BlazorServer\Pages\Books.razor"
                                          UpdateBook

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Update Book");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-danger");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Training\ConnectingToMySQL\BlazorServer\Pages\Books.razor"
                                         DeleteBook

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Delete Book");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n");
#nullable restore
#line 15 "C:\Training\ConnectingToMySQL\BlazorServer\Pages\Books.razor"
 if (books == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "    ");
            __builder.AddMarkupContent(17, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 18 "C:\Training\ConnectingToMySQL\BlazorServer\Pages\Books.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Training\ConnectingToMySQL\BlazorServer\Pages\Books.razor"
     foreach (var book in books)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "        ");
            __builder.OpenElement(19, "p");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.AddContent(21, 
#nullable restore
#line 24 "C:\Training\ConnectingToMySQL\BlazorServer\Pages\Books.razor"
             book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, " by ");
            __builder.AddContent(23, 
#nullable restore
#line 24 "C:\Training\ConnectingToMySQL\BlazorServer\Pages\Books.razor"
                            book.Author

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 26 "C:\Training\ConnectingToMySQL\BlazorServer\Pages\Books.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Training\ConnectingToMySQL\BlazorServer\Pages\Books.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Training\ConnectingToMySQL\BlazorServer\Pages\Books.razor"
       

    List<BookModel> books;

    private async Task AddBook()
    {
        string sql = "INSERT INTO books (id,title,author,isbm,\"totalCopies\",\"availableCopies\") " +
                     "VALUES(@Id,@Title,@Author,@Isbm,@TotalCopies,@AvailableCopies)";

        await _data.SaveData(sql, new
        {
            Id = 8,
            Title = "New Book",
            Author = "New Author",
            Isbm = 2235354,
            TotalCopies = 5,
            AvailableCopies = 5
        }, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    private async Task UpdateBook()
    {
        string sql = "UPDATE books SET title  = @Title WHERE id = @Id";

        await _data.SaveData(sql, new{Id = 8, Title = "Newest Book"}, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    private async Task DeleteBook()
    {
        string sql = "DELETE FROM books WHERE id=@Id";

        await _data.SaveData(sql, new {Id = 8}, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }


    protected override async Task OnInitializedAsync()
    {
        string sql = "SELECT * from books";

        books = await _data.LoadData<BookModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
