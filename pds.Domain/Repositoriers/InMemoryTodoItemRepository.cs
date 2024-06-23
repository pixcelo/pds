using pds.Domain.Entities;

namespace pds.Domain.Repositoriers;

public class InMemoryTodoItemRepository : ITodoItemRepository
{
    private List<TodoItemEntity> todoItems = new List<TodoItemEntity>();

    public IReadOnlyList<TodoItemEntity> GetTodoItems()
    {
        if (this.todoItems.Count == 0)
        {
            this.todoItems.AddRange(
                new List<TodoItemEntity>
                {
                    new TodoItemEntity(1, "タイトル1", "説明1", false),
                    new TodoItemEntity(2, "タイトル2", "説明2", false),
                    new TodoItemEntity(3, "タイトル3", "説明3", false),
                });
        }

        return this.todoItems;
    }

    public void Save(TodoItemEntity todoItem)
    {
        this.todoItems.Add(todoItem);
    }
}

