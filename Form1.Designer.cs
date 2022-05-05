
namespace Total_commander
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_path1 = new System.Windows.Forms.Label();
            this.textBox_vvod1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_path2 = new System.Windows.Forms.Label();
            this.textBox_vvod2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NameColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1_Createfile = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelCreateDir = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_Delete = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_Copy = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_ChangeName = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Ivory;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Ivory;
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 425);
            this.splitContainer1.SplitterDistance = 379;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 379F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label_path1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox_vvod1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(379, 425);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Ivory;
            this.dataGridView1.Location = new System.Drawing.Point(3, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(373, 372);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // NameColumn1
            // 
            this.NameColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn1.HeaderText = "Имя";
            this.NameColumn1.MinimumWidth = 6;
            this.NameColumn1.Name = "NameColumn1";
            this.NameColumn1.ReadOnly = true;
            // 
            // label_path1
            // 
            this.label_path1.AutoSize = true;
            this.label_path1.Location = new System.Drawing.Point(3, 0);
            this.label_path1.Name = "label_path1";
            this.label_path1.Size = new System.Drawing.Size(43, 17);
            this.label_path1.TabIndex = 0;
            this.label_path1.Text = "Путь ";
            // 
            // textBox_vvod1
            // 
            this.textBox_vvod1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_vvod1.Location = new System.Drawing.Point(3, 25);
            this.textBox_vvod1.Name = "textBox_vvod1";
            this.textBox_vvod1.Size = new System.Drawing.Size(373, 22);
            this.textBox_vvod1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label_path2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_vvod2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 425);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label_path2
            // 
            this.label_path2.AutoSize = true;
            this.label_path2.Location = new System.Drawing.Point(3, 0);
            this.label_path2.Name = "label_path2";
            this.label_path2.Size = new System.Drawing.Size(43, 17);
            this.label_path2.TabIndex = 1;
            this.label_path2.Text = "Путь ";
            // 
            // textBox_vvod2
            // 
            this.textBox_vvod2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_vvod2.Location = new System.Drawing.Point(3, 25);
            this.textBox_vvod2.Name = "textBox_vvod2";
            this.textBox_vvod2.Size = new System.Drawing.Size(411, 22);
            this.textBox_vvod2.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn2});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(411, 372);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // NameColumn2
            // 
            this.NameColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn2.HeaderText = "Имя";
            this.NameColumn2.MinimumWidth = 6;
            this.NameColumn2.Name = "NameColumn2";
            this.NameColumn2.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1_Createfile,
            this.toolStripLabelCreateDir,
            this.toolStripLabel_Delete,
            this.toolStripLabel_Copy,
            this.toolStripLabel_ChangeName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1_Createfile
            // 
            this.toolStripLabel1_Createfile.Name = "toolStripLabel1_Createfile";
            this.toolStripLabel1_Createfile.Size = new System.Drawing.Size(103, 28);
            this.toolStripLabel1_Createfile.Text = "Создать файл";
            this.toolStripLabel1_Createfile.Click += new System.EventHandler(this.toolStripLabel1_Createfile_Click);
            // 
            // toolStripLabelCreateDir
            // 
            this.toolStripLabelCreateDir.Name = "toolStripLabelCreateDir";
            this.toolStripLabelCreateDir.Size = new System.Drawing.Size(108, 28);
            this.toolStripLabelCreateDir.Text = "Создать папку";
            this.toolStripLabelCreateDir.Click += new System.EventHandler(this.toolStripLabelCreateDir_Click);
            // 
            // toolStripLabel_Delete
            // 
            this.toolStripLabel_Delete.Name = "toolStripLabel_Delete";
            this.toolStripLabel_Delete.Size = new System.Drawing.Size(65, 28);
            this.toolStripLabel_Delete.Text = "Удалить";
            this.toolStripLabel_Delete.Click += new System.EventHandler(this.toolStripLabel_Delete_Click);
            // 
            // toolStripLabel_Copy
            // 
            this.toolStripLabel_Copy.Name = "toolStripLabel_Copy";
            this.toolStripLabel_Copy.Size = new System.Drawing.Size(93, 28);
            this.toolStripLabel_Copy.Text = "Копировать";
            // 
            // toolStripLabel_ChangeName
            // 
            this.toolStripLabel_ChangeName.Name = "toolStripLabel_ChangeName";
            this.toolStripLabel_ChangeName.Size = new System.Drawing.Size(121, 28);
            this.toolStripLabel_ChangeName.Text = "Переименовать";
            this.toolStripLabel_ChangeName.Click += new System.EventHandler(this.toolStripLabel_ChangeName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TOTAL COMMANDER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1_Createfile;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCreateDir;
        private System.Windows.Forms.Label label_path1;
        private System.Windows.Forms.Label label_path2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Delete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Copy;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_ChangeName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox_vvod1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_vvod2;
        private System.Windows.Forms.Timer timer1;
    }
}

