using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace WinForms2015_MySQL
{
    public partial class Form_Main : Form
    {
        public Form_About f_about = new Form_About();
        string webAppConnection_string = "server=mysql102.1gb.ru;user ID=gb_56511;Password=baf63e42zyzx;database=gb_56511;";//

        MySqlConnection conn;
        MySqlCommand cmd;

        private void InsertDB(string name, double price, int manufacturer, int unit, int os, int type)//функция добавления данных в БД
        {
            conn = new MySqlConnection(webAppConnection_string);
            conn.Open();
                       
            string query_str = "INSERT INTO smartwatch(name, price, manufacturer, unit, os, type) value ();";//запрос к БД
            cmd = new MySqlCommand(query_str, conn);

            MySqlDataReader data_reader; //ответ с сервера 
            try//если всё ок,то:
            {               
                data_reader = cmd.ExecuteReader();
                MessageBox.Show("Запись '" + name + "' добавлена", "Успех!Молодчик!\n", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (Exception exp)//нет
            {
                string err_string = "Данные не записаны! Сообщение системы\n\"" + exp.ToString() + "\"";
                MessageBox.Show(err_string, "Ошибка записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            { 
                conn.Close();//Соединение завершено 
            }
        }

        public Form_Main()
        {
            InitializeComponent();
            this.BackColor = Color.Bisque;
            this.menuStrip1.BackColor = Color.Bisque;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_about.ShowDialog();//вызываем метод
        }

        private void to_find_Click(object sender, EventArgs e)
        { //click 
            ShowTables();
        }

        private void add_bd_Click(object sender, EventArgs e)
        {//добавление записи в БД основная проверка//
            string addbd = input_new_name.Text;
            if (addbd == "")//строка пустая добавлять нельзя
            {
            MessageBox.Show("ВВедите название квадрокоптера!", "ОШИБКА:(", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);//исключение
            }
            else
            {
                string c1 = s_new_manuacture.Text;                
                switch (c1)
                {
                    case "Большой": before(0,addbd); break;//передаём значения в функцию,
                    case "Средний": before(1,addbd); break;//-||-
                    case "Маленький": before(2,addbd); break;//-||-
                    default://ничего не выбрано добавлять нельзя
                        MessageBox.Show("Выберите размер квадрокоптера!", "ОШИБКА:(", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        break;                        
                }
            }
        }
        
        private void before(int d,string addname)
        {//продолжаем считывать строки
            string plusdist = "";            
            string distbd = ", ";
            distbd += textBox_Distant_bd.Text;
            if (distbd == ", ")
            {
                distbd = "";
            }

            else
            {
                plusdist = ", KVDR_max_dist";
            }
            string addprice = "";
            string addprice1 = ", ";
            addprice1+= input_price.Text;
            if (addprice1 == ", ")
            {
                addprice1 = "";          
            }
            else
            {
                addprice1 += ".00";
                addprice = " , KVDR_price";
            }

            InsertDB(d, addname, distbd, plusdist, addprice,addprice1);//передаём переменные в функцию добавления
        }
        private void ShowTables()//волшебная функция считывания данных!!!
        {
            string str_conditions = "kvadro_SIZE.KVDR_size_id, kvadro_SIZE.KVDR_size, Kvadrocopter.KVDR_name AS Kvdr_name, Kvadrocopter.KVDR_image,Kvadrocopter.KVDR_price,  Kvadrocopter.KVDR_max_dist, Kvadrocopter.KVDR_time, Kvadrocopter.KVDR_camera ";
            string str_tabl = "";
            string str_conndition = " INNER JOIN kvadro_SIZE ON kvadro_SIZE.KVDR_size_id = Kvadrocopter.KVDR_size_id ";//делаем из двух таблиц одну

            ///Считываем все radioboxes и TEXTBOXES
            string where = "WHERE";
            string vremenno = " AND";
            string vremenno1 = "";
            //размер
            string v1 = comboBoxsize.Text;
             string search_string1 = textBoxFind_to_Bd.Text;
            if (search_string1 != "")
            {                           
                str_conndition += where+" KVDR_name  LIKE  '" + search_string1 + "%'"; where = "";
            }
            else
            {
                where = "WHERE";
                vremenno = "";
            }          
            switch (v1)
            {
                case "Большой": str_conndition +=where+vremenno+" KVDR_size = 'Большой'"; where = ""; vremenno1 = " AND"; str_tabl = " Kvadrocopter "; break;
                case "Средний": str_conndition += where+vremenno + " KVDR_size = 'Средний'"; where = ""; vremenno1 = " AND"; str_tabl = " Kvadrocopter "; break;
                case "Маленький": str_conndition +=where+ vremenno + " KVDR_size = 'Маленький' "; where = ""; vremenno1 = " AND"; str_tabl = " Kvadrocopter "; break;
                default:
                   where="WHERE"; str_tabl = "Kvadrocopter "; vremenno1 = "";break;
            }
            
            //дистанция     полёта 
            if (rb_apple.Checked)
            {
                str_conndition += where+vremenno1 + "  KVDR_max_dist  BETWEEN 10 AND 50 ";
            }
            
            if (rb_samsung.Checked)
            {                
                str_conndition += where + vremenno1 + "  KVDR_max_dist BETWEEN 50 AND 500 ";
            }
            if (rb_fitbit.Checked)
            {
                str_conndition += where + vremenno1 + "  KVDR_max_dist BETWEEN 500 AND 5000 ";
            }
            if (rb_apple.Checked && rb_samsung.Checked && rb_fitbit.Checked) {

                vremenno1 = ""; where = "WHERE";
            }
            else
            {
                vremenno1 = " AND";where = "";
            }
            //поиск
           
            //price
            string price_ot = price_from.Text;
            string price_do = price_until.Text;
            if (price_ot == "" && price_do == "")
            {/*
                str_conndition += vremenno1 + " KVDR_price between  0.00 AND 1000000.00";*/
                where = "";
            }
            else
            {
                if (price_ot == "0") { }
                else
                {
                    str_conndition +=where+ vremenno1+ " KVDR_price between " + price_ot + ".00" + " AND " + price_do + ".00";
                }
            }
            //время полёта
            int flight_time = (int)numericUpDownFlightTime.Value;
            if (flight_time > 4)
            {
                str_conndition +=where+ vremenno + " KVDR_time <=" + flight_time;
            }
            else
            {
                where = "";
            }
            //камера
            string caprice_ot = textBoxCamera_ot.Text;
            string caprice_do = textBoxCamera_do.Text;
            if (caprice_ot == "" && caprice_do == ""){

            }
            else
            {
                if (caprice_ot == "0"||caprice_ot=="") { caprice_ot = "0"; }
                if (caprice_do == ""||caprice_do=="0") { caprice_do = "1000"; }                     
                    str_conndition += where+vremenno1 + " KVDR_camera between " + caprice_ot + " AND " + caprice_do;
                
            }
            show_tabl(str_conditions, str_tabl, str_conndition);//вызываем функцию отображения таблиц
        }
            private void show_tabl(string str_conditions,string str_tabl,string str_conndition) {
            //соединение с БД
            conn = new MySqlConnection(webAppConnection_string);
            conn.Open();
            DataSet data = new DataSet();
            data.Locale = System.Globalization.CultureInfo.InvariantCulture;
            //формируем запрос
            MySqlDataAdapter masterDataAdapter = new MySqlDataAdapter("select " + str_conditions + " from " + str_tabl + str_conndition, conn);
            masterDataAdapter.Fill(data, str_tabl);

            BindingSource masterBindingSource = new BindingSource();
            BindingSource detailsBindingSource = new BindingSource();
            masterBindingSource.DataSource = data;
            masterBindingSource.DataMember = str_tabl;
            if (masterBindingSource.Current == null)//
            {
                MessageBox.Show("Запись не найдена", "ОШИБКА:(", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                detailsBindingSource.DataSource = masterBindingSource;
                dataGirdView1.DataSource = masterBindingSource;
            }
        }

    private void button_clear_Click(object sender, EventArgs e)
        {//очищаем фильтры для поиска
            textBoxFind_to_Bd.Text = "";
            comboBoxsize.Text = "";
            rb_apple.Checked = false;
            rb_samsung.Checked = false;
            rb_fitbit.Checked = false;
            price_from.Text = "";
            price_until.Clear();
            numericUpDownFlightTime.Value = 4;
            textBoxCamera_do.Text = "";
            textBoxCamera_ot.Text = "";
        }

        private void buttonClear_bd_Click(object sender, EventArgs e)
        {//очиста строк для добавления 
            input_new_name.Clear();
            input_price.Clear();
            textBox_Distant_bd.Clear();
        }

        private void textBoxPrice_ot_KeyPress(object sender, KeyPressEventArgs e)
        {   char number = e.KeyChar;
            //лочим строку только для цифр и <-
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxPrice_do_KeyPress(object sender, KeyPressEventArgs e)
        {  char number = e.KeyChar;
            //лочим строку только для цифр и <-
            if (!Char.IsDigit(number)&& number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_Distant_bd_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            //лочим строку только для цифр и <-
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxPrice_to_bd_ot_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            //лочим строку только для цифр и <-
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGirdView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ничего не работает", "ОШИБКА:(", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);//нет данных-ошибка в жизни.
        }

        private void button_add_image_Click(object sender, EventArgs e)//добавление изображения 
        {
            string namekvdr = name_device.Text;
            if (namekvdr == "")//исключение
            {
                MessageBox.Show("Введите название квадрокоптера", "ОШИБКА:(", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Выберите изображение(*.JPG; *.PNG) |*.jpg; *.png;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string pathfilename = ofd.FileName;
                    pictureBox_enter_image.Image = Image.FromFile(pathfilename);
                    string filename = Path.GetFileNameWithoutExtension(pathfilename);                    
                    
                    UpdateImage(pathfilename, filename,namekvdr);
                }
            }
        }
        private void UpdateImage(string str_filename, string str_key_value,string namekvdr)//функция добавления изображения
        {
            conn = new MySqlConnection(webAppConnection_string);
            conn.Open();

            try
            {
                MemoryStream ms = new MemoryStream();
                //string bmp_name = @"D:\Portable\Images\Garmin eTrex 20x.png";
                Bitmap im = new Bitmap(str_filename);

                float scaleHeight = (float)100 / (float)im.Height;
                float scaleWidth = (float)100 / (float)im.Width;
                float scale = Math.Min(scaleHeight, scaleWidth);
                int new_width = (int)(im.Width * scale);
                int new_height = (int)(im.Height * scale);
                Image new_im = new Bitmap(im, new Size(new_width, new_height));

                string tmp_name = "tmp.png";
                new_im.Save(tmp_name);

                Bitmap upd_im = new Bitmap(tmp_name);

                upd_im.Save(ms, upd_im.RawFormat);
                byte[] img = ms.ToArray();

                MySqlCommand command = new MySqlCommand("UPDATE Kvadrocopter SET KVDR_image = @KVDR_image WHERE KVDR_name = @KVDR_name;", conn);
                command.Parameters.Add("@KVDR_name", MySqlDbType.VarChar).Value =namekvdr;
                command.Parameters.Add("@KVDR_image", MySqlDbType.Blob).Value = img;

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запрос выполнен");
                }
                else
                {
                    MessageBox.Show("Запрос не выполнен");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void search_kvdr_Click(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelsize_add_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_add_to_bd_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
