using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        BindingList<Auto> autos;
        public Form1()
        {
            InitializeComponent();
            autos = new BindingList<Auto>();
            dataGridCars.DataSource=autos;

        }

        private void Text_Boxec_Clearing()
        {
            Marka.Clear();
            Model.Clear();
            Owner1.Clear();
            Rel_Year.Clear();
            Tec_Year.Clear();
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            try
            {
                Auto car = new Auto(Marka.Text.ToString(), Model.Text.ToString(),
                    Owner1.Text.ToString(), Convert.ToInt32(Rel_Year.Text), Convert.ToInt32(Tec_Year.Text),
                    0);
                autos.Add(car);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные. Попробуйте снова");
            }
            Text_Boxec_Clearing();
        }

        private void Fine_Enter_Click(object sender, EventArgs e)
        {
            try {

                double fine = Convert.ToDouble(Fine_Box.Text);
                int CarIndex = dataGridCars.SelectedCells[0].RowIndex;
                
                if (fine < 0)
                {
                    fine = 0;
                    MessageBox.Show("Введите положительное число");
                }
                autos[CarIndex].Add_Fine(fine);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не выбрана машина для выписки штрафа");
            }
            catch(FormatException)
            {
                MessageBox.Show("Штраф должен иметь числовое значение");
            }
            Fine_Box.Clear();
            dataGridCars.Refresh();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double pay_fine = Convert.ToDouble(Pay_Fine.Text);
                int CarIndex = dataGridCars.SelectedCells[0].RowIndex;
                if (pay_fine < 0)
                {
                    pay_fine = 0;
                    MessageBox.Show("Введите положительное число");
                }
                autos[CarIndex].Minus_Fine(pay_fine);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не выбрана машина для оплаты штрафа");
            }
            catch (FormatException)
            {
                MessageBox.Show("Сумма оплаты должна иметь числовое значение");
            }
            Pay_Fine.Clear();
            dataGridCars.Refresh();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try {
                int CarIndex = dataGridCars.SelectedCells[0].RowIndex;
                dataGridCars.Rows.RemoveAt(CarIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите машину для удаления");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                int CarIndex = dataGridCars.SelectedCells[0].RowIndex;
                autos[CarIndex].Sell_car(New_Owner.Text.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите машину для продажи");
            }
            New_Owner.Clear();
            dataGridCars.Refresh();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try { 
                int CarIndex = dataGridCars.SelectedCells[0].RowIndex;
                if (Convert.ToInt32(Tech_Box.Text) < 1885 || 
                    Convert.ToInt32(Tech_Box.Text) <= autos[CarIndex].Get_Tec_Year||
                    Convert.ToInt32(Tech_Box.Text)< autos[CarIndex].Get_Rel_Year)
                {
                    throw new Exception();
                }
                autos[CarIndex].Set_Tec_Year(Convert.ToInt32(Tech_Box.Text));
                
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите машину");
            }
            catch(FormatException)
            {
                MessageBox.Show("Введите корректное значение");
            }
            catch (Exception)
            {
                MessageBox.Show("Указана некорректная дата");
            }
            Tech_Box.Clear();
            dataGridCars.Refresh();
        }
    }
}
