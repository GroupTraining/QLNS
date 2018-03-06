namespace QLNS.GUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.btn_home = new DevComponents.DotNetBar.ButtonItem();
            this.btn_add = new DevComponents.DotNetBar.ButtonItem();
            this.btn_search = new DevComponents.DotNetBar.ButtonItem();
            this.btn_edit = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.contextMenuBar1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_home,
            this.btn_add,
            this.btn_search,
            this.btn_edit,
            this.buttonItem1});
            this.contextMenuBar1.Location = new System.Drawing.Point(0, 0);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(832, 35);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.contextMenuBar1.TabIndex = 0;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // btn_home
            // 
            this.btn_home.AutoExpandOnClick = true;
            this.btn_home.ForeColor = System.Drawing.Color.Blue;
            this.btn_home.ImagePaddingHorizontal = 8;
            this.btn_home.Name = "btn_home";
            this.btn_home.Text = "Home";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_add
            // 
            this.btn_add.AutoExpandOnClick = true;
            this.btn_add.ForeColor = System.Drawing.Color.Blue;
            this.btn_add.ImagePaddingHorizontal = 8;
            this.btn_add.Name = "btn_add";
            this.btn_add.Text = "Thêm mới";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_search
            // 
            this.btn_search.AutoExpandOnClick = true;
            this.btn_search.ForeColor = System.Drawing.Color.Blue;
            this.btn_search.ImagePaddingHorizontal = 8;
            this.btn_search.Name = "btn_search";
            this.btn_search.Text = "Tra cứu";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.AutoExpandOnClick = true;
            this.btn_edit.ForeColor = System.Drawing.Color.Blue;
            this.btn_edit.ImagePaddingHorizontal = 8;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Text = "Chỉnh sửa";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.AutoExpandOnClick = true;
            this.buttonItem1.ForeColor = System.Drawing.Color.Blue;
            this.buttonItem1.ImagePaddingHorizontal = 8;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Help";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 382);
            this.Controls.Add(this.contextMenuBar1);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonItem btn_home;
        private DevComponents.DotNetBar.ButtonItem btn_add;
        private DevComponents.DotNetBar.ButtonItem btn_search;
        private DevComponents.DotNetBar.ButtonItem btn_edit;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
    }
}