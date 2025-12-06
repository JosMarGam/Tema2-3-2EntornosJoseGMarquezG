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
            checkBoxUrgente = new CheckBox();
            lblCoste = new Label();
            textBoxCoste = new TextBox();
            btnCalcular = new Button();
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
            // checkBoxUrgente
            // 
            checkBoxUrgente.AutoSize = true;
            checkBoxUrgente.Location = new Point(83, 267);
            checkBoxUrgente.Name = "checkBoxUrgente";
            checkBoxUrgente.Size = new Size(72, 19);
            checkBoxUrgente.TabIndex = 3;
            checkBoxUrgente.Text = "Ugente ?";
            checkBoxUrgente.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(textBoxCoste);
            Controls.Add(lblCoste);
            Controls.Add(checkBoxUrgente);
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
        private CheckBox checkBoxUrgente;
        private Label lblCoste;
        private TextBox textBoxCoste;
        private Button btnCalcular;
        }
}
