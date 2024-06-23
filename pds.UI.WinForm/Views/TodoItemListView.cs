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
    /// �r���[���f���̃f�[�^�o�C���h
    /// </summary>
    private void DataBind()
    {
        this.TodoItemsDataGrid.DataBindings.Add(
                "DataSource", viewModel, nameof(viewModel.TodoItems));
    }

    /// <summary>
    /// TOOO�ǉ��{�^���N���b�N���̏���
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AddButton_Click(object sender, EventArgs e)
    {

    }
}