namespace Quản_lý_khách_hàng_4_11_
{
    partial class Form1
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
            customersDataGridView = new DataGridView();
            label1 = new Label();
            servicesDataGridView = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nameTextBox = new TextBox();
            phoneTextBox = new TextBox();
            addressTextBox = new TextBox();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            createInvoiceButton = new Button();
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // customersDataGridView
            // 
            customersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersDataGridView.Location = new Point(3, 46);
            customersDataGridView.Name = "customersDataGridView";
            customersDataGridView.RowHeadersWidth = 51;
            customersDataGridView.Size = new Size(432, 188);
            customersDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 1;
            label1.Text = "Danh sách khách hàng";
            label1.Click += label1_Click;
            // 
            // servicesDataGridView
            // 
            servicesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicesDataGridView.Location = new Point(455, 46);
            servicesDataGridView.Name = "servicesDataGridView";
            servicesDataGridView.RowHeadersWidth = 51;
            servicesDataGridView.Size = new Size(300, 188);
            servicesDataGridView.TabIndex = 2;
            servicesDataGridView.CellContentClick += servicesDataGridView_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(359, 20);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 3;
            label2.Text = "Thông tin dịch vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(25, 258);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 4;
            label3.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(39, 292);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 5;
            label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(81, 325);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 6;
            label5.Text = "Địa chỉ:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(145, 251);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(182, 27);
            nameTextBox.TabIndex = 7;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(145, 285);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(182, 27);
            phoneTextBox.TabIndex = 8;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(145, 318);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(182, 27);
            addressTextBox.TabIndex = 9;
            // 
            // addButton
            // 
            addButton.Location = new Point(78, 383);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 10;
            addButton.Text = "Thêm";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(242, 385);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 29);
            editButton.TabIndex = 11;
            editButton.Text = "Sửa ";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(407, 385);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Xóa";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // createInvoiceButton
            // 
            createInvoiceButton.Location = new Point(583, 385);
            createInvoiceButton.Name = "createInvoiceButton";
            createInvoiceButton.Size = new Size(94, 29);
            createInvoiceButton.TabIndex = 13;
            createInvoiceButton.Text = "Tạo hóa đơn";
            createInvoiceButton.UseVisualStyleBackColor = true;
            createInvoiceButton.Click += createInvoiceButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createInvoiceButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(addressTextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(servicesDataGridView);
            Controls.Add(label1);
            Controls.Add(customersDataGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView customersDataGridView;
        private Label label1;
        private DataGridView servicesDataGridView;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nameTextBox;
        private TextBox phoneTextBox;
        private TextBox addressTextBox;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button createInvoiceButton;
    }
}
