using pds.Domain.Entities;

namespace pds.UI.WinForm.ViewModels;

/// <summary>
/// TODOアイテムリストのレコードのViewModel
/// </summary>
public class TodoItemListViewModelTodoItem : ViewModelBase
{
    private TodoItemEntity entity;

    public TodoItemListViewModelTodoItem(TodoItemEntity entity)
    {
        this.entity = entity;
    }

    public string TodoItemId => this.entity.TodoItemId.ToString();
    public string? Title => this.entity.Title;
}