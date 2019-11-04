namespace WinForms2015_MySQL
{
  partial class Form_About
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
      if(disposing && (components != null))
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
      this.label_about_it = new System.Windows.Forms.Label();
      this.listBox_description = new System.Windows.Forms.ListBox();
      this.buttonclose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label_about_it
      // 
      this.label_about_it.AutoSize = true;
      this.label_about_it.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label_about_it.Location = new System.Drawing.Point(10, 9);
      this.label_about_it.Name = "label_about_it";
      this.label_about_it.Size = new System.Drawing.Size(506, 18);
      this.label_about_it.TabIndex = 0;
      this.label_about_it.Text = "Программа для работы с БД. С помощью неё пользователь может:";
      // 
      // listBox_description
      // 
      this.listBox_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.listBox_description.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.listBox_description.FormattingEnabled = true;
      this.listBox_description.ItemHeight = 20;
      this.listBox_description.Items.AddRange(new object[] {
            "1.Получать данные о квадрокоптерах.",
            "",
            "2.Использовать готовые фильтры для сортировки.",
            "",
            "3.Найти нужный квадрокоптер написав его в строке поиска.",
            "",
            "4.Добавлять данные.",
            "",
            "5.Изменять данные"});
      this.listBox_description.Location = new System.Drawing.Point(13, 30);
      this.listBox_description.Name = "listBox_description";
      this.listBox_description.Size = new System.Drawing.Size(494, 204);
      this.listBox_description.TabIndex = 1;
      // 
      // buttonclose
      // 
      this.buttonclose.Location = new System.Drawing.Point(427, 240);
      this.buttonclose.Name = "buttonclose";
      this.buttonclose.Size = new System.Drawing.Size(75, 23);
      this.buttonclose.TabIndex = 2;
      this.buttonclose.Text = "Закрыть";
      this.buttonclose.UseVisualStyleBackColor = true;
      this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
      // 
      // Form_About
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
      this.ClientSize = new System.Drawing.Size(514, 273);
      this.Controls.Add(this.buttonclose);
      this.Controls.Add(this.listBox_description);
      this.Controls.Add(this.label_about_it);
      this.Name = "Form_About";
      this.Text = "О программе";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label_about_it;
    private System.Windows.Forms.ListBox listBox_description;
    private System.Windows.Forms.Button buttonclose;
  }
}