// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TodoWebsite.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 155 "C:\Users\PAWEŁ\Desktop\Vis Studio\TodoWebsite\TodoWebsite\Pages\Index.razor"
      

    private TodoWebsite.Pages.Components.Popout Modal { get; set; }
    private List<TodoList> List { get; set; } = new List<TodoList>();
    private List<Tag> ListOfTags { get; set; } = new List<Tag>();
    private bool IsDisabled { get; set; } = true;

    protected override void OnInitialized() {
        using (var dbContext = Db)
        {

            dbContext.Database.EnsureCreated();

            foreach (var item in dbContext.TodoLists)
            {
                dbContext.Tags.Where(tag => tag.TodoListId == item.Id ).ToList<Tag>();  // To dodaje tagi do items
                List.Add(item);
            }

        }

        base.OnInitialized();
    }
    private void ShowResults() {
        List.Clear();
        using(var dbContex = new TodoDatabaseContex()){
            foreach (var item in dbContex.TodoLists)
            {
                dbContex.Tags.Where(tag => tag.TodoListId == item.Id ).ToList<Tag>();  // To dodaje tagi do items
                List.Add(item);
            }
        }
    }
    private void AddNewTodoTask(TodoList list) {
        using(var dbContex = new TodoDatabaseContex()){
            dbContex.TodoLists.Add(list);
            dbContex.AddRange(list.Tags);
            dbContex.SaveChanges();
        }
        ShowResults();
    }
    private void Update(TodoList list) {
        using(var dbContex = new TodoDatabaseContex()){
            var newTags = list.Tags;
            var tagsToDelete = dbContex.Tags.Where(item => item.TodoListId == list.Id);
            dbContex.Tags.RemoveRange(tagsToDelete);
            dbContex.Tags.AddRange(newTags);
            dbContex.TodoLists.Update(list);
            dbContex.SaveChanges();
        }
        ShowResults();
    }
    private void Delete(int id) {
        using(var dbContex = new TodoDatabaseContex()){

            var itemToDelete = dbContex.TodoLists.Where(item => item.Id == id).FirstOrDefault<TodoList>();
            var tagsToDelete = dbContex.Tags.Where(item => item.TodoListId == itemToDelete.Id);
            dbContex.TodoLists.Remove(itemToDelete);
            dbContex.Tags.RemoveRange(tagsToDelete);
            dbContex.SaveChanges();
        }
        ShowResults();
    }
    private void ChangeStatus(TodoList todoItem, object obj) {
        var newValue = (bool)obj;
        using(var dbContex = new TodoDatabaseContex()){
            todoItem.IsDone = newValue;
            dbContex.TodoLists.Update(todoItem);
            dbContex.SaveChanges();
        }
        ShowResults();
    }
    private void ToggleFilter() { 
        IsDisabled = !IsDisabled;
        if (IsDisabled)
            ShowResults();
    }

    private bool FiltringOfDone { get; set; } = false;
    private string FiltringOfDate { get; set; }

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
            if(FiltringOfDate is not null && FiltringOfDate != "")
                filtringMethods.Add(() =>
                {
                    DateTime userDate = new DateTime();
                    try {
                        userDate = DateTime.Parse(FiltringOfDate);
                    }catch(ArgumentException) {
                        FiltringOfDate = "Fill in proprate formated date!";
                        return;
                    }
                    catch(FormatException) {
                        FiltringOfDate = "Fill in proprate formated date!";
                        return;
                    }
                    var query = from item in TodoItems
                                where DateTime.Compare(item.Date,userDate) >= 0
                                select item;

                    if(query is not null)
                        TodoItems = TodoItems.Where(t => query.Contains<TodoList>(t)).ToList<TodoList>();

                });

        };
        foreach (var action in filtringMethods)
        {
            action.Invoke();
        }
        List = TodoItems;

    }

   

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TodoDatabaseContex Db { get; set; }
    }
}
#pragma warning restore 1591
