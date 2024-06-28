using pds.Domain.Entities;
using pds.Domain.Repositoriers;

namespace pds.Infrastructure.SQLite
{
    public class TodoItemSQLite : ITodoItemRepository
    {
        public IReadOnlyList<TodoItemEntity> GetTodoItems()
        {
            var sql = @"SECELT * FROM TodoItems";

            return SQLiteHelper.Query(sql,
                reader =>
                {
                    return new TodoItemEntity(
                        Convert.ToInt32(reader["TodoItemId"]),
                        Convert.ToString(reader["Title"]),
                        Convert.ToString(reader["Description"]),
                        Convert.ToBoolean(reader["IsCompleted"]));
                });
        }

        public void Save(TodoItemEntity todoItem)
        {
            throw new NotImplementedException();
        }
    }
}
