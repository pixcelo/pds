using pds.Domain.Entities;

namespace pds.Domain.Repositoriers;

public class InMemoryTodoItemRepository : ITodoItemRepository
{
    public IReadOnlyList<TodoItemEntity> GetTodoItems()
    {
        var todoItems = new List<TodoItemEntity>
        {
            new TodoItemEntity(1, "タイトル1", "説明1", false),
            new TodoItemEntity(2, "タイトル2", "説明2", false),
            new TodoItemEntity(3, "タイトル3", "説明3", false),
        };

        return todoItems;
    }
}

