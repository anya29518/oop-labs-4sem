namespace lab2
{
    partial class Form1
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
            if (disposing && (components != null))
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
            this.flat_label = new System.Windows.Forms.Label();
            this.meters = new System.Windows.Forms.RichTextBox();
            this.meters_label = new System.Windows.Forms.Label();
            this.rooms_number = new System.Windows.Forms.ComboBox();
            this.options_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.options_label = new System.Windows.Forms.Label();
            this.rooms_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.floor = new System.Windows.Forms.RichTextBox();
            this.button_addres = new System.Windows.Forms.Button();
            this.button_room = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.output_button = new System.Windows.Forms.Button();
            this.DateOfBuild = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.cost = new System.Windows.Forms.TextBox();
            this.Address_comboBox = new System.Windows.Forms.ComboBox();
            this.Rooms = new System.Windows.Forms.ListBox();
            this.AddFlat_button = new System.Windows.Forms.Button();
            this.flatsListBox = new System.Windows.Forms.ListBox();
            this.output_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // flat_label
            // 
            this.flat_label.AutoSize = true;
            this.flat_label.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flat_label.Location = new System.Drawing.Point(323, 9);
            this.flat_label.Name = "flat_label";
            this.flat_label.Size = new System.Drawing.Size(145, 40);
            this.flat_label.TabIndex = 0;
            this.flat_label.Text = "Квартира\r\n";
            this.flat_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // meters
            // 
            this.meters.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.meters.Location = new System.Drawing.Point(32, 91);
            this.meters.Name = "meters";
            this.meters.Size = new System.Drawing.Size(84, 49);
            this.meters.TabIndex = 1;
            this.meters.Text = "";
            // 
            // meters_label
            // 
            this.meters_label.AutoSize = true;
            this.meters_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.meters_label.Location = new System.Drawing.Point(27, 59);
            this.meters_label.Name = "meters_label";
            this.meters_label.Size = new System.Drawing.Size(213, 29);
            this.meters_label.TabIndex = 2;
            this.meters_label.Text = "Метраж (кв. м)";
            // 
            // rooms_number
            // 
            this.rooms_number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rooms_number.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rooms_number.FormattingEnabled = true;
            this.rooms_number.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.rooms_number.Location = new System.Drawing.Point(281, 282);
            this.rooms_number.Name = "rooms_number";
            this.rooms_number.Size = new System.Drawing.Size(85, 34);
            this.rooms_number.TabIndex = 3;
            this.rooms_number.SelectedIndexChanged += new System.EventHandler(this.rooms_number_SelectedIndexChanged);
            // 
            // options_CheckedListBox
            // 
            this.options_CheckedListBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.options_CheckedListBox.FormattingEnabled = true;
            this.options_CheckedListBox.Items.AddRange(new object[] {
            "Кухня",
            "Ванна",
            "Туалет",
            "Балкон",
            "Подвал",
            "Гардеробная",
            "Гостевой санузел"});
            this.options_CheckedListBox.Location = new System.Drawing.Point(281, 91);
            this.options_CheckedListBox.Name = "options_CheckedListBox";
            this.options_CheckedListBox.Size = new System.Drawing.Size(220, 96);
            this.options_CheckedListBox.TabIndex = 4;
            // 
            // options_label
            // 
            this.options_label.AutoSize = true;
            this.options_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.options_label.Location = new System.Drawing.Point(276, 59);
            this.options_label.Name = "options_label";
            this.options_label.Size = new System.Drawing.Size(106, 29);
            this.options_label.TabIndex = 5;
            this.options_label.Text = "Опции ";
            // 
            // rooms_label
            // 
            this.rooms_label.AutoSize = true;
            this.rooms_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rooms_label.Location = new System.Drawing.Point(276, 213);
            this.rooms_label.Name = "rooms_label";
            this.rooms_label.Size = new System.Drawing.Size(142, 52);
            this.rooms_label.TabIndex = 6;
            this.rooms_label.Text = "Количество\r\nкомнат";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_label.Location = new System.Drawing.Point(27, 143);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(222, 29);
            this.year_label.TabIndex = 7;
            this.year_label.Text = "Дата постройки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(527, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Этаж ";
            // 
            // floor
            // 
            this.floor.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floor.Location = new System.Drawing.Point(532, 99);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(90, 39);
            this.floor.TabIndex = 10;
            this.floor.Text = "";
            // 
            // button_addres
            // 
            this.button_addres.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addres.Location = new System.Drawing.Point(724, 215);
            this.button_addres.Name = "button_addres";
            this.button_addres.Size = new System.Drawing.Size(165, 50);
            this.button_addres.TabIndex = 11;
            this.button_addres.Text = "Адрес";
            this.button_addres.UseVisualStyleBackColor = true;
            this.button_addres.Click += new System.EventHandler(this.button_addres_Click);
            // 
            // button_room
            // 
            this.button_room.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_room.Location = new System.Drawing.Point(490, 215);
            this.button_room.Name = "button_room";
            this.button_room.Size = new System.Drawing.Size(165, 50);
            this.button_room.TabIndex = 12;
            this.button_room.Text = "Комната ";
            this.button_room.UseVisualStyleBackColor = true;
            this.button_room.Click += new System.EventHandler(this.button_room_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(32, 553);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(165, 50);
            this.button_save.TabIndex = 13;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(235, 553);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(165, 50);
            this.button_clear.TabIndex = 14;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // output_button
            // 
            this.output_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output_button.Location = new System.Drawing.Point(897, 91);
            this.output_button.Name = "output_button";
            this.output_button.Size = new System.Drawing.Size(145, 45);
            this.output_button.TabIndex = 16;
            this.output_button.Text = "Вывод ";
            this.output_button.UseVisualStyleBackColor = true;
            this.output_button.Click += new System.EventHandler(this.output_button_Click);
            // 
            // DateOfBuild
            // 
            this.DateOfBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBuild.Location = new System.Drawing.Point(32, 184);
            this.DateOfBuild.Name = "DateOfBuild";
            this.DateOfBuild.Size = new System.Drawing.Size(200, 27);
            this.DateOfBuild.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(32, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 89);
            this.button1.TabIndex = 20;
            this.button1.Text = "Высчитать\r\nстоимость";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cost
            // 
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost.Location = new System.Drawing.Point(231, 381);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(169, 53);
            this.cost.TabIndex = 21;
            // 
            // Address_comboBox
            // 
            this.Address_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Address_comboBox.FormattingEnabled = true;
            this.Address_comboBox.Location = new System.Drawing.Point(675, 282);
            this.Address_comboBox.Name = "Address_comboBox";
            this.Address_comboBox.Size = new System.Drawing.Size(214, 28);
            this.Address_comboBox.TabIndex = 23;
            // 
            // Rooms
            // 
            this.Rooms.FormattingEnabled = true;
            this.Rooms.HorizontalScrollbar = true;
            this.Rooms.ItemHeight = 16;
            this.Rooms.Location = new System.Drawing.Point(447, 282);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(208, 148);
            this.Rooms.TabIndex = 24;
            // 
            // AddFlat_button
            // 
            this.AddFlat_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddFlat_button.Location = new System.Drawing.Point(32, 497);
            this.AddFlat_button.Name = "AddFlat_button";
            this.AddFlat_button.Size = new System.Drawing.Size(165, 50);
            this.AddFlat_button.TabIndex = 26;
            this.AddFlat_button.Text = "Добавить";
            this.AddFlat_button.UseVisualStyleBackColor = true;
            this.AddFlat_button.Click += new System.EventHandler(this.addFlat_Click);
            // 
            // flatsListBox
            // 
            this.flatsListBox.FormattingEnabled = true;
            this.flatsListBox.HorizontalScrollbar = true;
            this.flatsListBox.ItemHeight = 16;
            this.flatsListBox.Location = new System.Drawing.Point(447, 447);
            this.flatsListBox.Name = "flatsListBox";
            this.flatsListBox.Size = new System.Drawing.Size(442, 148);
            this.flatsListBox.TabIndex = 27;
            // 
            // output_listBox
            // 
            this.output_listBox.FormattingEnabled = true;
            this.output_listBox.HorizontalScrollbar = true;
            this.output_listBox.ItemHeight = 16;
            this.output_listBox.Location = new System.Drawing.Point(926, 195);
            this.output_listBox.Name = "output_listBox";
            this.output_listBox.Size = new System.Drawing.Size(258, 340);
            this.output_listBox.TabIndex = 28;
            this.output_listBox.SelectedIndexChanged += new System.EventHandler(this.output_listBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 650);
            this.Controls.Add(this.output_listBox);
            this.Controls.Add(this.flatsListBox);
            this.Controls.Add(this.AddFlat_button);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.Address_comboBox);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateOfBuild);
            this.Controls.Add(this.output_button);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_room);
            this.Controls.Add(this.button_addres);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.rooms_label);
            this.Controls.Add(this.options_label);
            this.Controls.Add(this.options_CheckedListBox);
            this.Controls.Add(this.rooms_number);
            this.Controls.Add(this.meters_label);
            this.Controls.Add(this.meters);
            this.Controls.Add(this.flat_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label flat_label;
        private System.Windows.Forms.RichTextBox meters;
        private System.Windows.Forms.Label meters_label;
        private System.Windows.Forms.ComboBox rooms_number;
        private System.Windows.Forms.CheckedListBox options_CheckedListBox;
        private System.Windows.Forms.Label options_label;
        private System.Windows.Forms.Label rooms_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox floor;
        private System.Windows.Forms.Button button_addres;
        private System.Windows.Forms.Button button_room;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button output_button;
        private System.Windows.Forms.DateTimePicker DateOfBuild;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cost;
        public System.Windows.Forms.ComboBox Address_comboBox;
        private System.Windows.Forms.ListBox Rooms;
        private System.Windows.Forms.Button AddFlat_button;
        private System.Windows.Forms.ListBox flatsListBox;
        private System.Windows.Forms.ListBox output_listBox;
    }
}

