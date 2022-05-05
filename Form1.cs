using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Total_commander
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                dataGridView1.Rows.Add(d.Name);
                dataGridView2.Rows.Add(d.Name);
            }
        }
        private void InitializeTimer()
        {
             
            int counter = 0;
            timer1.Interval = 600;
            timer1.Enabled = true;
            // Hook up timer's tick event handler.  
            this.timer1.Tick += new System.EventHandler(this.toolStripLabel1_Createfile_Click);
            this.timer1.Tick += new System.EventHandler(this.toolStripLabelCreateDir_Click);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Directory.Exists(dataGridView1.SelectedCells[0].Value.ToString()))
                {
                    label_path1.Text = dataGridView1.SelectedCells[0].Value.ToString();
                    string[] dirs = Directory.GetDirectories(dataGridView1.SelectedCells[0].Value.ToString());
                    string[] files = Directory.GetFiles(dataGridView1.SelectedCells[0].Value.ToString());
                    dataGridView1.Rows.Clear();
                    int i = 0;
                    foreach (string dir in dirs)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = dir;
                        i++;
                    }

                    foreach (string file in files)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = file;
                        i++;
                    }
                }
                else if (File.Exists(dataGridView1.SelectedCells[0].Value.ToString()))
                {
                    Process.Start(dataGridView1.SelectedCells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }

        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {if (Directory.Exists(dataGridView2.SelectedCells[0].Value.ToString()))
                {
                    label_path2.Text = dataGridView2.SelectedCells[0].Value.ToString();
                    string[] dirs = Directory.GetDirectories(dataGridView2.SelectedCells[0].Value.ToString());
                    string[] files = Directory.GetFiles(dataGridView2.SelectedCells[0].Value.ToString());
                    dataGridView2.Rows.Clear();
                    int i = 0;
                    foreach (string dir in dirs)
                    {
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[i].Cells[0].Value = dir;
                        i++;
                    }
                                       
                    foreach (string file in files)
                    {
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[i].Cells[0].Value = file;
                        i++;
                    }
                }
            else if (File.Exists(dataGridView2.SelectedCells[0].Value.ToString())) 
                {
                    Process.Start(dataGridView2.SelectedCells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }

        }

        private void toolStripLabelCreateDir_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(textBox_vvod1.Text) || String.IsNullOrEmpty(textBox_vvod2.Text))
                {
                    MessageBox.Show("Напишите название папки", "Создание папки", MessageBoxButtons.OK);
                }
                    string dir = "";
                    if (/*textBox_vvod1.Focused*/String.IsNullOrEmpty(textBox_vvod1.Text))
                    {
                        dir = label_path1.Text + "\\" + textBox_vvod1.Text;
                    }
                    else
                    {
                        if (textBox_vvod2.Focused)
                        {
                            dir = label_path2.Text + "\\" + textBox_vvod2.Text;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }

                    Directory.CreateDirectory(dir);
                    dataGridView1.Rows.Add(dir);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
            
        }

        private void toolStripLabel_ChangeName_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox_vvod1.Text) || String.IsNullOrEmpty(textBox_vvod2.Text))
                {
                    MessageBox.Show("Напишите новое имя", "Переименование", MessageBoxButtons.OK);
                }
                string dir;
                if (textBox_vvod1.Focused)
                {
                    dir = label_path1.Text;
                    string old = dataGridView1.SelectedCells[0].Value.ToString();
                    if (File.Exists(old))
                    {
                        dataGridView1.SelectedCells[0].Value = dir + "\\" + textBox_vvod1.Text;
                        File.Move(old, dataGridView1.SelectedCells[0].Value.ToString());
                    }
                    else
                    {
                        if (Directory.Exists(old))
                        {
                            dataGridView1.SelectedCells[0].Value = dir + "\\" + textBox_vvod1.Text;
                            Directory.Move(old, dataGridView1.SelectedCells[0].Value.ToString());
                        }
                    }

                }
                else
                {
                    if (textBox_vvod2.Focused)
                    {
                        dir = label_path2.Text;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK); 
            }
        }

        private void toolStripLabel1_Createfile_Click(object sender, EventArgs e)
        {
            try
            {
                string dir = "";
                if (textBox_vvod1.Focused)
                {
                    dir = label_path1.Text;
                    dir = dir + "\\" + textBox_vvod1.Text;
                    if (!File.Exists(dir))
                    {
                        File.Create(dir);
                        dataGridView1.Rows.Add(dir);
                    }
                }
                else
                {
                    if (textBox_vvod2.Focused)
                    {
                        dir = label_path2.Text;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                while (String.IsNullOrEmpty(textBox_vvod1.Text))
                {
                    MessageBox.Show("Напишите название файла", "Создание файла", MessageBoxButtons.OK);
                }
                dir = dir + "\\" + textBox_vvod1.Text;
                if (!File.Exists(dir))
                {
                    File.Create(dir);
                    dataGridView1.Rows.Add(dir);
                }
                else
                {
                    MessageBox.Show("Tакой файл есть","Oшибка",MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void toolStripLabel_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string dir = "";
                if (dataGridView2.Focused)
                {

                    dir = label_path2.Text;
                    if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        File.Delete(dir);
                        dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                    }
                }
                else
                {
                    if (dataGridView1.Focused)
                    {
                        dir = label_path1.Text;
                        if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            File.Delete(dir);
                            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }             
                //{
                //    MessageBox.Show("Tакой файл есть", "Oшибка", MessageBoxButtons.OK);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
