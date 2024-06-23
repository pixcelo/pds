using pds.Domain.Repositoriers;
using System.ComponentModel;

namespace pds.UI.WinForm.ViewModels;

/// <summary>
/// TODOアイテムリストのViewModel
/// </summary>
public class TodoItemListViewModel : ViewModelBase
{
    private ITodoItemRepository todoItem;

    public TodoItemListViewModel() : this(new InMemoryTodoItemRepository())
    {
    }

    public TodoItemListViewModel(ITodoItemRepository todoItem)
    {
        this.todoItem = todoItem;

        foreach (var entity in todoItem.GetTodoItems())
        {
            this.TodoItems.Add(new TodoItemListViewModelTodoItem(entity));
        }
    }

    /// <summary>
    /// TODOアイテムリスト
    /// </summary>
    public BindingList<TodoItemListViewModelTodoItem> TodoItems { get; set; }
            = new BindingList<TodoItemListViewModelTodoItem>();
}

