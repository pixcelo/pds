namespace pds.UI.WinForm
{
    partial class TodoItemListView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TodoItemsDataGrid = new DataGridView();
            AddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)TodoItemsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // TodoItemsDataGrid
            // 
            TodoItemsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TodoItemsDataGrid.Dock = DockStyle.Bottom;
            TodoItemsDataGrid.Location = new Point(0, 72);
            TodoItemsDataGrid.Name = "TodoItemsDataGrid";
            TodoItemsDataGrid.Size = new Size(800, 378);
            TodoItemsDataGrid.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(25, 24);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // TodoItemListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddButton);
            Controls.Add(TodoItemsDataGrid);
            Name = "TodoItemListView";
            Text = "TodoItem";
            ((System.ComponentModel.ISupportInitialize)TodoItemsDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TodoItemsDataGrid;
        private Button AddButton;
    }
}
