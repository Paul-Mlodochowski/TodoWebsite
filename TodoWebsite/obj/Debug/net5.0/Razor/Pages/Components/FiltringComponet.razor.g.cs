#pragma checksum "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\Pages\Components\FiltringComponet.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10f5160f976277be04c89a49e138433ba9705ddb"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoWebsite.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\_Imports.razor"
using TodoWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\_Imports.razor"
using TodoWebsite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\_Imports.razor"
using TodoWebsite.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\_Imports.razor"
using TodoWebsite.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\Pages\Components\FiltringComponet.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    public partial class FiltringComponet : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-check text-center mt-3");
            __builder.AddAttribute(2, "b-vameonib5r");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "class", "form-check-input");
            __builder.AddAttribute(5, "type", "checkbox");
            __builder.AddAttribute(6, "value", "");
            __builder.AddAttribute(7, "id", "filterToggle");
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\Pages\Components\FiltringComponet.razor"
                                                                                                  ToggleFilter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "b-vameonib5r");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, "<label class=\"form-check-label filterLable\" for=\"filterToggle\" b-vameonib5r>\r\n                Turn On filtring\r\n            </label>");
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\Pages\Components\FiltringComponet.razor"
         if (IsDisabled) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<div class=\"w-65 mt-4 d-flex flex-row justify-content-between border border-dark rounded p-5 flex-wrap\" b-vameonib5r><div class=\"form-check w-25 mb-2 ml-1\" b-vameonib5r><input class=\"form-check-input\" type=\"checkbox\" value id=\"defaultCheck2\" disabled b-vameonib5r>\r\n            <label class=\"form-check-label\" for=\"defaultCheck2\" b-vameonib5r>\r\n                IsDone?<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"28\" height=\"30\" fill=\"rgb(57, 191, 37)\" class=\"bi bi-check-all\" viewBox=\"0 0 16 16\" b-vameonib5r><path d=\"M8.97 4.97a.75.75 0 0 1 1.07 1.05l-3.99 4.99a.75.75 0 0 1-1.08.02L2.324 8.384a.75.75 0 1 1 1.06-1.06l2.094 2.093L8.95 4.992a.252.252 0 0 1 .02-.022zm-.92 5.14.92.92a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 1 0-1.091-1.028L9.477 9.417l-.485-.486-.943 1.179z\" b-vameonib5r></path></svg></label></div>\r\n        <div class=\"input-group mb-3 w-65\" b-vameonib5r><span class=\"input-group-text\" id=\"inputGroup-sizing-default\" b-vameonib5r><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"25\" fill=\"currentColor\" class=\"bi bi-bookmarks\" viewBox=\"0 0 16 16\" b-vameonib5r><path d=\"M2 4a2 2 0 0 1 2-2h6a2 2 0 0 1 2 2v11.5a.5.5 0 0 1-.777.416L7 13.101l-4.223 2.815A.5.5 0 0 1 2 15.5V4zm2-1a1 1 0 0 0-1 1v10.566l3.723-2.482a.5.5 0 0 1 .554 0L11 14.566V4a1 1 0 0 0-1-1H4z\" b-vameonib5r></path>\r\n                    <path d=\"M4.268 1H12a1 1 0 0 1 1 1v11.768l.223.148A.5.5 0 0 0 14 13.5V2a2 2 0 0 0-2-2H6a2 2 0 0 0-1.732 1z\" b-vameonib5r></path></svg></span>\r\n            <input type=\"text\" class=\"form-control\" placeholder=\"Filter by tags (seperate by space)\" disabled b-vameonib5r></div>\r\n        <div class=\"input-group mb-3\" b-vameonib5r><span class=\"input-group-text\" id=\"inputGroup-sizing-default\" b-vameonib5r><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"25\" height=\"25\" fill=\"currentColor\" class=\"bi bi-search\" viewBox=\"0 0 16 16\" b-vameonib5r><path d=\"M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z\" b-vameonib5r></path></svg></span>\r\n            <input type=\"text\" class=\"form-control\" aria-label=\"Sizing example input\" placeholder=\"Search by title or description\" disabled b-vameonib5r></div>\r\n        <div class=\"input-group mb-3\" b-vameonib5r><span class=\"input-group-text\" id=\"inputGroup-sizing-default\" b-vameonib5r><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"25\" height=\"25\" fill=\"currentColor\" class=\"bi bi-calendar-check\" viewBox=\"0 0 16 16\" b-vameonib5r><path d=\"M10.854 7.146a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708 0l-1.5-1.5a.5.5 0 1 1 .708-.708L7.5 9.793l2.646-2.647a.5.5 0 0 1 .708 0z\" b-vameonib5r></path>\r\n                    <path d=\"M3.5 0a.5.5 0 0 1 .5.5V1h8V.5a.5.5 0 0 1 1 0V1h1a2 2 0 0 1 2 2v11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2h1V.5a.5.5 0 0 1 .5-.5zM1 4v10a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V4H1z\" b-vameonib5r></path></svg></span>\r\n            <input type=\"text\" class=\"form-control\" aria-label=\"Sizing example input\" placeholder=\"Search by Date dd-mm-yyyy\" disabled b-vameonib5r>\r\n            <div class=\"input-group mb-0 mt-3 d-flex justify-content-center\" b-vameonib5r><button type=\"button\" class=\"btn btn-primary w-50 \" disabled b-vameonib5r>Filter</button></div></div></div>");
