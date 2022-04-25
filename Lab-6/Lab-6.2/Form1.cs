using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menu11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Объект -> Сотрудник", "Выбор меню", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menu12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Объект -> Клиент", "Выбор меню", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menu13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Объект -> Договор", "Выбор меню", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menu14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Объект -> Поручение", "Выбор меню", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menu15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Объект -> Сделка", "Выбор меню", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menu16_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Закрыть приложение?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dresult == DialogResult.Yes)
                Application.Exit();
        }

        private void menu21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справочник -> Должность", "Выбор меню", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menu22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справочник -> Страна", "Выбор меню", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menu23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справочник -> Регион", "Выбор меню", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menu24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справочник -> Город", "Выбор меню", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menu25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справочник -> ИМНС", "Выбор меню", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menu31_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лабораторная работа 6.2", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void menu10_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.Text = "Объекты";
        }

        private void menu11_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.Text = "Информация о сотрудниках";
        }

        private void menu12_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.Text = "Информация о клиентах";
        }

        private void menu13_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.Text = "Заключение договоров";
        }

        private void menu14_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.Text = "Выданные поручения";
        }

        private void menu15_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.Text = "Заключенные сделки";
        }

        private void menu16_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.Text = "Выход из программы";
        }

        private void menu20_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.Text = "Справочники";
        }

        private void menu21_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.Text = "Справочник должностей";
        }

        private void menu22_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.Text = "Справочник стран";
        }

        private void menu23_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.Text = "Справочник регионов";
        }

        private void menu24_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.Text = "Справочник городов";
        }

        private void menu25_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.Text = "Справочник ИМНС";
        }

        private void menu30_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.Text = "Справка";
        }

        private void menu31_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.Text = "О программе";
        }
    }
}
