namespace pds.Domain.Entities;

/// <summary>
/// TODOアイテムエンティティ
/// </summary>
public class TodoItemEntity
{
    public TodoItemEntity(
        int todoItemId,
        string? title,
        string? description,
        bool isComplete)
	{
        this.TodoItemId = todoItemId;
        this.Title = title;
        this.Description = description;
        this.IsComplete = isComplete;
        this.CreatedAt = DateTime.Now;
	}

    /// <summary>
    /// ID
    /// </summary>
    public int TodoItemId { get; }

    /// <summary>
    /// タイトル
    /// </summary>
    public string? Title { get; }

    /// <summary>
    /// 説明
    /// </summary>
    public string? Description { get; }

    /// <summary>
    /// 完了フラグ
    /// </summary>
    public bool IsComplete { get; } = false;

    /// <summary>
    /// 期限日
    /// </summary>
    public DateTime? DueDate { get; }

    /// <summary>
    /// 作成日
    /// </summary>
    public DateTime CreatedAt { get; }

    /// <summary>
    /// 更新日
    /// </summary>
    public DateTime? UpdatedAt { get; }

    /// <summary>
    /// 削除日
    /// </summary>
    public DateTime? DeletedAt { get; }
}
