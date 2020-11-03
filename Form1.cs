﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt_9_1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
          Point tmp_location;
          int _w = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
          int _h = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;
          Random rnd = new Random();
          // переводим координату X в строку и записывает в поля ввода
          textBox1.Text = e.X.ToString();
          // переводим координату Y в строку и записывает в поля ввода
          textBox2.Text = e.Y.ToString();
          // если координата по оси X и по оси Y лежит в очерчиваемом вокруг кнопки "да, конечно" квадрате
          if (e.X > 170 && e.X < 355 && e.Y > 200 && e.Y < 260)
          {
          // запоминаем текущее положение окна
          tmp_location = this.Location;
          // генерируем перемещения по осям X и Y и прибавляем их к хранимому значению текущего положения окна
          // числа генерируются в диапазоне от -100 до 100
          tmp_location.X += rnd.Next(-100, 100);
          tmp_location.Y += rnd.Next(-100, 100);
          // если окно вылезло за пределы экрана по одной из осей
          if (tmp_location.X < 0 || tmp_location.X > (_w - this.Width / 2) ||
          tmp_location.Y < 0 || tmp_location.Y > (_h - this.Height / 2))
          { // новыми координатами станет центр окна
            tmp_location.X = _w / 2;
            tmp_location.Y = _h / 2;
          }
          // обновляем положение окна, на новое сгенерированное
          this.Location = tmp_location;
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      // Вывести сообщение с текстом "Вы усердны"
      MessageBox.Show("ты что дурак");
      // Завершить приложение
      Application.Exit();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // Вывести сообщение, с текстом "Мы не сомневались в вешем безразличии"
      // второй параметр - заголовок окна сообщения "Внимание"
      // MessageBoxButtons.OK - тип размещаемой кнопки на форме сообщения
      // MessageBoxIcon.Information - тип сообщения - будет иметь иконку"информация" и соответствующий звуковой сигнал
      MessageBox.Show("иди колоду чеши свою", "Внимание",
      MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
