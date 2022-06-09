using System;
using System.Drawing;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class AddShapeForm : Form
    {
        MainForm mainForm;

        public AddShapeForm()
        {
            InitializeComponent();

            MaximumSize = Size;
            MinimumSize = Size;
        }

        private void AddShapeForm_Load(object sender, EventArgs e)
        {
            mainForm = (MainForm)Owner;

            if (Controls.ContainsKey("groupBox"))
            {
                Controls.RemoveByKey("groupBox");
            }
        }

        private void cbShapeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Controls.ContainsKey("groupBox"))
            {
                Controls.RemoveByKey("groupBox");
            }

            GroupBox groupBox = new GroupBox 
            { 
                Size = new Size(355, 214), 
                Location = new Point(15, 55), 
                Name = "groupBox", 
                Text = cbShapeType.SelectedItem.ToString()
            };

            switch (cbShapeType.SelectedIndex)
            {
                case 0:
                    Label labelA = new Label
                    {
                        Location = new Point(5, 25),
                        AutoSize = true,
                        Text = "A = "
                    };
                    Label labelB = new Label
                    {
                        Location = new Point(5, 50),
                        AutoSize = true,
                        Text = "B = "
                    };
                    Label labelC = new Label
                    {
                        Location = new Point(5, 75),
                        AutoSize = true,
                        Text = "C = "
                    };
                    groupBox.Controls.Add(labelA);
                    groupBox.Controls.Add(labelB);
                    groupBox.Controls.Add(labelC);
                    groupBox.Controls.Add(new TextBox
                    {
                        Location = new Point(37, 22),
                        Size = new Size(312, 20),
                        Name = "tbA",
                        Tag = "Длина ребра параллелепипеда (A)",
                        TabIndex = 0
                    });
                    groupBox.Controls.Add(new TextBox
                    {
                        Location = new Point(37, 47),
                        Size = new Size(312, 20),
                        Name = "tbB",
                        Tag = "Длина ребра параллелепипеда (B)",
                        TabIndex = 1
                    });
                    groupBox.Controls.Add(new TextBox
                    {
                        Location = new Point(37, 72),
                        Size = new Size(312, 20),
                        Name = "tbC",
                        Tag = "Длина ребра параллелепипеда (C)",
                        TabIndex = 2
                    });
                    break;
                case 1:
                    Label labelR = new Label
                    {
                        Location = new Point(5, 25),
                        AutoSize = true,
                        Text = "R = "
                    };
                    groupBox.Controls.Add(labelR);
                    groupBox.Controls.Add(new TextBox
                    {
                        Location = new Point(37, 22),
                        Size = new Size(312, 20),
                        Name = "tbR",
                        Tag = "Радиус сферы (R)",
                        TabIndex = 0
                    });
                    break;
                case 2:
                    Label labelH = new Label
                    {
                        Location = new Point(5, 25),
                        AutoSize = true,
                        Text = "H = "
                    };
                    Label labelAA = new Label
                    {
                        Location = new Point(5, 50),
                        AutoSize = true,
                        Text = "A = "
                    };
                    groupBox.Controls.Add(labelH);
                    groupBox.Controls.Add(labelAA);
                    groupBox.Controls.Add(new TextBox
                    {
                        Location = new Point(37, 22),
                        Size = new Size(312, 20),
                        Name = "tbH",
                        Tag = "Высота (H)",
                        TabIndex = 0
                    });
                    groupBox.Controls.Add(new TextBox
                    {
                        Location = new Point(37, 47),
                        Size = new Size(312, 20),
                        Name = "tbA",
                        Tag = "Длина основания пирамида (A)",
                        TabIndex = 1
                    });
                    break;
            }
            
            Controls.Add(groupBox);

            foreach (Control control in groupBox.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    ((TextBox)control).KeyPress += textBox_KeyPress;
                }
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            //цифры, клавиша BackSpace и запятая в ASCII
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) 
            {
                e.Handled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Control[] controls = Controls.Find("groupBox", true);
            if (controls.Length == 0)
                return;

            GroupBox groupBox = (GroupBox)controls[0];

            foreach (Control control in groupBox.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    if (((TextBox)control).TextLength == 0)
                    {
                        MessageBox.Show($"Заполните поле: {((TextBox)control).Tag}");
                        return;
                    }
                    if (double.TryParse(((TextBox)control).Text, out double d))
                    {
                        if (d <= 0)
                        {
                            MessageBox.Show($"Значение поля: {((TextBox)control).Tag} не может быть меньше, либо равно 0");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Входная строка имела не верный формат");
                        return;
                    }
                }
            }

            switch (cbShapeType.SelectedIndex)
            {
                case 0:
                    mainForm.shapes.Add(new Parallelepiped
                        (
                            double.Parse(((TextBox)groupBox.Controls.Find("tbA", true)[0]).Text),
                            double.Parse(((TextBox)groupBox.Controls.Find("tbB", true)[0]).Text),
                            double.Parse(((TextBox)groupBox.Controls.Find("tbC", true)[0]).Text)
                        ));
                    break;
                case 1:
                    mainForm.shapes.Add(new Sphere
                        (
                            double.Parse(((TextBox)groupBox.Controls.Find("tbR", true)[0]).Text)
                        ));
                    break;
                case 2:
                    mainForm.shapes.Add(new RegularTriangularPyramid
                        (
                            double.Parse(((TextBox)groupBox.Controls.Find("tbH", true)[0]).Text),
                            double.Parse(((TextBox)groupBox.Controls.Find("tbA", true)[0]).Text)
                        ));
                    break;
            }

            mainForm.LoadData();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
