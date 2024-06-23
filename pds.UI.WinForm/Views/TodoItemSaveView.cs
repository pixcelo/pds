using pds.UI.WinForm.ViewModels;
using System.ComponentModel;

namespace pds.UI.WinForm.Views;

public partial class TodoItemSaveView : Form
{
    private TodoItemSaveViewModel viewModel = new TodoItemSaveViewModel();
    private Action<TodoItemSaveView, DialogResult> onCloseCallBack;

    public TodoItemSaveView()
    {
        InitializeComponent();

        this.DataBind();
    }

    public TodoItemSaveView(        
        Action<TodoItemSaveView, DialogResult> todoItemSaveViewOnCloseCallBack) : this()
    {
        this.onCloseCallBack = todoItemSaveViewOnCloseCallBack;
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

        MessageBox.Show(
            "保存しました。",
            "情報",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        this.Close();
    }

    /// <summary>
    /// 画面を閉じる際の処理
    /// </summary>
    /// <param name="e"></param>
    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        if (this.onCloseCallBack != null)
        {
            this.onCloseCallBack(this, this.DialogResult);
        }

        base.OnFormClosed(e);
    }
}