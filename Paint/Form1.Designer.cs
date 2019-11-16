namespace Paint
{
    partial class Paint
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
            this.trackBarAmount = new System.Windows.Forms.TrackBar();
            this.comboBoxFigure = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.pictureBoxGraphics = new System.Windows.Forms.PictureBox();
            this.buttonClear1 = new System.Windows.Forms.Button();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarAmount
            // 
            this.trackBarAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarAmount.Location = new System.Drawing.Point(177, 385);
            this.trackBarAmount.Name = "trackBarAmount";
            this.trackBarAmount.Size = new System.Drawing.Size(405, 56);
            this.trackBarAmount.TabIndex = 0;
            // 
            // comboBoxFigure
            // 
            this.comboBoxFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFigure.FormattingEnabled = true;
            this.comboBoxFigure.Location = new System.Drawing.Point(669, 12);
            this.comboBoxFigure.Name = "comboBoxFigure";
            this.comboBoxFigure.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFigure.TabIndex = 1;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDraw.Location = new System.Drawing.Point(669, 64);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(121, 23);
            this.buttonDraw.TabIndex = 2;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.ButtonDraw_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(669, 114);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(121, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "ClearAll";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // pictureBoxGraphics
            // 
            this.pictureBoxGraphics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGraphics.BackColor = System.Drawing.Color.White;
            this.pictureBoxGraphics.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxGraphics.Name = "pictureBoxGraphics";
            this.pictureBoxGraphics.Size = new System.Drawing.Size(649, 349);
            this.pictureBoxGraphics.TabIndex = 4;
            this.pictureBoxGraphics.TabStop = false;
            this.pictureBoxGraphics.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxGraphics_Paint);
            // 
            // buttonClear1
            // 
            this.buttonClear1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear1.Location = new System.Drawing.Point(669, 161);
            this.buttonClear1.Name = "buttonClear1";
            this.buttonClear1.Size = new System.Drawing.Size(121, 23);
            this.buttonClear1.TabIndex = 5;
            this.buttonClear1.Text = "ClearOne";
            this.buttonClear1.UseVisualStyleBackColor = true;
            this.buttonClear1.Click += new System.EventHandler(this.ButtonClear1_Click);
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownNumber.Location = new System.Drawing.Point(688, 190);
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(79, 22);
            this.numericUpDownNumber.TabIndex = 6;
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.numericUpDownNumber);
            this.Controls.Add(this.buttonClear1);
            this.Controls.Add(this.pictureBoxGraphics);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.comboBoxFigure);
            this.Controls.Add(this.trackBarAmount);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "Paint";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarAmount;
        private System.Windows.Forms.ComboBox comboBoxFigure;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.PictureBox pictureBoxGraphics;
        private System.Windows.Forms.Button buttonClear1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
    }
}

