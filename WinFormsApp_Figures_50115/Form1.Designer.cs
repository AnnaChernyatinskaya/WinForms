
namespace WinFormsApp_Figures_50115
{
    partial class form_Main
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
            this.listBox_Primitives = new System.Windows.Forms.ListBox();
            this.button_ColorPen = new System.Windows.Forms.Button();
            this.button_ColorBrush = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog_Pen = new System.Windows.Forms.ColorDialog();
            this.colorDialog_Brush = new System.Windows.Forms.ColorDialog();
            this.button_i = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Primitives
            // 
            this.listBox_Primitives.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Primitives.FormattingEnabled = true;
            this.listBox_Primitives.ItemHeight = 23;
            this.listBox_Primitives.Items.AddRange(new object[] {
            "Круг",
            "Квадрат",
            "Сектор",
            "Линия",
            "Строка",
            "Дуга",
            "50115АС"});
            this.listBox_Primitives.Location = new System.Drawing.Point(12, 12);
            this.listBox_Primitives.Name = "listBox_Primitives";
            this.listBox_Primitives.Size = new System.Drawing.Size(193, 142);
            this.listBox_Primitives.TabIndex = 0;
            this.listBox_Primitives.SelectedIndexChanged += new System.EventHandler(this.listBox_Primitives_SelectedIndexChanged);
            // 
            // button_ColorPen
            // 
            this.button_ColorPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ColorPen.Location = new System.Drawing.Point(12, 172);
            this.button_ColorPen.Name = "button_ColorPen";
            this.button_ColorPen.Size = new System.Drawing.Size(193, 54);
            this.button_ColorPen.TabIndex = 1;
            this.button_ColorPen.Text = "Выбор цвета линий";
            this.button_ColorPen.UseVisualStyleBackColor = true;
            this.button_ColorPen.Click += new System.EventHandler(this.button_ColorPen_Click);
            // 
            // button_ColorBrush
            // 
            this.button_ColorBrush.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ColorBrush.Location = new System.Drawing.Point(12, 243);
            this.button_ColorBrush.Name = "button_ColorBrush";
            this.button_ColorBrush.Size = new System.Drawing.Size(193, 69);
            this.button_ColorBrush.TabIndex = 2;
            this.button_ColorBrush.Text = "Выбор цвета закрашивания";
            this.button_ColorBrush.UseVisualStyleBackColor = true;
            this.button_ColorBrush.Click += new System.EventHandler(this.button_ColorBrush_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.Location = new System.Drawing.Point(12, 331);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(193, 54);
            this.button_Exit.TabIndex = 3;
            this.button_Exit.Text = "Закрыть";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(243, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(654, 446);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // button_i
            // 
            this.button_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_i.Location = new System.Drawing.Point(12, 404);
            this.button_i.Name = "button_i";
            this.button_i.Size = new System.Drawing.Size(193, 54);
            this.button_i.TabIndex = 5;
            this.button_i.Text = "Сбросить";
            this.button_i.UseVisualStyleBackColor = true;
            this.button_i.Click += new System.EventHandler(this.button_i_Click);
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 510);
            this.Controls.Add(this.button_i);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_ColorBrush);
            this.Controls.Add(this.button_ColorPen);
            this.Controls.Add(this.listBox_Primitives);
            this.Name = "form_Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Primitives;
        private System.Windows.Forms.Button button_ColorPen;
        private System.Windows.Forms.Button button_ColorBrush;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ColorDialog colorDialog_Pen;
        private System.Windows.Forms.ColorDialog colorDialog_Brush;
        private System.Windows.Forms.Button button_i;
    }
}

