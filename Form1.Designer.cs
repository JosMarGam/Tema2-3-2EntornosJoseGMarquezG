namespace Tema2_3_2EntornosJoseGMarquezG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTexto = new Label();
            richTextBox1 = new RichTextBox();
            lblCoste = new Label();
            textBoxCoste = new TextBox();
            btnCalcular = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTexto.Location = new Point(83, 47);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(56, 25);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Texto";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(70, 76);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(658, 152);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // lblCoste
            // 
            lblCoste.AutoSize = true;
            lblCoste.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCoste.Location = new Point(70, 349);
            lblCoste.Name = "lblCoste";
            lblCoste.Size = new Size(52, 21);
            lblCoste.TabIndex = 4;
            lblCoste.Text = "Coste";
            // 
            // textBoxCoste
            // 
            textBoxCoste.Location = new Point(140, 351);
            textBoxCoste.Name = "textBoxCoste";
            textBoxCoste.Size = new Size(117, 23);
            textBoxCoste.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(561, 309);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(101, 41);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Cálcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(209, 269);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ordinario";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(77, 266);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Urgente";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(btnCalcular);
            Controls.Add(textBoxCoste);
            Controls.Add(lblCoste);
            Controls.Add(richTextBox1);
            Controls.Add(lblTexto);
            Name = "Form1";
            Text = "Cálcular Precio Telegrama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private RichTextBox richTextBox1;
        private Label lblCoste;
        private TextBox textBoxCoste;
        private Button btnCalcular;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
