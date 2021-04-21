namespace lab2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.room = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.space = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.window_n = new System.Windows.Forms.RichTextBox();
            this.side = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // room
            // 
            this.room.AutoSize = true;
            this.room.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.room.Location = new System.Drawing.Point(135, 9);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(144, 35);
            this.room.TabIndex = 0;
            this.room.Text = "Комната";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(20, 88);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(159, 35);
            this.type.TabIndex = 2;
            this.type.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Площадь (кв. м)";
            // 
            // space
            // 
            this.space.Location = new System.Drawing.Point(20, 210);
            this.space.Name = "space";
            this.space.Size = new System.Drawing.Size(159, 35);
            this.space.TabIndex = 4;
            this.space.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(237, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество окон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(237, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сторона окон";
            // 
            // window_n
            // 
            this.window_n.Location = new System.Drawing.Point(242, 88);
            this.window_n.Name = "window_n";
            this.window_n.Size = new System.Drawing.Size(63, 35);
            this.window_n.TabIndex = 8;
            this.window_n.Text = "";
            // 
            // side
            // 
            this.side.AutoCompleteCustomSource.AddRange(new string[] {
            "Север",
            "Запад",
            "Восток",
            "Юг",
            "Северо-восток",
            "Северо-запад",
            "Юго-восток",
            "Юго-запад"});
            this.side.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.side.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.side.FormattingEnabled = true;
            this.side.Items.AddRange(new object[] {
            "Север",
            "Юг",
            "Запад",
            "Восток"});
            this.side.Location = new System.Drawing.Point(242, 210);
            this.side.Name = "side";
            this.side.Size = new System.Drawing.Size(131, 30);
            this.side.TabIndex = 10;
            // 
            // button_save
            // 
            this.button_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_save.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(20, 351);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(150, 40);
            this.button_save.TabIndex = 20;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(176, 351);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(150, 40);
            this.button_clear.TabIndex = 21;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(332, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 22;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.side);
            this.Controls.Add(this.window_n);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.space);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.room);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label room;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox space;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox window_n;
        private System.Windows.Forms.ComboBox side;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button1;
    }
}