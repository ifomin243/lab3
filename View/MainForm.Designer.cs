
namespace View
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreateRandomData = new System.Windows.Forms.Button();
            this.btnRemoveShape = new System.Windows.Forms.Button();
            this.btnAddShape = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискФигурToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.dgv);
            this.groupBox.Controls.Add(this.btnClear);
            this.groupBox.Controls.Add(this.btnCreateRandomData);
            this.groupBox.Controls.Add(this.btnRemoveShape);
            this.groupBox.Controls.Add(this.btnAddShape);
            this.groupBox.Location = new System.Drawing.Point(12, 31);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(782, 461);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Список фигур";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(6, 19);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(770, 408);
            this.dgv.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(6, 433);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreateRandomData
            // 
            this.btnCreateRandomData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateRandomData.Location = new System.Drawing.Point(352, 433);
            this.btnCreateRandomData.Name = "btnCreateRandomData";
            this.btnCreateRandomData.Size = new System.Drawing.Size(172, 23);
            this.btnCreateRandomData.TabIndex = 3;
            this.btnCreateRandomData.Text = "Создать случайные фигуры";
            this.btnCreateRandomData.UseVisualStyleBackColor = true;
            this.btnCreateRandomData.Click += new System.EventHandler(this.btnCreateRandomData_Click);
            // 
            // btnRemoveShape
            // 
            this.btnRemoveShape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveShape.Location = new System.Drawing.Point(530, 433);
            this.btnRemoveShape.Name = "btnRemoveShape";
            this.btnRemoveShape.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveShape.TabIndex = 2;
            this.btnRemoveShape.Text = "Удалить фигуру";
            this.btnRemoveShape.UseVisualStyleBackColor = true;
            this.btnRemoveShape.Click += new System.EventHandler(this.btnRemoveShape_Click);
            // 
            // btnAddShape
            // 
            this.btnAddShape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddShape.Location = new System.Drawing.Point(656, 432);
            this.btnAddShape.Name = "btnAddShape";
            this.btnAddShape.Size = new System.Drawing.Size(120, 23);
            this.btnAddShape.TabIndex = 1;
            this.btnAddShape.Text = "Добавить фигуру";
            this.btnAddShape.UseVisualStyleBackColor = true;
            this.btnAddShape.Click += new System.EventHandler(this.btnAddShape_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.поискToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьСписокToolStripMenuItem,
            this.загрузитьСписокToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // сохранитьСписокToolStripMenuItem
            // 
            this.сохранитьСписокToolStripMenuItem.Name = "сохранитьСписокToolStripMenuItem";
            this.сохранитьСписокToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьСписокToolStripMenuItem.Text = "Сохранить список";
            this.сохранитьСписокToolStripMenuItem.Click += new System.EventHandler(this.сохранитьСписокToolStripMenuItem_Click);
            // 
            // загрузитьСписокToolStripMenuItem
            // 
            this.загрузитьСписокToolStripMenuItem.Name = "загрузитьСписокToolStripMenuItem";
            this.загрузитьСписокToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьСписокToolStripMenuItem.Text = "Загрузить список";
            this.загрузитьСписокToolStripMenuItem.Click += new System.EventHandler(this.загрузитьСписокToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискФигурToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поискФигурToolStripMenuItem
            // 
            this.поискФигурToolStripMenuItem.Name = "поискФигурToolStripMenuItem";
            this.поискФигурToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.поискФигурToolStripMenuItem.Text = "Поиск фигур";
            this.поискФигурToolStripMenuItem.Click += new System.EventHandler(this.поискФигурToolStripMenuItem_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "tds files (*.tds)|*.tds";
            // 
            // sfd
            // 
            this.sfd.FileName = "Shapes.tds";
            this.sfd.Filter = "tds files (*.tds)|*.tds";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 504);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 402);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Треугольные фигуры";
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnRemoveShape;
        private System.Windows.Forms.Button btnAddShape;
        private System.Windows.Forms.Button btnCreateRandomData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискФигурToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьСписокToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

