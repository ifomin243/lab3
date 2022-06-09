using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ExtendedXmlSerializer;
using Model;
using ExtendedXmlSerializer.Configuration;
using System.Xml;

namespace View
{
    public partial class MainForm : Form
    {
        public List<ThreeDimensionalShape> shapes = new List<ThreeDimensionalShape>();
        private AddShapeForm addShapeForm = new AddShapeForm();
        private SearchForm searchForm = new SearchForm();
        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
            addShapeForm.Owner = this;
            searchForm.Owner = this;
        }

        private void btnAddShape_Click(object sender, EventArgs e)
        {
            addShapeForm.ShowDialog();
        }

        private void btnCreateRandomData_Click(object sender, EventArgs e)
        {
            double mimimum = 0.1;
            double maximum = 10;
            for (int i = dgv.RowCount; i < dgv.RowCount + 10; i++)
            {
                int shapeIndex = random.Next(0, 3);
                if (shapeIndex == 0)
                {
                    double a = random.NextDouble() * (maximum - mimimum) + mimimum;
                    double b = random.NextDouble() * (maximum - mimimum) + mimimum;
                    double c = random.NextDouble() * (maximum - mimimum) + mimimum;
                    shapes.Add(new Parallelepiped(a, b, c));
                }
                if (shapeIndex == 1)
                {
                    double r = random.NextDouble() * (maximum - mimimum) + mimimum;
                    shapes.Add(new Sphere(r));
                }
                if (shapeIndex == 2)
                {
                    double h = random.NextDouble() * (maximum - mimimum) + mimimum;
                    double aa = random.NextDouble() * (maximum - mimimum) + mimimum;
                    shapes.Add(new RegularTriangularPyramid(h, aa));
                }
            }

            LoadData();
        }

        public void LoadData()
        {
            dgv.Rows.Clear();
            if (shapes.Count > 0)
            {
                if (dgv.ColumnCount == 0)
                {
                    dgv.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Тип фигуры",
                        Name = "columnType",
                        DataPropertyName = "Тип фигуры"
                    });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Объем",
                        Name = "columnVolume",
                        DataPropertyName = "Объем"
                    });
                }

                for (int i = 0; i < shapes.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv[0, i].Value = GetShapeType(shapes[i]);
                    dgv[1, i].Value = $"{shapes[i].GetVolume()} куб. см.";
                }
            }
        }

        public string GetShapeType(ThreeDimensionalShape shape)
        {
            if (shape is Parallelepiped)
                return "Параллелепипед";
            else if (shape is Sphere)
                return "Сфера";
            else return "Правильная треугольная пирамида";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void поискФигурToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchForm.ShowDialog();
        }

        private void btnRemoveShape_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                shapes.RemoveAt(dgv.CurrentRow.Index);
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Список пуст!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            dgv.Rows.Clear();
        }

        private void SaveCollectionOfType(object o)
        {
            if (sfd.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = sfd.FileName;
            using (var file = System.IO.File.Open(filename, System.IO.FileMode.OpenOrCreate))
            {
                IExtendedXmlSerializer serializer = new ConfigurationContainer()
                .UseAutoFormatting()
                .UseOptimizedNamespaces()
                .EnableImplicitTyping(typeof(ThreeDimensionalShape))
                .Create();
                var xml = serializer.Serialize(new XmlWriterSettings 
                { 
                    Indent = true, Async = true 
                }, 
                file, shapes);
                file.Close();
            }
            MessageBox.Show("Список сохранен!");
        }

        private void LoadCollectionOfType()
        {
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = ofd.FileName;

            shapes.Clear();
            IExtendedXmlSerializer serializer = new ConfigurationContainer()
                .UseAutoFormatting()
                .UseOptimizedNamespaces()
                .EnableImplicitTyping(typeof(ThreeDimensionalShape))
                .Create();
            using (XmlReader reader = XmlReader.Create(filename, new XmlReaderSettings 
            { 
                Async = true 
            }))
            {
                var xml = serializer.Deserialize(reader);
                shapes = (List<ThreeDimensionalShape>)xml;
                reader.Close();
            }
        }

        private void сохранитьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shapes.Count == 0)
            {
                MessageBox.Show("Список пуст!");
                return;
            }

            SaveCollectionOfType(shapes);
        }

        private void загрузитьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCollectionOfType();
            LoadData();
        }
    }
}
