﻿namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class MainForm
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
            main_pnl = new Panel();
            container_pnl = new Panel();
            navigation_pnl = new Panel();
            bookinvent_btn = new Button();
            bookreturn_btn = new Button();
            borrower_btn = new Button();
            library_btn = new Button();
            main_pnl.SuspendLayout();
            navigation_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // main_pnl
            // 
            main_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            main_pnl.BackColor = Color.FromArgb(242, 233, 228);
            main_pnl.Controls.Add(container_pnl);
            main_pnl.Controls.Add(navigation_pnl);
            main_pnl.Location = new Point(0, 0);
            main_pnl.Name = "main_pnl";
            main_pnl.Size = new Size(1186, 700);
            main_pnl.TabIndex = 0;
            main_pnl.Paint += panel1_Paint;
            // 
            // container_pnl
            // 
            container_pnl.Location = new Point(0, 67);
            container_pnl.Margin = new Padding(5);
            container_pnl.Name = "container_pnl";
            container_pnl.Size = new Size(1186, 633);
            container_pnl.TabIndex = 1;
            // 
            // navigation_pnl
            // 
            navigation_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            navigation_pnl.BackColor = Color.FromArgb(74, 78, 105);
            navigation_pnl.Controls.Add(bookinvent_btn);
            navigation_pnl.Controls.Add(bookreturn_btn);
            navigation_pnl.Controls.Add(borrower_btn);
            navigation_pnl.Controls.Add(library_btn);
            navigation_pnl.Location = new Point(0, 0);
            navigation_pnl.Name = "navigation_pnl";
            navigation_pnl.Size = new Size(1186, 67);
            navigation_pnl.TabIndex = 0;
            // 
            // bookinvent_btn
            // 
            bookinvent_btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            bookinvent_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bookinvent_btn.BackColor = Color.FromArgb(74, 78, 105);
            bookinvent_btn.FlatAppearance.BorderColor = Color.FromArgb(74, 78, 105);
            bookinvent_btn.FlatStyle = FlatStyle.Flat;
            bookinvent_btn.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookinvent_btn.ForeColor = Color.White;
            bookinvent_btn.Location = new Point(826, 12);
            bookinvent_btn.Name = "bookinvent_btn";
            bookinvent_btn.RightToLeft = RightToLeft.Yes;
            bookinvent_btn.Size = new Size(191, 40);
            bookinvent_btn.TabIndex = 3;
            bookinvent_btn.Text = "BOOK INVENTORY";
            bookinvent_btn.UseVisualStyleBackColor = false;
            bookinvent_btn.Click += bookinvent_btn_Click;
            // 
            // bookreturn_btn
            // 
            bookreturn_btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            bookreturn_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bookreturn_btn.BackColor = Color.FromArgb(74, 78, 105);
            bookreturn_btn.FlatAppearance.BorderColor = Color.FromArgb(74, 78, 105);
            bookreturn_btn.FlatStyle = FlatStyle.Flat;
            bookreturn_btn.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookreturn_btn.ForeColor = Color.White;
            bookreturn_btn.Location = new Point(602, 12);
            bookreturn_btn.Name = "bookreturn_btn";
            bookreturn_btn.Size = new Size(191, 40);
            bookreturn_btn.TabIndex = 2;
            bookreturn_btn.Text = "BOOK RETURNING";
            bookreturn_btn.UseVisualStyleBackColor = false;
            bookreturn_btn.Click += bookreturn_btn_Click;
            // 
            // borrower_btn
            // 
            borrower_btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            borrower_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            borrower_btn.BackColor = Color.FromArgb(74, 78, 105);
            borrower_btn.FlatAppearance.BorderColor = Color.FromArgb(74, 78, 105);
            borrower_btn.FlatStyle = FlatStyle.Flat;
            borrower_btn.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point);
            borrower_btn.ForeColor = Color.White;
            borrower_btn.Location = new Point(379, 12);
            borrower_btn.Name = "borrower_btn";
            borrower_btn.Size = new Size(191, 40);
            borrower_btn.TabIndex = 1;
            borrower_btn.Text = "BORROWER LIST";
            borrower_btn.UseVisualStyleBackColor = false;
            borrower_btn.Click += borrower_btn_Click;
            // 
            // library_btn
            // 
            library_btn.AccessibleName = "";
            library_btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            library_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            library_btn.BackColor = Color.FromArgb(242, 233, 228);
            library_btn.FlatAppearance.BorderColor = Color.FromArgb(74, 78, 105);
            library_btn.FlatStyle = FlatStyle.Flat;
            library_btn.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point);
            library_btn.Location = new Point(157, 12);
            library_btn.Name = "library_btn";
            library_btn.Size = new Size(191, 40);
            library_btn.TabIndex = 0;
            library_btn.Text = "LIBRARY";
            library_btn.UseVisualStyleBackColor = false;
            library_btn.Click += library_btn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 700);
            Controls.Add(main_pnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            main_pnl.ResumeLayout(false);
            navigation_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel main_pnl;
        private Panel navigation_pnl;
        private Button library_btn;
        private Button bookinvent_btn;
        private Button bookreturn_btn;
        private Button borrower_btn;
        private Panel container_pnl;
    }
}