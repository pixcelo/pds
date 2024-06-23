using pds.UI.WinForm.ViewModels;

namespace pds.UI.WinForm;

public partial class TodoItemListView : Form
{
    private TodoItemListViewModel viewModel = new TodoItemListViewModel();

    public TodoItemListView()
    {
        InitializeComponent();

        this.DataBind();
    }

    /// <summary>
    /// ビューモデルのデータバインド
    /// </summary>
    private void DataBind()
    {
        this.TodoItemsDataGrid.DataBindings.Add(
                "DataSource", viewModel, nameof(viewModel.TodoItems));
    }

    /// <summary>
    /// TOOO追加ボタンクリック時の処理
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AddButton_Click(object sender, EventArgs e)
    {

    }
}