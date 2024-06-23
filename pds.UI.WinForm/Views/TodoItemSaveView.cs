using pds.Domain.Enums;
using pds.UI.WinForm.ViewModels;

namespace pds.UI.WinForm.Views;

public partial class TodoItemSaveView : Form
{
    private TodoItemSaveViewModel viewModel = new TodoItemSaveViewModel();

    public TodoItemSaveView()
    {
        InitializeComponent();

        this.DataBind();
    }

    /// <summary>
    /// データバインド
    /// </summary>
    private void DataBind()
    {
        this.TitleTextBox.DataBindings.Add(
             "Text", viewModel, nameof(viewModel.Title));
        this.DescriptionTextBox.DataBindings.Add(
            "Text", viewModel, nameof(viewModel.Description));
        this.DueDateTextBox.DataBindings.Add(
            "Value", viewModel, nameof(viewModel.DueDateValue));
    }

    /// <summary>
    /// TODO保存ボタンクリック時の処理
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SaveButton_Click(object sender, EventArgs e)
    {
        this.viewModel.Save();
    }
}