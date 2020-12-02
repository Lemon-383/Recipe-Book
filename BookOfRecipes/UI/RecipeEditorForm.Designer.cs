
namespace BookOfRecipes
{
    partial class RecipeEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeEditorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.rtbox_ingradients = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbox_instructions = new System.Windows.Forms.RichTextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название рецепта:";
            // 
            // tbox_name
            // 
            this.tbox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbox_name.Location = new System.Drawing.Point(145, 401);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(262, 23);
            this.tbox_name.TabIndex = 0;
            // 
            // rtbox_ingradients
            // 
            this.rtbox_ingradients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbox_ingradients.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.rtbox_ingradients.Location = new System.Drawing.Point(12, 29);
            this.rtbox_ingradients.Name = "rtbox_ingradients";
            this.rtbox_ingradients.Size = new System.Drawing.Size(395, 366);
            this.rtbox_ingradients.TabIndex = 1;
            this.rtbox_ingradients.Text = "";
            this.rtbox_ingradients.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Инградиенты (один на строку)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(410, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Инструкции (одна на строку)";
            // 
            // rtbox_instructions
            // 
            this.rtbox_instructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbox_instructions.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.rtbox_instructions.Location = new System.Drawing.Point(413, 29);
            this.rtbox_instructions.Name = "rtbox_instructions";
            this.rtbox_instructions.Size = new System.Drawing.Size(395, 366);
            this.rtbox_instructions.TabIndex = 2;
            this.rtbox_instructions.Text = "";
            this.rtbox_instructions.WordWrap = false;
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(653, 401);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "Ок";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(734, 401);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // RecipeEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 437);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.rtbox_instructions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbox_ingradients);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecipeEditorForm";
            this.Text = "Новый рецепт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.RichTextBox rtbox_ingradients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbox_instructions;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}