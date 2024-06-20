namespace Proyecto___Programacion_III___UPC
{
    partial class Cadenas_ejer5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadenas_ejer5));
            label1 = new Label();
            Entrada = new TextBox();
            Ejecutar = new Button();
            Resultado = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 22);
            label1.TabIndex = 0;
            label1.Text = "INVERTIR PALABRAS EN LA CADENA\r\n";
            // 
            // Entrada
            // 
            Entrada.Location = new Point(24, 60);
            Entrada.Multiline = true;
            Entrada.Name = "Entrada";
            Entrada.Size = new Size(234, 125);
            Entrada.TabIndex = 1;
            // 
            // Ejecutar
            // 
            Ejecutar.Location = new Point(50, 224);
            Ejecutar.Name = "Ejecutar";
            Ejecutar.Size = new Size(188, 51);
            Ejecutar.TabIndex = 2;
            Ejecutar.Text = "Ejecutar";
            Ejecutar.UseVisualStyleBackColor = true;
            Ejecutar.Click += Ejecutar_Click;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Font = new Font("Cascadia Code PL", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Resultado.Location = new Point(24, 332);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(132, 27);
            Resultado.TabIndex = 3;
            Resultado.Text = "Resultado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.Font = new Font("Cascadia Code PL", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(266, 60);
            label2.Name = "label2";
            label2.Size = new Size(522, 220);
            label2.TabIndex = 4;
            label2.Text = resources.GetString("label2.Text");
            // 
            // Cadenas_ejer5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(Resultado);
            Controls.Add(Ejecutar);
            Controls.Add(Entrada);
            Controls.Add(label1);
            Name = "Cadenas_ejer5";
            Text = "Cadenas_ejer5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Entrada;
        private Button Ejecutar;
        private Label Resultado;
        private Label label2;
    }
}