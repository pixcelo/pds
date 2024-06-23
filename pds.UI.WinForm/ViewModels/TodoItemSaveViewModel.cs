using pds.Domain.Entities;
using pds.Domain.Repositoriers;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pds.UI.WinForm.ViewModels;

/// <summary>
/// TODOアイテム登録画面のViewModel
/// </summary>
public class TodoItemSaveViewModel : ViewModelBase
{
    private ITodoItemRepository todoItem;

    public TodoItemSaveViewModel() : this(new InMemoryTodoItemRepository())
    {        
    }

    public TodoItemSaveViewModel(ITodoItemRepository todoItem)
    {
        this.todoItem = todoItem;
        this.DueDateValue = this.GetDataTime();
    }

    public string TodoItemId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDateValue { get; set; }
    public object SelectedStatus { get; set; }

    /// <summary>
    /// TODOアイテムを保存する
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public void Save()
    {
        if (string.IsNullOrEmpty(this.Title))
        {
            // 例外を投げる
        }

        var entity = new TodoItemEntity(
                1,
                this.Title,
                this.Description,
                false
            );

        this.todoItem.Save(entity);
    }

    /// <summary>
    /// テストのときはMoqを使って上書きするため、virtualにしておく
    /// </summary>
    /// <returns></returns>
    public virtual DateTime GetDataTime()
    {
        return DateTime.Now;
    }
}