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

        this.Refresh();
    }

    /// <summary>
    /// TODOアイテムリスト
    /// </summary>
    public BindingList<TodoItemListViewModelTodoItem> TodoItems { get; set; }
            = new BindingList<TodoItemListViewModelTodoItem>();

    /// <summary>
    /// TODOアイテムをリフレッシュする
    /// </summary>
    public void Refresh()
    {
        this.TodoItems.Clear();

        foreach (var entity in todoItem.GetTodoItems())
        {
            this.TodoItems.Add(new TodoItemListViewModelTodoItem(entity));
        }
    }
}

