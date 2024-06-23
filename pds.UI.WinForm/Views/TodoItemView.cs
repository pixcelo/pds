using pds.UI.WinForm.ViewModels;

namespace pds.UI.WinForm;

public partial class TodoItemView : Form
{
    private TodoItemViewModel viewModel = new TodoItemViewModel();

    public TodoItemView()
    {
        InitializeComponent();

        this.DataBind();
    }

    private void DataBind()
    {
        
    }
}