namespace Ejercicio3._1
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
            button1 = new Button();
            cbUrgente = new CheckBox();
            txtTelegrama = new RichTextBox();
            txtPrecio = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(164, 268);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbUrgente
            // 
            cbUrgente.AutoSize = true;
            cbUrgente.Location = new Point(12, 231);
            cbUrgente.Name = "cbUrgente";
            cbUrgente.Size = new Size(73, 19);
            cbUrgente.TabIndex = 1;
            cbUrgente.Text = "Urgente?";
            cbUrgente.UseVisualStyleBackColor = true;
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(28, 39);
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(265, 142);
            txtTelegrama.TabIndex = 2;
            txtTelegrama.Text = "";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(38, 272);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 344);
            Controls.Add(txtPrecio);
            Controls.Add(txtTelegrama);
            Controls.Add(cbUrgente);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox cbUrgente;
        private RichTextBox txtTelegrama;
        private TextBox txtPrecio;
    }
}