namespace WinForms2015_MySQL
{
  partial class Form_Main
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if(disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelDist = new System.Windows.Forms.Label();
            this.rb_apple = new System.Windows.Forms.RadioButton();
            this.rb_samsung = new System.Windows.Forms.RadioButton();
            this.rb_fitbit = new System.Windows.Forms.RadioButton();
            this.labelPrice = new System.Windows.Forms.Label();
            this.price_from = new System.Windows.Forms.TextBox();
            this.labelPrice_do = new System.Windows.Forms.Label();
            this.price_until = new System.Windows.Forms.TextBox();
            this.labelflight_time = new System.Windows.Forms.Label();
            this.add_kvdr = new System.Windows.Forms.Label();
            this.labelsize_add = new System.Windows.Forms.Label();
            this.s_new_manuacture = new System.Windows.Forms.ComboBox();
            this.labelAdd_to_bd = new System.Windows.Forms.Label();
            this.input_new_name = new System.Windows.Forms.TextBox();
            this.labelmax_dist = new System.Windows.Forms.Label();
            this.input_price = new System.Windows.Forms.TextBox();
            this.labelPrice_to_add = new System.Windows.Forms.Label();
            this.btn_add_bd = new System.Windows.Forms.Button();
            this.search_kvdr = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.dataGirdView1 = new System.Windows.Forms.DataGridView();
            this.btn_clear_filter = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add_image = new System.Windows.Forms.Button();
            this.pictureBox_enter_image = new System.Windows.Forms.PictureBox();
            this.name_device = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_wokka = new System.Windows.Forms.RadioButton();
            this.rb_smart_kid = new System.Windows.Forms.RadioButton();
            this.rb_panasonic = new System.Windows.Forms.RadioButton();
            this.rb_sony = new System.Windows.Forms.RadioButton();
            this.rb_xiaomi = new System.Windows.Forms.RadioButton();
            this.rb_smartwatch = new System.Windows.Forms.RadioButton();
            this.rb_bracelet = new System.Windows.Forms.RadioButton();
            this.rb_android = new System.Windows.Forms.RadioButton();
            this.rb_xos = new System.Windows.Forms.RadioButton();
            this.rb_windows = new System.Windows.Forms.RadioButton();
            this.rb_windows_phone = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_timer = new System.Windows.Forms.RadioButton();
            this.rb_steps = new System.Windows.Forms.RadioButton();
            this.rb_bpm = new System.Windows.Forms.RadioButton();
            this.rb_sleep = new System.Windows.Forms.RadioButton();
            this.rb_calories = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_new_bracelet = new System.Windows.Forms.RadioButton();
            this.rb_new_smartwatch = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.s_new_os = new System.Windows.Forms.ComboBox();
            this.s_new_unit = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirdView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_enter_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.AliceBlue;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.закрытьToolStripMenuItem.Text = "Выход";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Maroon;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(257, 39);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(160, 13);
            this.labelSize.TabIndex = 4;
            this.labelSize.Text = "Выберите тип устройства";
            // 
            // labelDist
            // 
            this.labelDist.AutoSize = true;
            this.labelDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDist.Location = new System.Drawing.Point(2, 166);
            this.labelDist.Name = "labelDist";
            this.labelDist.Size = new System.Drawing.Size(99, 13);
            this.labelDist.TabIndex = 6;
            this.labelDist.Text = "Производитель";
            // 
            // rb_apple
            // 
            this.rb_apple.AutoSize = true;
            this.rb_apple.Location = new System.Drawing.Point(5, 211);
            this.rb_apple.Name = "rb_apple";
            this.rb_apple.Size = new System.Drawing.Size(52, 17);
            this.rb_apple.TabIndex = 9;
            this.rb_apple.TabStop = true;
            this.rb_apple.Text = "Apple";
            this.rb_apple.UseVisualStyleBackColor = true;
            // 
            // rb_samsung
            // 
            this.rb_samsung.AutoSize = true;
            this.rb_samsung.Location = new System.Drawing.Point(5, 234);
            this.rb_samsung.Name = "rb_samsung";
            this.rb_samsung.Size = new System.Drawing.Size(71, 17);
            this.rb_samsung.TabIndex = 10;
            this.rb_samsung.TabStop = true;
            this.rb_samsung.Text = "Samsumg";
            this.rb_samsung.UseVisualStyleBackColor = true;
            // 
            // rb_fitbit
            // 
            this.rb_fitbit.AutoSize = true;
            this.rb_fitbit.Location = new System.Drawing.Point(5, 259);
            this.rb_fitbit.Name = "rb_fitbit";
            this.rb_fitbit.Size = new System.Drawing.Size(47, 17);
            this.rb_fitbit.TabIndex = 11;
            this.rb_fitbit.TabStop = true;
            this.rb_fitbit.Text = "Fitbit";
            this.rb_fitbit.UseVisualStyleBackColor = true;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(7, 134);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(54, 13);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "Цена от";
            // 
            // price_from
            // 
            this.price_from.ForeColor = System.Drawing.SystemColors.WindowText;
            this.price_from.Location = new System.Drawing.Point(69, 128);
            this.price_from.Name = "price_from";
            this.price_from.Size = new System.Drawing.Size(69, 20);
            this.price_from.TabIndex = 13;
            this.price_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_ot_KeyPress);
            // 
            // labelPrice_do
            // 
            this.labelPrice_do.AutoSize = true;
            this.labelPrice_do.Location = new System.Drawing.Point(144, 131);
            this.labelPrice_do.Name = "labelPrice_do";
            this.labelPrice_do.Size = new System.Drawing.Size(22, 13);
            this.labelPrice_do.TabIndex = 14;
            this.labelPrice_do.Text = "До";
            // 
            // price_until
            // 
            this.price_until.Location = new System.Drawing.Point(172, 128);
            this.price_until.Name = "price_until";
            this.price_until.Size = new System.Drawing.Size(69, 20);
            this.price_until.TabIndex = 15;
            this.price_until.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_do_KeyPress);
            // 
            // labelflight_time
            // 
            this.labelflight_time.AutoSize = true;
            this.labelflight_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelflight_time.Location = new System.Drawing.Point(2, 282);
            this.labelflight_time.Name = "labelflight_time";
            this.labelflight_time.Size = new System.Drawing.Size(147, 13);
            this.labelflight_time.TabIndex = 16;
            this.labelflight_time.Text = "Операционная система";
            // 
            // add_kvdr
            // 
            this.add_kvdr.AutoSize = true;
            this.add_kvdr.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_kvdr.ForeColor = System.Drawing.Color.Red;
            this.add_kvdr.Location = new System.Drawing.Point(447, 24);
            this.add_kvdr.Name = "add_kvdr";
            this.add_kvdr.Size = new System.Drawing.Size(247, 23);
            this.add_kvdr.TabIndex = 22;
            this.add_kvdr.Text = "Добавление Квадрокоптера";
            // 
            // labelsize_add
            // 
            this.labelsize_add.AutoSize = true;
            this.labelsize_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelsize_add.Location = new System.Drawing.Point(448, 117);
            this.labelsize_add.Name = "labelsize_add";
            this.labelsize_add.Size = new System.Drawing.Size(99, 13);
            this.labelsize_add.TabIndex = 23;
            this.labelsize_add.Text = "Производитель";
            this.labelsize_add.Click += new System.EventHandler(this.labelsize_add_Click);
            // 
            // s_new_manuacture
            // 
            this.s_new_manuacture.FormattingEnabled = true;
            this.s_new_manuacture.Items.AddRange(new object[] {
            "Маленький",
            "Средний",
            "Большой"});
            this.s_new_manuacture.Location = new System.Drawing.Point(601, 114);
            this.s_new_manuacture.Name = "s_new_manuacture";
            this.s_new_manuacture.Size = new System.Drawing.Size(121, 21);
            this.s_new_manuacture.TabIndex = 24;
            // 
            // labelAdd_to_bd
            // 
            this.labelAdd_to_bd.AutoSize = true;
            this.labelAdd_to_bd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdd_to_bd.Location = new System.Drawing.Point(448, 67);
            this.labelAdd_to_bd.Name = "labelAdd_to_bd";
            this.labelAdd_to_bd.Size = new System.Drawing.Size(219, 13);
            this.labelAdd_to_bd.TabIndex = 25;
            this.labelAdd_to_bd.Text = "Введите название для добавления:";
            // 
            // input_new_name
            // 
            this.input_new_name.Location = new System.Drawing.Point(451, 83);
            this.input_new_name.Name = "input_new_name";
            this.input_new_name.Size = new System.Drawing.Size(216, 20);
            this.input_new_name.TabIndex = 26;
            this.input_new_name.TextChanged += new System.EventHandler(this.textBox_add_to_bd_TextChanged);
            // 
            // labelmax_dist
            // 
            this.labelmax_dist.AutoSize = true;
            this.labelmax_dist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmax_dist.Location = new System.Drawing.Point(448, 147);
            this.labelmax_dist.Name = "labelmax_dist";
            this.labelmax_dist.Size = new System.Drawing.Size(147, 13);
            this.labelmax_dist.TabIndex = 27;
            this.labelmax_dist.Text = "Операционная система";
            // 
            // input_price
            // 
            this.input_price.Location = new System.Drawing.Point(601, 208);
            this.input_price.Name = "input_price";
            this.input_price.Size = new System.Drawing.Size(121, 20);
            this.input_price.TabIndex = 30;
            this.input_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_to_bd_ot_KeyPress);
            // 
            // labelPrice_to_add
            // 
            this.labelPrice_to_add.AutoSize = true;
            this.labelPrice_to_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice_to_add.Location = new System.Drawing.Point(448, 214);
            this.labelPrice_to_add.Name = "labelPrice_to_add";
            this.labelPrice_to_add.Size = new System.Drawing.Size(41, 13);
            this.labelPrice_to_add.TabIndex = 29;
            this.labelPrice_to_add.Text = "Цена ";
            // 
            // btn_add_bd
            // 
            this.btn_add_bd.Location = new System.Drawing.Point(732, 294);
            this.btn_add_bd.Name = "btn_add_bd";
            this.btn_add_bd.Size = new System.Drawing.Size(99, 23);
            this.btn_add_bd.TabIndex = 33;
            this.btn_add_bd.Text = "Добавить в БД";
            this.btn_add_bd.UseVisualStyleBackColor = true;
            this.btn_add_bd.Click += new System.EventHandler(this.add_bd_Click);
            // 
            // search_kvdr
            // 
            this.search_kvdr.AutoSize = true;
            this.search_kvdr.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_kvdr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.search_kvdr.Location = new System.Drawing.Point(6, 29);
            this.search_kvdr.Name = "search_kvdr";
            this.search_kvdr.Size = new System.Drawing.Size(214, 23);
            this.search_kvdr.TabIndex = 34;
            this.search_kvdr.Text = "Умные часы и браслеты";
            this.search_kvdr.Click += new System.EventHandler(this.search_kvdr_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(238, 335);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(125, 34);
            this.btn_find.TabIndex = 35;
            this.btn_find.Text = "Поиск / Обновить";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.to_find_Click);
            // 
            // dataGirdView1
            // 
            this.dataGirdView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGirdView1.Location = new System.Drawing.Point(10, 375);
            this.dataGirdView1.Name = "dataGirdView1";
            this.dataGirdView1.Size = new System.Drawing.Size(845, 279);
            this.dataGirdView1.TabIndex = 36;
            this.dataGirdView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGirdView1_DataError);
            // 
            // btn_clear_filter
            // 
            this.btn_clear_filter.Location = new System.Drawing.Point(238, 295);
            this.btn_clear_filter.Name = "btn_clear_filter";
            this.btn_clear_filter.Size = new System.Drawing.Size(125, 34);
            this.btn_clear_filter.TabIndex = 38;
            this.btn_clear_filter.Text = "Очистить все фильтры";
            this.btn_clear_filter.UseVisualStyleBackColor = true;
            this.btn_clear_filter.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(732, 323);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(99, 23);
            this.btn_clear.TabIndex = 41;
            this.btn_clear.Text = "Очистить ";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.buttonClear_bd_Click);
            // 
            // btn_add_image
            // 
            this.btn_add_image.Location = new System.Drawing.Point(573, 310);
            this.btn_add_image.Name = "btn_add_image";
            this.btn_add_image.Size = new System.Drawing.Size(121, 36);
            this.btn_add_image.TabIndex = 42;
            this.btn_add_image.Text = "Добавить изображение";
            this.btn_add_image.UseVisualStyleBackColor = true;
            this.btn_add_image.Click += new System.EventHandler(this.button_add_image_Click);
            // 
            // pictureBox_enter_image
            // 
            this.pictureBox_enter_image.Location = new System.Drawing.Point(401, 239);
            this.pictureBox_enter_image.Name = "pictureBox_enter_image";
            this.pictureBox_enter_image.Size = new System.Drawing.Size(157, 113);
            this.pictureBox_enter_image.TabIndex = 43;
            this.pictureBox_enter_image.TabStop = false;
            // 
            // name_device
            // 
            this.name_device.Location = new System.Drawing.Point(573, 284);
            this.name_device.Name = "name_device";
            this.name_device.Size = new System.Drawing.Size(121, 20);
            this.name_device.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Название устройства";
            // 
            // rb_wokka
            // 
            this.rb_wokka.AutoSize = true;
            this.rb_wokka.Location = new System.Drawing.Point(75, 210);
            this.rb_wokka.Name = "rb_wokka";
            this.rb_wokka.Size = new System.Drawing.Size(60, 17);
            this.rb_wokka.TabIndex = 46;
            this.rb_wokka.TabStop = true;
            this.rb_wokka.Text = "Wokka";
            this.rb_wokka.UseVisualStyleBackColor = true;
            // 
            // rb_smart_kid
            // 
            this.rb_smart_kid.AutoSize = true;
            this.rb_smart_kid.Location = new System.Drawing.Point(75, 233);
            this.rb_smart_kid.Name = "rb_smart_kid";
            this.rb_smart_kid.Size = new System.Drawing.Size(70, 17);
            this.rb_smart_kid.TabIndex = 47;
            this.rb_smart_kid.TabStop = true;
            this.rb_smart_kid.Text = "Smart Kid";
            this.rb_smart_kid.UseVisualStyleBackColor = true;
            // 
            // rb_panasonic
            // 
            this.rb_panasonic.AutoSize = true;
            this.rb_panasonic.Location = new System.Drawing.Point(74, 259);
            this.rb_panasonic.Name = "rb_panasonic";
            this.rb_panasonic.Size = new System.Drawing.Size(75, 17);
            this.rb_panasonic.TabIndex = 48;
            this.rb_panasonic.TabStop = true;
            this.rb_panasonic.Text = "Panasonic";
            this.rb_panasonic.UseVisualStyleBackColor = true;
            // 
            // rb_sony
            // 
            this.rb_sony.AutoSize = true;
            this.rb_sony.Location = new System.Drawing.Point(75, 187);
            this.rb_sony.Name = "rb_sony";
            this.rb_sony.Size = new System.Drawing.Size(49, 17);
            this.rb_sony.TabIndex = 49;
            this.rb_sony.TabStop = true;
            this.rb_sony.Text = "Sony";
            this.rb_sony.UseVisualStyleBackColor = true;
            // 
            // rb_xiaomi
            // 
            this.rb_xiaomi.AutoSize = true;
            this.rb_xiaomi.Location = new System.Drawing.Point(5, 188);
            this.rb_xiaomi.Name = "rb_xiaomi";
            this.rb_xiaomi.Size = new System.Drawing.Size(56, 17);
            this.rb_xiaomi.TabIndex = 50;
            this.rb_xiaomi.TabStop = true;
            this.rb_xiaomi.Text = "Xiaomi";
            this.rb_xiaomi.UseVisualStyleBackColor = true;
            // 
            // rb_smartwatch
            // 
            this.rb_smartwatch.AutoSize = true;
            this.rb_smartwatch.Location = new System.Drawing.Point(328, 67);
            this.rb_smartwatch.Name = "rb_smartwatch";
            this.rb_smartwatch.Size = new System.Drawing.Size(89, 17);
            this.rb_smartwatch.TabIndex = 51;
            this.rb_smartwatch.TabStop = true;
            this.rb_smartwatch.Text = "Умные часы";
            this.rb_smartwatch.UseVisualStyleBackColor = true;
            // 
            // rb_bracelet
            // 
            this.rb_bracelet.AutoSize = true;
            this.rb_bracelet.Location = new System.Drawing.Point(260, 67);
            this.rb_bracelet.Name = "rb_bracelet";
            this.rb_bracelet.Size = new System.Drawing.Size(67, 17);
            this.rb_bracelet.TabIndex = 52;
            this.rb_bracelet.TabStop = true;
            this.rb_bracelet.Text = "Браслет";
            this.rb_bracelet.UseVisualStyleBackColor = true;
            // 
            // rb_android
            // 
            this.rb_android.AutoSize = true;
            this.rb_android.Location = new System.Drawing.Point(5, 312);
            this.rb_android.Name = "rb_android";
            this.rb_android.Size = new System.Drawing.Size(61, 17);
            this.rb_android.TabIndex = 53;
            this.rb_android.TabStop = true;
            this.rb_android.Text = "Android";
            this.rb_android.UseVisualStyleBackColor = true;
            // 
            // rb_xos
            // 
            this.rb_xos.AutoSize = true;
            this.rb_xos.Location = new System.Drawing.Point(5, 335);
            this.rb_xos.Name = "rb_xos";
            this.rb_xos.Size = new System.Drawing.Size(50, 17);
            this.rb_xos.TabIndex = 54;
            this.rb_xos.TabStop = true;
            this.rb_xos.Text = "X OS";
            this.rb_xos.UseVisualStyleBackColor = true;
            // 
            // rb_windows
            // 
            this.rb_windows.AutoSize = true;
            this.rb_windows.Location = new System.Drawing.Point(84, 312);
            this.rb_windows.Name = "rb_windows";
            this.rb_windows.Size = new System.Drawing.Size(69, 17);
            this.rb_windows.TabIndex = 55;
            this.rb_windows.TabStop = true;
            this.rb_windows.Text = "Windows";
            this.rb_windows.UseVisualStyleBackColor = true;
            // 
            // rb_windows_phone
            // 
            this.rb_windows_phone.AutoSize = true;
            this.rb_windows_phone.Location = new System.Drawing.Point(85, 335);
            this.rb_windows_phone.Name = "rb_windows_phone";
            this.rb_windows_phone.Size = new System.Drawing.Size(103, 17);
            this.rb_windows_phone.TabIndex = 56;
            this.rb_windows_phone.TabStop = true;
            this.rb_windows_phone.Text = "Windows Phone";
            this.rb_windows_phone.UseVisualStyleBackColor = true;
            this.rb_windows_phone.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(261, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Измерение";
            // 
            // rb_timer
            // 
            this.rb_timer.AutoSize = true;
            this.rb_timer.Location = new System.Drawing.Point(263, 164);
            this.rb_timer.Name = "rb_timer";
            this.rb_timer.Size = new System.Drawing.Size(64, 17);
            this.rb_timer.TabIndex = 58;
            this.rb_timer.TabStop = true;
            this.rb_timer.Text = "Таймер";
            this.rb_timer.UseVisualStyleBackColor = true;
            // 
            // rb_steps
            // 
            this.rb_steps.AutoSize = true;
            this.rb_steps.Location = new System.Drawing.Point(264, 134);
            this.rb_steps.Name = "rb_steps";
            this.rb_steps.Size = new System.Drawing.Size(71, 17);
            this.rb_steps.TabIndex = 59;
            this.rb_steps.TabStop = true;
            this.rb_steps.Text = "Шагомер";
            this.rb_steps.UseVisualStyleBackColor = true;
            // 
            // rb_bpm
            // 
            this.rb_bpm.AutoSize = true;
            this.rb_bpm.Location = new System.Drawing.Point(264, 199);
            this.rb_bpm.Name = "rb_bpm";
            this.rb_bpm.Size = new System.Drawing.Size(56, 17);
            this.rb_bpm.TabIndex = 60;
            this.rb_bpm.TabStop = true;
            this.rb_bpm.Text = "Пульс";
            this.rb_bpm.UseVisualStyleBackColor = true;
            // 
            // rb_sleep
            // 
            this.rb_sleep.AutoSize = true;
            this.rb_sleep.Location = new System.Drawing.Point(263, 233);
            this.rb_sleep.Name = "rb_sleep";
            this.rb_sleep.Size = new System.Drawing.Size(44, 17);
            this.rb_sleep.TabIndex = 61;
            this.rb_sleep.TabStop = true;
            this.rb_sleep.Text = "Сон";
            this.rb_sleep.UseVisualStyleBackColor = true;
            // 
            // rb_calories
            // 
            this.rb_calories.AutoSize = true;
            this.rb_calories.Location = new System.Drawing.Point(264, 261);
            this.rb_calories.Name = "rb_calories";
            this.rb_calories.Size = new System.Drawing.Size(68, 17);
            this.rb_calories.TabIndex = 62;
            this.rb_calories.TabStop = true;
            this.rb_calories.Text = "Калории";
            this.rb_calories.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Выберите наименование";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // input_name
            // 
            this.input_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.input_name.Location = new System.Drawing.Point(10, 88);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(231, 20);
            this.input_name.TabIndex = 64;
            this.input_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(740, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Тип";
            // 
            // rb_new_bracelet
            // 
            this.rb_new_bracelet.AutoSize = true;
            this.rb_new_bracelet.Location = new System.Drawing.Point(743, 118);
            this.rb_new_bracelet.Name = "rb_new_bracelet";
            this.rb_new_bracelet.Size = new System.Drawing.Size(67, 17);
            this.rb_new_bracelet.TabIndex = 67;
            this.rb_new_bracelet.TabStop = true;
            this.rb_new_bracelet.Text = "Браслет";
            this.rb_new_bracelet.UseVisualStyleBackColor = true;
            // 
            // rb_new_smartwatch
            // 
            this.rb_new_smartwatch.AutoSize = true;
            this.rb_new_smartwatch.Location = new System.Drawing.Point(743, 95);
            this.rb_new_smartwatch.Name = "rb_new_smartwatch";
            this.rb_new_smartwatch.Size = new System.Drawing.Size(89, 17);
            this.rb_new_smartwatch.TabIndex = 68;
            this.rb_new_smartwatch.TabStop = true;
            this.rb_new_smartwatch.Text = "Умные часы";
            this.rb_new_smartwatch.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(448, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Измерение";
            // 
            // s_new_os
            // 
            this.s_new_os.FormattingEnabled = true;
            this.s_new_os.Items.AddRange(new object[] {
            "Маленький",
            "Средний",
            "Большой"});
            this.s_new_os.Location = new System.Drawing.Point(601, 147);
            this.s_new_os.Name = "s_new_os";
            this.s_new_os.Size = new System.Drawing.Size(121, 21);
            this.s_new_os.TabIndex = 71;
            // 
            // s_new_unit
            // 
            this.s_new_unit.FormattingEnabled = true;
            this.s_new_unit.Items.AddRange(new object[] {
            "Маленький",
            "Средний",
            "Большой"});
            this.s_new_unit.Location = new System.Drawing.Point(601, 176);
            this.s_new_unit.Name = "s_new_unit";
            this.s_new_unit.Size = new System.Drawing.Size(121, 21);
            this.s_new_unit.TabIndex = 72;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 635);
            this.Controls.Add(this.s_new_unit);
            this.Controls.Add(this.s_new_os);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rb_new_smartwatch);
            this.Controls.Add(this.rb_new_bracelet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_calories);
            this.Controls.Add(this.rb_sleep);
            this.Controls.Add(this.rb_bpm);
            this.Controls.Add(this.rb_steps);
            this.Controls.Add(this.rb_timer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_windows_phone);
            this.Controls.Add(this.rb_windows);
            this.Controls.Add(this.rb_xos);
            this.Controls.Add(this.rb_android);
            this.Controls.Add(this.rb_bracelet);
            this.Controls.Add(this.rb_smartwatch);
            this.Controls.Add(this.rb_xiaomi);
            this.Controls.Add(this.rb_sony);
            this.Controls.Add(this.rb_panasonic);
            this.Controls.Add(this.rb_smart_kid);
            this.Controls.Add(this.rb_wokka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_device);
            this.Controls.Add(this.pictureBox_enter_image);
            this.Controls.Add(this.btn_add_image);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_clear_filter);
            this.Controls.Add(this.dataGirdView1);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.search_kvdr);
            this.Controls.Add(this.btn_add_bd);
            this.Controls.Add(this.input_price);
            this.Controls.Add(this.labelPrice_to_add);
            this.Controls.Add(this.labelmax_dist);
            this.Controls.Add(this.input_new_name);
            this.Controls.Add(this.labelAdd_to_bd);
            this.Controls.Add(this.s_new_manuacture);
            this.Controls.Add(this.labelsize_add);
            this.Controls.Add(this.add_kvdr);
            this.Controls.Add(this.labelflight_time);
            this.Controls.Add(this.price_until);
            this.Controls.Add(this.labelPrice_do);
            this.Controls.Add(this.price_from);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.rb_fitbit);
            this.Controls.Add(this.rb_samsung);
            this.Controls.Add(this.rb_apple);
            this.Controls.Add(this.labelDist);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "Программа для работы с БД сайта Kvadro.ru ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirdView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_enter_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    private System.Windows.Forms.Label labelSize;
    private System.Windows.Forms.Label labelDist;
    private System.Windows.Forms.RadioButton rb_apple;
    private System.Windows.Forms.RadioButton rb_samsung;
    private System.Windows.Forms.RadioButton rb_fitbit;
    private System.Windows.Forms.Label labelPrice;
    private System.Windows.Forms.TextBox price_from;
    private System.Windows.Forms.Label labelPrice_do;
    private System.Windows.Forms.TextBox price_until;
    private System.Windows.Forms.Label labelflight_time;
    private System.Windows.Forms.Label add_kvdr;
    private System.Windows.Forms.Label labelsize_add;
    private System.Windows.Forms.ComboBox s_new_manuacture;
    private System.Windows.Forms.Label labelAdd_to_bd;
    private System.Windows.Forms.TextBox input_new_name;
    private System.Windows.Forms.Label labelmax_dist;
    private System.Windows.Forms.TextBox input_price;
    private System.Windows.Forms.Label labelPrice_to_add;
    private System.Windows.Forms.Button btn_add_bd;
    private System.Windows.Forms.Label search_kvdr;
    private System.Windows.Forms.Button btn_find;
    private System.Windows.Forms.DataGridView dataGirdView1;
    private System.Windows.Forms.Button btn_clear_filter;
    private System.Windows.Forms.Button btn_clear;
    private System.Windows.Forms.Button btn_add_image;
    private System.Windows.Forms.PictureBox pictureBox_enter_image;
    private System.Windows.Forms.TextBox name_device;
    private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_wokka;
        private System.Windows.Forms.RadioButton rb_smart_kid;
        private System.Windows.Forms.RadioButton rb_panasonic;
        private System.Windows.Forms.RadioButton rb_sony;
        private System.Windows.Forms.RadioButton rb_xiaomi;
        private System.Windows.Forms.RadioButton rb_smartwatch;
        private System.Windows.Forms.RadioButton rb_bracelet;
        private System.Windows.Forms.RadioButton rb_android;
        private System.Windows.Forms.RadioButton rb_xos;
        private System.Windows.Forms.RadioButton rb_windows;
        private System.Windows.Forms.RadioButton rb_windows_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_timer;
        private System.Windows.Forms.RadioButton rb_steps;
        private System.Windows.Forms.RadioButton rb_bpm;
        private System.Windows.Forms.RadioButton rb_sleep;
        private System.Windows.Forms.RadioButton rb_calories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_new_bracelet;
        private System.Windows.Forms.RadioButton rb_new_smartwatch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox s_new_os;
        private System.Windows.Forms.ComboBox s_new_unit;
    }
}

