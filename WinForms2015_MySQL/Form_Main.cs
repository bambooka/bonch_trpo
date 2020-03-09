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
        string webAppConnection_string = "server=mysql101.1gb.ru;user ID=gb_56104;Password=ad9aab6a823;database=gb_56104;";

        MySqlConnection conn;
        MySqlCommand cmd;

        private void InsertDB(string name, double price, int manufacturer, int unit, int os, int type)//функция добавления данных в БД
        {
            conn = new MySqlConnection(webAppConnection_string);
            conn.Open();
                       
            string query_str = "INSERT INTO smartwatch(name, price, manufacturer, unit, os, type) value (name, price, manufacturer, unit, os, type);";//запрос к БД
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

        private void add_bd_Click(object sender, EventArgs e) {//добавление записи в БД основная проверка//
            string addbd = input_new_name.Text;
            int manufacturer;
            int os;
            int type;
            int price; //?
            int unit;
            //строка пустая добавлять нельзя
            if (addbd == "")  {
                MessageBox.Show("ВВедите название умных часов!", "ОШИБКА:(", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);//исключение
            } else {
                /*
      
               // selected price 
                string selected_price_from = price_from.Text;
                string selected_price_until = price_until.Text;

                if (selected_price_from != "" && selected_price_until != "")
                {
                    str_condition += o_where + o_and + " smartwatch.price > " + selected_price_from + " and " + "smartwatch.price < " + selected_price_until;
                }
                else
                {
                    o_where = "";
                    o_and = " and ";
                }
                */
         
                // selected manufacturer
      
                string select_manufacturer = s_new_manuacture.Text;

                switch (select_manufacturer)
                {
                    case "Apple": manufacturer = 1; break;
                    case "Samsung": manufacturer = 2; break;
                    case "Fitbit": manufacturer = 3; break;
                    case "Wokka": manufacturer = 4; break;
                    case "Sony": manufacturer = 5; break;
                    case "Panasonic": manufacturer = 6; break;
                    case "Smart Kid": manufacturer = 7; break;
                    case "Xiaomi": manufacturer = 8; break;
                    default:
                        manufacturer = 0; break;
                }
              
                //selected os
                
                string select_os = s_new_os.Text;

                switch (select_os)
                {
                    case "Android": os = 1; break;
                    case "X OS": os = 2; break;
                    case "Windows": os = 3; break;
                    case "Windows Phone": os = 4; break;
                    default:
                        os = 0; break;
                }
                
                // selected unit
              
                string select_unit = s_new_unit.Text;

                switch (select_unit)
                {
                    case "Пульс": unit = 1; break;
                    case "Шагомер": unit = 2; break;
                    case "Таймер": unit = 3; break;
                    case "Калории": unit = 4; break;
                    case "Сон": unit = 5; break;
                    default:
                        unit = 0; break;
                }
              
                //selected type

                if (rb_new_smartwatch.Checked)
                {
                    type = 1;
                }

                if (rb_bracelet.Checked)
                {
                    type = 2;
                }
                // ----------------------------------

                /*
                string c1 = s_new_manuacture.Text;
                switch (c1) {
                    case "Большой": before(0,addbd); break;//передаём значения в функцию,
                    case "Средний": before(1,addbd); break;//-||-
                    case "Маленький": before(2,addbd); break;//-||-
                    default://ничего не выбрано добавлять нельзя
                        MessageBox.Show("Выберите произволдителя умных часов!", "ОШИБКА:(", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        break;                        
                }
                */
            }
            // InsertDB(addbd, , manufacturer, unit, os, type);
        }



        
        private void before(int id,string addname)
        {//продолжаем считывать строки
            string plusdist = "";            
            string distbd = ", ";
            //distbd += textBox_Distant_bd.Text;
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

            //InsertDB(id, addname, distbd, plusdist, addprice,addprice1);//передаём переменные в функцию добавления
        }




        private void ShowTables()//волшебная функция считывания данных!!!
        {

            string str_inner_join = " inner join smartwatch_manufacturer ON smartwatch_manufacturer.id = smartwatch.smartwatch_manufacturer_id inner join smartwatch_os ON smartwatch_os.id = smartwatch.smartwatch_os_id inner join smartwatch_type On smartwatch_type.id = smartwatch.smartwatch_type_id inner join smartwatch_unit on smartwatch_unit.id = smartwatch.smartwatch_unit_id ";//делаем из двух таблиц одну
            string str_table = " smartwatch ";
            string str_condition = "";
           
            string o_where = " where ";
            string o_and = "";

            // selected name
            
            string selected_name = input_name.Text;
            if (selected_name != "")
            {
                str_condition += o_where + o_and + " smartwatch.name  LIKE  '" + selected_name + "%'"; o_where = "";
            }
            else
            {
                o_where = " ";
                o_and = " AND";
            }

            // selected price 

            string selected_price_from = price_from.Text;
            string selected_price_until = price_until.Text;

            if(selected_price_from != "" && selected_price_until != "")
            {
                str_condition += o_where + o_and + " smartwatch.price > " + selected_price_from + " and " + "smartwatch.price < " + selected_price_until;
            } else
            {
                o_where = "";
                o_and = " and ";
            }


            // selected manufacturer

            string manufacturer = s_manufacturer.Text;
    
            switch (manufacturer)
            {
                case "Apple": str_condition += o_where + o_and + " smartwatch.smartwatch_manufacturer_id = 1"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                case "Samsung": str_condition += o_where + o_and + " smartwatch.smartwatch_manufacturer_id = 2"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                case "Fitbit": str_condition += o_where + o_and + " smartwatch.smartwatch_manufacturer_id = 3"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                case "Wokka": str_condition += o_where + o_and + " smartwatch.smartwatch_manufacturer_id = 4"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                case "Sony": str_condition += o_where + o_and + " smartwatch.smartwatch_manufacturer_id = 5"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                case "Panasonic": str_condition += o_where + o_and + " smartwatch.smartwatch_manufacturer_id = 6"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                case "Smart Kid": str_condition += o_where + o_and + " smartwatch.smartwatch_manufacturer_id = 7"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                case "Xiaomi": str_condition += o_where + o_and + " smartwatch.smartwatch_manufacturer_id = 8"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                default:
                    o_where = "WHERE"; str_table = "smartwatch "; o_and = ""; break;
            }

            //selected os

            string os = s_os.Text;

            switch (os)
            {
                case "Android": str_condition += o_where + o_and + " smartwatch.smartwatch_os_id = 1"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                case "X OS": str_condition += o_where + o_and + " smartwatch.smartwatch_os_id = 2"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                case "Windows": str_condition += o_where + o_and + " smartwatch.smartwatch_os_id = 3"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                case "Windows Phone": str_condition += o_where + o_and + " smartwatch.smartwatch_os_id = 4"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                default:
                    o_where = "WHERE"; str_table = "smartwatch "; o_and = ""; break;
            }

            // selected unit

            string unit = s_unit.Text;

            switch (unit)
            {
                case "Пульс": str_condition += o_where + o_and + " smartwatch.smartwatch_unit_id = 1"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                case "Шагомер": str_condition += o_where + o_and + " smartwatch.smartwatch_unit_id = 2"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                case "Таймер": str_condition += o_where + o_and + " smartwatch.smartwatch_unit_id = 3"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                case "Калории": str_condition += o_where + o_and + " smartwatch.smartwatch_unit_id = 4"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                case "Сон": str_condition += o_where + o_and + " smartwatch.smartwatch_unit_id = 5"; o_where = ""; o_and = " AND"; str_table = " smartwatch "; break;
                default:
                    o_where = "WHERE"; str_table = "smartwatch "; o_and = ""; break;
            }

            //selected type

            if (rb_smartwatch.Checked)
            {
                str_condition += o_where + o_and + " smartwatch_type_id = 1";
                o_where = "";
                o_and = "and";
            }

            if (rb_bracelet.Checked)
            {
                str_condition += o_where + o_and + " smartwatch_type_id = 2";
                o_where = "";
                o_and = "and";
            }


            // string str_conditions = "kvadro_SIZE.KVDR_size_id, kvadro_SIZE.KVDR_size, Kvadrocopter.KVDR_name AS Kvdr_name, Kvadrocopter.KVDR_image,Kvadrocopter.KVDR_price,  Kvadrocopter.KVDR_max_dist, Kvadrocopter.KVDR_time, Kvadrocopter.KVDR_camera ";
            /*
              string str_conditions = "id, name, Kvadrocopter.KVDR_name AS Kvdr_name, Kvadrocopter.KVDR_image,Kvadrocopter.KVDR_price,  Kvadrocopter.KVDR_max_dist, Kvadrocopter.KVDR_time, Kvadrocopter.KVDR_camera ";
              string str_tabl = "";
              string str_conndition = " INNER JOIN kvadro_SIZE ON kvadro_SIZE.KVDR_size_id = Kvadrocopter.KVDR_size_id ";//делаем из двух таблиц одну

              ///Считываем все radioboxes и TEXTBOXES
              string where = "WHERE";
              string vremenno = " AND";
              string vremenno1 = "";

              //размер
              string v1 = comboBoxsize.Text;
              string search_string1 = textBoxFind_to_Bd.Text;
              if (search_string1 != "") {                           
                  str_conndition += where + " KVDR_name  LIKE  '" + search_string1 + "%'"; where = "";
              } else {
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

              if(rb_apple.Checked){
                  str_conditions += where + vremenno1 + " smartwatch_manufacturer = 1";
              }

              //дистанция     полёта 
              if (rb_apple.Checked) {
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
              string price_from = price_from.Text;
              string price_until = price_until.Text;
              if (price_from == "" && price_until == "")
              {
                  str_conndition += vremenno1 + " KVDR_price between  0.00 AND 1000000.00";
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

              if (caprice_ot == "" && caprice_do == ""){

              }
              else
              {
                  if (caprice_ot == "0"||caprice_ot=="") { caprice_ot = "0"; }
                  if (caprice_do == ""||caprice_do=="0") { caprice_do = "1000"; }                     
                      str_conndition += where+vremenno1 + " KVDR_camera between " + caprice_ot + " AND " + caprice_do;

              }

              show_tabl(str_conditions, str_tabl, str_conndition);//вызываем функцию отображения таблиц
              */

            show_tabl(str_inner_join, str_table, str_condition);//вызываем функцию отображения таблиц
        }
            private void show_tabl(string str_inner_join, string str_table, string str_condition) {
            string str_columns = " smartwatch.name, smartwatch.image, smartwatch.price, smartwatch_manufacturer.name as manufacturer, smartwatch_unit.name as unit, smartwatch_os.name as os, smartwatch_type.name as type ";
            Console.WriteLine(str_inner_join);
            Console.WriteLine(str_table);
            Console.WriteLine(str_condition);
            Console.WriteLine("select * from " + str_table + str_inner_join + str_condition);
            //соединение с БД
            conn = new MySqlConnection(webAppConnection_string); 
            conn.Open();
            DataSet data = new DataSet();
            data.Locale = System.Globalization.CultureInfo.InvariantCulture;
            //формируем запрос
            MySqlDataAdapter masterDataAdapter = new MySqlDataAdapter("select " + str_columns + " from " + str_table + str_inner_join + str_condition, conn);
            masterDataAdapter.Fill(data, str_table);

            BindingSource masterBindingSource = new BindingSource();
            BindingSource detailsBindingSource = new BindingSource();
            masterBindingSource.DataSource = data;
            masterBindingSource.DataMember = str_table;
            if (masterBindingSource.Current == null)
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
            input_name.Text = "";
            rb_smartwatch.Checked = false;
            rb_bracelet.Checked = false;
            s_manufacturer.Text = "";
            s_os.Text = "";
            s_unit.Text = "";
            price_from.Text = "";
            price_until.Text ="";
        }

        private void buttonClear_bd_Click(object sender, EventArgs e)
        {//очиста строк для добавления 
            input_new_name.Clear();
            input_price.Clear();
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

        private void s_new_os_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
