// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
                   

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\Pages\Components\FiltringComponet.razor"
                       
                    var query = from item in TodoItems
                                where DateTime.Compare(item.Date,FiltringOfDate) >= 0
                                select item;

                    if(query is not null)
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
