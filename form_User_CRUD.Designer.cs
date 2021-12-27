
namespace User_CRUD_WinForm
{
    partial class form_User_CRUD
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
            this.lb_heading = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_age = new System.Windows.Forms.Label();
            this.lb_city = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.dgv_users_list = new System.Windows.Forms.DataGridView();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.num_age = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_heading
            // 
            this.lb_heading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_heading.AutoSize = true;
            this.lb_heading.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lb_heading.Location = new System.Drawing.Point(348, 9);
            this.lb_heading.Name = "lb_heading";
            this.lb_heading.Size = new System.Drawing.Size(109, 25);
            this.lb_heading.TabIndex = 0;
            this.lb_heading.Text = "User CRUD";
            this.lb_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_name
            // 
            this.lb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_name.Location = new System.Drawing.Point(200, 60);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(62, 15);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Full Name";
            // 
            // lb_age
            // 
            this.lb_age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_age.AutoSize = true;
            this.lb_age.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_age.Location = new System.Drawing.Point(233, 96);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(29, 15);
            this.lb_age.TabIndex = 2;
            this.lb_age.Text = "Age";
            // 
            // lb_city
            // 
            this.lb_city.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_city.AutoSize = true;
            this.lb_city.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_city.Location = new System.Drawing.Point(233, 134);
            this.lb_city.Name = "lb_city";
            this.lb_city.Size = new System.Drawing.Size(28, 15);
            this.lb_city.TabIndex = 3;
            this.lb_city.Text = "City";
            // 
            // tb_name
            // 
            this.tb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_name.Location = new System.Drawing.Point(290, 52);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(261, 23);
            this.tb_name.TabIndex = 4;
            // 
            // tb_city
            // 
            this.tb_city.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_city.Location = new System.Drawing.Point(290, 126);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(261, 23);
            this.tb_city.TabIndex = 6;
            // 
            // dgv_users_list
            // 
            this.dgv_users_list.AllowUserToAddRows = false;
            this.dgv_users_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_users_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users_list.Location = new System.Drawing.Point(66, 221);
            this.dgv_users_list.Name = "dgv_users_list";
            this.dgv_users_list.RowTemplate.Height = 25;
            this.dgv_users_list.Size = new System.Drawing.Size(668, 303);
            this.dgv_users_list.TabIndex = 10;
            this.dgv_users_list.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_users_list_RowHeaderMouseClick);
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_insert.Location = new System.Drawing.Point(230, 178);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 7;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.Location = new System.Drawing.Point(358, 178);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_delete.Location = new System.Drawing.Point(475, 178);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // num_age
            // 
            this.num_age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_age.Location = new System.Drawing.Point(290, 88);
            this.num_age.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.num_age.Name = "num_age";
            this.num_age.Size = new System.Drawing.Size(261, 23);
            this.num_age.TabIndex = 5;
            // 
            // form_User_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.num_age);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dgv_users_list);
            this.Controls.Add(this.tb_city);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_city);
            this.Controls.Add(this.lb_age);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_heading);
            this.Name = "form_User_CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User CRUD WinForm App";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_heading;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.Label lb_city;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.DataGridView dgv_users_list;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.NumericUpDown num_age;
    }
}

