
namespace BookOfRecipes
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgv_recipes = new System.Windows.Forms.DataGridView();
            this.dgvCol_Recipes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbox_recipe = new System.Windows.Forms.RichTextBox();
            this.toolStrip_main = new System.Windows.Forms.ToolStrip();
            this.mainToolStripBtn_add = new System.Windows.Forms.ToolStripButton();
            this.mainToolStripBtn_remove = new System.Windows.Forms.ToolStripButton();
            this.mainToolStripBtn_edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainToolStripBtn_saveSelected = new System.Windows.Forms.ToolStripButton();
            this.mainToolStripBtn_openRecipe = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recipes)).BeginInit();
            this.toolStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_recipes
            // 
            this.dgv_recipes.AllowUserToAddRows = false;
            this.dgv_recipes.AllowUserToDeleteRows = false;
            this.dgv_recipes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_recipes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_recipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_recipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_Recipes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_recipes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_recipes.Location = new System.Drawing.Point(12, 28);
            this.dgv_recipes.Name = "dgv_recipes";
            this.dgv_recipes.ReadOnly = true;
            this.dgv_recipes.RowTemplate.ReadOnly = true;
            this.dgv_recipes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_recipes.Size = new System.Drawing.Size(329, 464);
            this.dgv_recipes.TabIndex = 0;
            this.dgv_recipes.SelectionChanged += new System.EventHandler(this.dgv_recipes_SelectionChanged);
            // 
            // dgvCol_Recipes
            // 
            this.dgvCol_Recipes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCol_Recipes.DataPropertyName = "Name";
            this.dgvCol_Recipes.HeaderText = "Список рецептов";
            this.dgvCol_Recipes.Name = "dgvCol_Recipes";
            this.dgvCol_Recipes.ReadOnly = true;
            this.dgvCol_Recipes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rtbox_recipe
            // 
            this.rtbox_recipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbox_recipe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbox_recipe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbox_recipe.Location = new System.Drawing.Point(347, 28);
            this.rtbox_recipe.Name = "rtbox_recipe";
            this.rtbox_recipe.ReadOnly = true;
            this.rtbox_recipe.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbox_recipe.Size = new System.Drawing.Size(526, 464);
            this.rtbox_recipe.TabIndex = 1;
            this.rtbox_recipe.Text = "";
            // 
            // toolStrip_main
            // 
            this.toolStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripBtn_add,
            this.mainToolStripBtn_remove,
            this.mainToolStripBtn_edit,
            this.toolStripSeparator1,
            this.mainToolStripBtn_saveSelected,
            this.mainToolStripBtn_openRecipe});
            this.toolStrip_main.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_main.Name = "toolStrip_main";
            this.toolStrip_main.Size = new System.Drawing.Size(885, 25);
            this.toolStrip_main.Stretch = true;
            this.toolStrip_main.TabIndex = 2;
            // 
            // mainToolStripBtn_add
            // 
            this.mainToolStripBtn_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainToolStripBtn_add.Image = ((System.Drawing.Image)(resources.GetObject("mainToolStripBtn_add.Image")));
            this.mainToolStripBtn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainToolStripBtn_add.Name = "mainToolStripBtn_add";
            this.mainToolStripBtn_add.Size = new System.Drawing.Size(23, 22);
            this.mainToolStripBtn_add.ToolTipText = "Добавить рецепт";
            this.mainToolStripBtn_add.Click += new System.EventHandler(this.mainToolStripBtn_add_Click);
            // 
            // mainToolStripBtn_remove
            // 
            this.mainToolStripBtn_remove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainToolStripBtn_remove.Image = ((System.Drawing.Image)(resources.GetObject("mainToolStripBtn_remove.Image")));
            this.mainToolStripBtn_remove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainToolStripBtn_remove.Name = "mainToolStripBtn_remove";
            this.mainToolStripBtn_remove.Size = new System.Drawing.Size(23, 22);
            this.mainToolStripBtn_remove.ToolTipText = "Удалить выбранный рецепт";
            this.mainToolStripBtn_remove.Click += new System.EventHandler(this.mainToolStripBtn_remove_Click);
            // 
            // mainToolStripBtn_edit
            // 
            this.mainToolStripBtn_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainToolStripBtn_edit.Image = ((System.Drawing.Image)(resources.GetObject("mainToolStripBtn_edit.Image")));
            this.mainToolStripBtn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainToolStripBtn_edit.Name = "mainToolStripBtn_edit";
            this.mainToolStripBtn_edit.Size = new System.Drawing.Size(23, 22);
            this.mainToolStripBtn_edit.ToolTipText = "Редактировать выбранный рецепт";
            this.mainToolStripBtn_edit.Click += new System.EventHandler(this.mainToolStripBtn_edit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mainToolStripBtn_saveSelected
            // 
            this.mainToolStripBtn_saveSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainToolStripBtn_saveSelected.Image = ((System.Drawing.Image)(resources.GetObject("mainToolStripBtn_saveSelected.Image")));
            this.mainToolStripBtn_saveSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainToolStripBtn_saveSelected.Name = "mainToolStripBtn_saveSelected";
            this.mainToolStripBtn_saveSelected.Size = new System.Drawing.Size(23, 22);
            this.mainToolStripBtn_saveSelected.ToolTipText = "Сохранить выбранный рецепт";
            this.mainToolStripBtn_saveSelected.Click += new System.EventHandler(this.mainToolStripBtn_saveSelected_Click);
            // 
            // mainToolStripBtn_openRecipe
            // 
            this.mainToolStripBtn_openRecipe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainToolStripBtn_openRecipe.Image = ((System.Drawing.Image)(resources.GetObject("mainToolStripBtn_openRecipe.Image")));
            this.mainToolStripBtn_openRecipe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainToolStripBtn_openRecipe.Name = "mainToolStripBtn_openRecipe";
            this.mainToolStripBtn_openRecipe.Size = new System.Drawing.Size(23, 22);
            this.mainToolStripBtn_openRecipe.ToolTipText = "Открыть рецепт";
            this.mainToolStripBtn_openRecipe.Click += new System.EventHandler(this.mainToolStripBtn_openRecipe_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 504);
            this.Controls.Add(this.toolStrip_main);
            this.Controls.Add(this.rtbox_recipe);
            this.Controls.Add(this.dgv_recipes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Книга рецептов";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recipes)).EndInit();
            this.toolStrip_main.ResumeLayout(false);
            this.toolStrip_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_recipes;
        private System.Windows.Forms.RichTextBox rtbox_recipe;
        private System.Windows.Forms.ToolStrip toolStrip_main;
        private System.Windows.Forms.ToolStripButton mainToolStripBtn_add;
        private System.Windows.Forms.ToolStripButton mainToolStripBtn_remove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mainToolStripBtn_saveSelected;
        private System.Windows.Forms.ToolStripButton mainToolStripBtn_openRecipe;
        private System.Windows.Forms.ToolStripButton mainToolStripBtn_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Recipes;
    }
}

