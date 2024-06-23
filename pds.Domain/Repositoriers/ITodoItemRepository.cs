using pds.Domain.Entities;

namespace pds.Domain.Repositoriers;

public interface ITodoItemRepository
{
    /// <summary>
    /// TODOアイテムを取得する
    /// </summary>
    /// <param name="todoId"></param>
    /// <returns></returns>
    IReadOnlyList<TodoItemEntity> GetTodoItems();

    /// <summary>
    /// TODOアイテムを保存する
    /// </summary>
    /// <param name="todoItem"></param>
    void Save(TodoItemEntity todoItem);
}

