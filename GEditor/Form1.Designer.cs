namespace GEditor
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
            this.listBoxShapes = new System.Windows.Forms.ListBox();
            this.buttonDrawDot = new System.Windows.Forms.Button();
            this.buttonDrawLine = new System.Windows.Forms.Button();
            this.buttonDrawCircle = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxShapes
            // 
            this.listBoxShapes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxShapes.FormattingEnabled = true;
            this.listBoxShapes.ItemHeight = 16;
            this.listBoxShapes.Location = new System.Drawing.Point(12, 59);
            this.listBoxShapes.Name = "listBoxShapes";
            this.listBoxShapes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxShapes.Size = new System.Drawing.Size(156, 340);
            this.listBoxShapes.TabIndex = 0;
            // 
            // buttonDrawDot
            // 
            this.buttonDrawDot.Location = new System.Drawing.Point(93, 12);
            this.buttonDrawDot.Name = "buttonDrawDot";
            this.buttonDrawDot.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawDot.TabIndex = 1;
            this.buttonDrawDot.Text = "Dot";
            this.buttonDrawDot.UseVisualStyleBackColor = true;
            this.buttonDrawDot.Click += new System.EventHandler(this.ButtonDrawDot_Click);
            // 
            // buttonDrawLine
            // 
            this.buttonDrawLine.Location = new System.Drawing.Point(174, 12);
            this.buttonDrawLine.Name = "buttonDrawLine";
            this.buttonDrawLine.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawLine.TabIndex = 2;
            this.buttonDrawLine.Text = "Line";
            this.buttonDrawLine.UseVisualStyleBackColor = true;
            this.buttonDrawLine.Click += new System.EventHandler(this.ButtonDrawLine_Click);
            // 
            // buttonDrawCircle
            // 
            this.buttonDrawCircle.Location = new System.Drawing.Point(255, 12);
            this.buttonDrawCircle.Name = "buttonDrawCircle";
            this.buttonDrawCircle.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawCircle.TabIndex = 3;
            this.buttonDrawCircle.Text = "Circle";
            this.buttonDrawCircle.UseVisualStyleBackColor = true;
            this.buttonDrawCircle.Click += new System.EventHandler(this.ButtonDrawCircle_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(12, 415);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(156, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "BAN";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(187, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 379);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            this.pictureBox1.Move += new System.EventHandler(this.PictureBox1_Move);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(12, 12);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 6;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(488, 12);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 7;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.ButtonTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonDrawCircle);
            this.Controls.Add(this.buttonDrawLine);
            this.Controls.Add(this.buttonDrawDot);
            this.Controls.Add(this.listBoxShapes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxShapes;
        private System.Windows.Forms.Button buttonDrawDot;
        private System.Windows.Forms.Button buttonDrawLine;
        private System.Windows.Forms.Button buttonDrawCircle;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonTest;
    }
}

