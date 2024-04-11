using ClothesShop.Model;
using ClothesShop.Presenter;
using ClothesShop.View;

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;




namespace laba11
{
    public partial class Form1 : Form,IFormView

    {
       private  MainPresenter presenter;
        public Form1()
        {
            presenter = new MainPresenter(this);
            InitializeComponent();

        }
        public void SetDataSource(List<Goods> dataSource)
        {
            
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
         
        }
        private void AddClothes_Button_Click(object sender, EventArgs e)
        {
            presenter.AddClothes(textBox1.Text, textBox2.Text, textBox3.Text,
textBox4.Text, (int)numericUpDown1.Value, Convert.ToDouble(textBox5.Text));

            presenter.UpdateOrderSummary(Convert.ToDouble(textBox5.Text));
        }

        private void AddShoes_Button_Click(object sender, EventArgs e)
        {
            presenter.AddShoes(textBox1.Text, textBox2.Text, textBox3.Text,
textBox4.Text, (int)numericUpDown1.Value, Convert.ToDouble(textBox5.Text));
            presenter.UpdateOrderSummary(Convert.ToDouble(textBox5.Text));
        }

        private void AddAccessories_Button_Click(object sender, EventArgs e)
        {
            presenter.AddAccessories(textBox1.Text, textBox2.Text, textBox3.Text,
textBox4.Text, (int)numericUpDown1.Value, Convert.ToDouble(textBox5.Text));
            presenter.UpdateOrderSummary(Convert.ToDouble(textBox5.Text));
        }


        public void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void UpdateOrderSummary(double totalAmount)
        {
           
        }


        private void DeliveriInfo_Button_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery(comboBox1.Text, dateTimePicker1.Value,
textBox5.Text);
            richTextBox1.Text = delivery.ToString();
        }

        

   

       
    }
}