#nullable restore
#line 51 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\Pages\Components\FiltringComponet.razor"
}
else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "w-65 mt-4 d-flex flex-row justify-content-between border border-dark rounded p-5 flex-wrap");
            __builder.AddAttribute(15, "b-vameonib5r");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-check w-25 mb-2 ml-1");
            __builder.AddAttribute(18, "b-vameonib5r");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "class", "form-check-input");
            __builder.AddAttribute(21, "type", "checkbox");
            __builder.AddAttribute(22, "value", "");
            __builder.AddAttribute(23, "id", "defaultCheck2");
            __builder.AddAttribute(24, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\Pages\Components\FiltringComponet.razor"
                                                                                               FiltringOfDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FiltringOfDone = __value, FiltringOfDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.AddAttribute(26, "b-vameonib5r");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.AddMarkupContent(28, @"<label class=""form-check-label"" for=""defaultCheck2"" b-vameonib5r>
                IsDone?<svg xmlns=""http://www.w3.org/2000/svg"" width=""28"" height=""30"" fill=""rgb(57, 191, 37)"" class=""bi bi-check-all"" viewBox=""0 0 16 16"" b-vameonib5r><path d=""M8.97 4.97a.75.75 0 0 1 1.07 1.05l-3.99 4.99a.75.75 0 0 1-1.08.02L2.324 8.384a.75.75 0 1 1 1.06-1.06l2.094 2.093L8.95 4.992a.252.252 0 0 1 .02-.022zm-.92 5.14.92.92a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 1 0-1.091-1.028L9.477 9.417l-.485-.486-.943 1.179z"" b-vameonib5r></path></svg></label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "input-group mb-3 w-65");
            __builder.AddAttribute(32, "b-vameonib5r");
            __builder.AddMarkupContent(33, @"<span class=""input-group-text"" id=""inputGroup-sizing-default"" b-vameonib5r><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""25"" fill=""currentColor"" class=""bi bi-bookmarks"" viewBox=""0 0 16 16"" b-vameonib5r><path d=""M2 4a2 2 0 0 1 2-2h6a2 2 0 0 1 2 2v11.5a.5.5 0 0 1-.777.416L7 13.101l-4.223 2.815A.5.5 0 0 1 2 15.5V4zm2-1a1 1 0 0 0-1 1v10.566l3.723-2.482a.5.5 0 0 1 .554 0L11 14.566V4a1 1 0 0 0-1-1H4z"" b-vameonib5r></path>
                    <path d=""M4.268 1H12a1 1 0 0 1 1 1v11.768l.223.148A.5.5 0 0 0 14 13.5V2a2 2 0 0 0-2-2H6a2 2 0 0 0-1.732 1z"" b-vameonib5r></path></svg></span>
            ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "text");
            __builder.AddAttribute(36, "class", "form-control");
            __builder.AddAttribute(37, "placeholder", "Filter by tags (seperate by space)");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\Pages\Components\FiltringComponet.razor"
                                                                                                            FiltringOfTags

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FiltringOfTags = __value, FiltringOfTags));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(40, "b-vameonib5r");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "input-group mb-3");
            __builder.AddAttribute(44, "b-vameonib5r");
            __builder.AddMarkupContent(45, @"<span class=""input-group-text"" id=""inputGroup-sizing-default"" b-vameonib5r><svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""currentColor"" class=""bi bi-search"" viewBox=""0 0 16 16"" b-vameonib5r><path d=""M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z"" b-vameonib5r></path></svg></span>
            ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "text");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "aria-label", "Sizing example input");
            __builder.AddAttribute(50, "placeholder", "Search by title or description");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 77 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\Pages\Components\FiltringComponet.razor"
                                                                                                                                          Searching

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Searching = __value, Searching));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(53, "b-vameonib5r");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "input-group mb-3");
            __builder.AddAttribute(57, "b-vameonib5r");
            __builder.AddMarkupContent(58, @"<span class=""input-group-text"" id=""inputGroup-sizing-default"" b-vameonib5r><svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""currentColor"" class=""bi bi-calendar-check"" viewBox=""0 0 16 16"" b-vameonib5r><path d=""M10.854 7.146a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708 0l-1.5-1.5a.5.5 0 1 1 .708-.708L7.5 9.793l2.646-2.647a.5.5 0 0 1 .708 0z"" b-vameonib5r></path>
                    <path d=""M3.5 0a.5.5 0 0 1 .5.5V1h8V.5a.5.5 0 0 1 1 0V1h1a2 2 0 0 1 2 2v11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2h1V.5a.5.5 0 0 1 .5-.5zM1 4v10a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V4H1z"" b-vameonib5r></path></svg></span>
            ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "type", "date");
            __builder.AddAttribute(61, "class", "form-control");
            __builder.AddAttribute(62, "aria-label", "Sizing example input");
            __builder.AddAttribute(63, "placeholder", "Search by Date dd-mm-yyyy");
            __builder.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 86 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\Pages\Components\FiltringComponet.razor"
                                                                                                                                      FiltringOfDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FiltringOfDate = __value, FiltringOfDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(66, "b-vameonib5r");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "input-group mb-0 mt-3 d-flex justify-content-center");
            __builder.AddAttribute(70, "b-vameonib5r");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "type", "button");
            __builder.AddAttribute(73, "class", "btn btn-primary w-50");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\Pages\Components\FiltringComponet.razor"
                                                                             CheckWhichFiltringResultsUserIsUsing

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "b-vameonib5r");
            __builder.AddContent(76, "Filter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 92 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\Pages\Components\FiltringComponet.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\Pages\Components\FiltringComponet.razor"
       
    [Parameter]
    public EventCallback<List<TodoList>> ChangeList { get; set; }
    [Parameter]
    public EventCallback ShowResults { get; set; }
    [Parameter]
    public DateTime MinDateTime { get; set; }



    //Filtring
    private bool FiltringOfDone { get; set; } = false;
    private DateTime FiltringOfDate { get; set; }
    private string FiltringOfTags { get; set; }
    private string Searching { get; set; }
    private bool IsDisabled { get; set; } = true;


    private void ToggleFilter() {
        FiltringOfDate = MinDateTime;
        IsDisabled = !IsDisabled;
        if (IsDisabled)
            ShowResults.InvokeAsync();
    }

    private void CheckWhichFiltringResultsUserIsUsing() {
        var filtringMethods = new List<Action>();
        List<TodoList> TodoItems = new List<TodoList>();
        using(var dbContex = new TodoDatabaseContex()){
            TodoItems = dbContex.TodoLists.ToList<TodoList>();
            foreach (var item in dbContex.TodoLists)
            {
                dbContex.Tags.Where(tag => tag.TodoListId == item.Id ).ToList<Tag>();  // To dodaje tagi do items

            }
            filtringMethods.Add(() =>
            {
                var query = from item in TodoItems
                            where item.IsDone == FiltringOfDone
                            select item;

                if(query is not null)
                    TodoItems = TodoItems.Where(t => query.Contains<TodoList>(t)).ToList<TodoList>();

            });
            if( DateTime.Compare(MinDateTime,FiltringOfDate) != 0)
                filtringMethods.Add(() =>
                {
                    var query = from item in TodoItems
                                where DateTime.Compare(item.Date,FiltringOfDate) >= 0
                                select item;

                    
                        TodoItems = TodoItems.Where(t => query.Contains<TodoList>(t)).ToList<TodoList>();

                });
            if(FiltringOfTags is not null && FiltringOfTags != "")
                filtringMethods.Add(() =>
                {
                    List<Tag> listofTags = TagFormater.ReturnListOfFormatedTags(FiltringOfTags);
                    List<string> valueToCheck = new List<string>();
                    listofTags.ForEach(t =>valueToCheck.Add(t.TagValue.ToLower()));


                    var listOfTodoList = new List<TodoList>();
                    foreach(var value in valueToCheck) {
                        foreach(var todoItem in TodoItems) {
                            foreach(var todoTag in todoItem.Tags) {
                                if(String.Compare(todoTag.TagValue.ToLower(),value) == 0) {
                                    listOfTodoList.Add(todoItem);
                                    break;
                                }
                            }
                        }
                    }
                    
                        TodoItems = TodoItems.Where(t => listOfTodoList.Contains(t)).ToList<TodoList>();



                });
            if(Searching is not null && Searching != "")
                filtringMethods.Add(() =>
                {
                    Regex rx = new Regex(@Searching, RegexOptions.IgnoreCase);

                    var query = from item in TodoItems
                                where rx.IsMatch(item.Title) || rx.IsMatch(item.Description)
                                select item;
                    if(query is not null)
                        TodoItems = TodoItems.Where(t => query.Contains(t)).ToList<TodoList>();

                });

        };
        foreach (var action in filtringMethods) // wywołuje wszystkie pożądane funkcjee
        {
            action.Invoke();
        }
        ChangeList.InvokeAsync(TodoItems);

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
