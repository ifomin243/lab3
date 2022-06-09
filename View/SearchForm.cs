using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class SearchForm : Form
    {
        MainForm mainForm;

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            mainForm = (MainForm)Owner;
            lbResult.Items.Clear();
            tbSide.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbParameter.SelectedIndex < 0)
            {
                MessageBox.Show("Укажите параметр из списка для поиска");
                return;
            }
            if (cbFunction.SelectedIndex < 0)
            {
                MessageBox.Show("Укажите функцию из списка для поиска");
                return;
            }
            if (tbSide.TextLength == 0)
            {
                MessageBox.Show("Заполните поле Значение для поиска");
                return;
            }
            if (mainForm.shapes.Count == 0)
            {
                MessageBox.Show("Список фигур пуст!");
                return;
            }
            lbResult.Items.Clear();
            //поиск
            if (cbParameter.SelectedIndex == 0)
            {
                switch (cbFunction.SelectedIndex)
                {
                    case 0:
                        lbResult.Items.AddRange(mainForm.shapes.Where(s => s.Side > double.Parse(tbSide.Text)).ToArray());
                        break;
                    case 1:
                        lbResult.Items.AddRange(mainForm.shapes.Where(s => s.Side < double.Parse(tbSide.Text)).ToArray());
                        break;
                    case 2:
                        lbResult.Items.AddRange(mainForm.shapes.Where(s => s.Side == double.Parse(tbSide.Text)).ToArray());
                        break;
                }
            }
            if (cbParameter.SelectedIndex == 1)
            {
                switch (cbFunction.SelectedIndex)
                {
                    case 0:
                        lbResult.Items.AddRange(mainForm.shapes.Where(s => s.GetVolume() > double.Parse(tbSide.Text)).ToArray());
                        break;
                    case 1:
                        lbResult.Items.AddRange(mainForm.shapes.Where(s => s.GetVolume() < double.Parse(tbSide.Text)).ToArray());
                        break;
                    case 2:
                        lbResult.Items.AddRange(mainForm.shapes.Where(s => s.GetVolume() == double.Parse(tbSide.Text)).ToArray());
                        break;
                }
            }

            for (int i = 0; i < lbResult.Items.Count; i++)
            {
                lbResult.Items[i] = $"{mainForm.GetShapeType((ThreeDimensionalShape)lbResult.Items[i])} " +
                    $"объемом {((ThreeDimensionalShape)lbResult.Items[i]).GetVolume()} куб. см.";
            }
        }
    }
}
