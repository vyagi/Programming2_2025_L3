namespace InvoiceManager
{
    partial class MainForm
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
            pathTextBox = new TextBox();
            readFileButton = new Button();
            categoryButton = new Button();
            button3 = new Button();
            resultTextBox = new TextBox();
            SuspendLayout();
            // 
            // pathTextBox
            // 
            pathTextBox.Location = new Point(12, 12);
            pathTextBox.Name = "pathTextBox";
            pathTextBox.Size = new Size(772, 23);
            pathTextBox.TabIndex = 0;
            pathTextBox.Text = "Invoices.txt";
            // 
            // readFileButton
            // 
            readFileButton.Location = new Point(12, 55);
            readFileButton.Name = "readFileButton";
            readFileButton.Size = new Size(75, 23);
            readFileButton.TabIndex = 1;
            readFileButton.Text = "Read";
            readFileButton.UseVisualStyleBackColor = true;
            readFileButton.Click += readFileButton_Click;
            // 
            // categoryButton
            // 
            categoryButton.Location = new Point(93, 55);
            categoryButton.Name = "categoryButton";
            categoryButton.Size = new Size(75, 23);
            categoryButton.TabIndex = 2;
            categoryButton.Text = "Category";
            categoryButton.UseVisualStyleBackColor = true;
            categoryButton.Click += categoryButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(709, 60);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(12, 89);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(772, 349);
            resultTextBox.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultTextBox);
            Controls.Add(button3);
            Controls.Add(categoryButton);
            Controls.Add(readFileButton);
            Controls.Add(pathTextBox);
            Name = "MainForm";
            Text = "Invoice Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pathTextBox;
        private Button readFileButton;
        private Button categoryButton;
        private Button button3;
        private TextBox resultTextBox;
    }
}
