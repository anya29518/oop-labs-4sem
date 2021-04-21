namespace WindowsFormsApp1_2_
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
            this.generate_btn = new System.Windows.Forms.Button();
            this.sorted_up_button = new System.Windows.Forms.Button();
            this.sorted_down_button = new System.Windows.Forms.Button();
            this.questinon_btn_1 = new System.Windows.Forms.Button();
            this.question_btn_2 = new System.Windows.Forms.Button();
            this.question_btn_3 = new System.Windows.Forms.Button();
            this.list_box = new System.Windows.Forms.ListBox();
            this.total_list_box = new System.Windows.Forms.ListBox();
            this.Очистить = new System.Windows.Forms.Button();
            this.number_of_collection = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // generate_btn
            // 
            this.generate_btn.Location = new System.Drawing.Point(240, 10);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(195, 62);
            this.generate_btn.TabIndex = 0;
            this.generate_btn.Text = "Сгенерировать коллекцию";
            this.generate_btn.UseVisualStyleBackColor = true;
            this.generate_btn.Click += new System.EventHandler(this.generate_btn_Click);
            // 
            // sorted_up_button
            // 
            this.sorted_up_button.Location = new System.Drawing.Point(240, 92);
            this.sorted_up_button.Name = "sorted_up_button";
            this.sorted_up_button.Size = new System.Drawing.Size(195, 62);
            this.sorted_up_button.TabIndex = 2;
            this.sorted_up_button.Text = "Сортировать по возрастанию (по возрасту)";
            this.sorted_up_button.UseVisualStyleBackColor = true;
            this.sorted_up_button.Click += new System.EventHandler(this.sorted_up_button_Click);
            // 
            // sorted_down_button
            // 
            this.sorted_down_button.Location = new System.Drawing.Point(640, 92);
            this.sorted_down_button.Name = "sorted_down_button";
            this.sorted_down_button.Size = new System.Drawing.Size(195, 62);
            this.sorted_down_button.TabIndex = 3;
            this.sorted_down_button.Text = "Сортировать по убыванию (по возрасту)";
            this.sorted_down_button.UseVisualStyleBackColor = true;
            this.sorted_down_button.Click += new System.EventHandler(this.sorted_down_button_Click);
            // 
            // questinon_btn_1
            // 
            this.questinon_btn_1.Location = new System.Drawing.Point(275, 179);
            this.questinon_btn_1.Name = "questinon_btn_1";
            this.questinon_btn_1.Size = new System.Drawing.Size(156, 62);
            this.questinon_btn_1.TabIndex = 4;
            this.questinon_btn_1.Text = "Самый младший студент";
            this.questinon_btn_1.UseVisualStyleBackColor = true;
            this.questinon_btn_1.Click += new System.EventHandler(this.questinon_btn_1_Click);
            // 
            // question_btn_2
            // 
            this.question_btn_2.Location = new System.Drawing.Point(458, 179);
            this.question_btn_2.Name = "question_btn_2";
            this.question_btn_2.Size = new System.Drawing.Size(156, 62);
            this.question_btn_2.TabIndex = 5;
            this.question_btn_2.Text = "Самый старший студент";
            this.question_btn_2.UseVisualStyleBackColor = true;
            this.question_btn_2.Click += new System.EventHandler(this.question_btn_2_Click);
            // 
            // question_btn_3
            // 
            this.question_btn_3.Location = new System.Drawing.Point(658, 179);
            this.question_btn_3.Name = "question_btn_3";
            this.question_btn_3.Size = new System.Drawing.Size(156, 62);
            this.question_btn_3.TabIndex = 6;
            this.question_btn_3.Text = "Студенты с именем на И";
            this.question_btn_3.UseVisualStyleBackColor = true;
            this.question_btn_3.Click += new System.EventHandler(this.question_btn_3_Click);
            // 
            // list_box
            // 
            this.list_box.FormattingEnabled = true;
            this.list_box.ItemHeight = 16;
            this.list_box.Location = new System.Drawing.Point(53, 295);
            this.list_box.Name = "list_box";
            this.list_box.Size = new System.Drawing.Size(466, 180);
            this.list_box.TabIndex = 7;
            this.list_box.SelectedIndexChanged += new System.EventHandler(this.list_box_SelectedIndexChanged);
            // 
            // total_list_box
            // 
            this.total_list_box.FormattingEnabled = true;
            this.total_list_box.ItemHeight = 16;
            this.total_list_box.Location = new System.Drawing.Point(588, 295);
            this.total_list_box.Name = "total_list_box";
            this.total_list_box.Size = new System.Drawing.Size(434, 180);
            this.total_list_box.TabIndex = 8;
            // 
            // Очистить
            // 
            this.Очистить.Location = new System.Drawing.Point(640, 10);
            this.Очистить.Name = "Очистить";
            this.Очистить.Size = new System.Drawing.Size(195, 62);
            this.Очистить.TabIndex = 9;
            this.Очистить.Text = "Очистить";
            this.Очистить.UseVisualStyleBackColor = true;
            this.Очистить.Click += new System.EventHandler(this.Очистить_Click);
            // 
            // number_of_collection
            // 
            this.number_of_collection.Location = new System.Drawing.Point(453, 17);
            this.number_of_collection.Name = "number_of_collection";
            this.number_of_collection.Size = new System.Drawing.Size(160, 54);
            this.number_of_collection.TabIndex = 10;
            this.number_of_collection.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 506);
            this.Controls.Add(this.number_of_collection);
            this.Controls.Add(this.Очистить);
            this.Controls.Add(this.total_list_box);
            this.Controls.Add(this.list_box);
            this.Controls.Add(this.question_btn_3);
            this.Controls.Add(this.question_btn_2);
            this.Controls.Add(this.questinon_btn_1);
            this.Controls.Add(this.sorted_down_button);
            this.Controls.Add(this.sorted_up_button);
            this.Controls.Add(this.generate_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generate_btn;
        private System.Windows.Forms.Button sorted_up_button;
        private System.Windows.Forms.Button sorted_down_button;
        private System.Windows.Forms.Button questinon_btn_1;
        private System.Windows.Forms.Button question_btn_2;
        private System.Windows.Forms.Button question_btn_3;
        private System.Windows.Forms.ListBox list_box;
        private System.Windows.Forms.ListBox total_list_box;
        private System.Windows.Forms.Button Очистить;
        private System.Windows.Forms.RichTextBox number_of_collection;
    }
}

