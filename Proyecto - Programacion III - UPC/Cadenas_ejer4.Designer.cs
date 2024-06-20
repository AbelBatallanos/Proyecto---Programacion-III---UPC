namespace Proyecto___Programacion_III___UPC
{
    partial class Cadenas_ejer4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadenas_ejer4));
            Title = new Label();
            Entrada = new TextBox();
            Ejecutar = new Button();
            Respuesta = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(76, 9);
            Title.Name = "Title";
            Title.Size = new Size(660, 54);
            Title.TabIndex = 0;
            Title.Text = "Escribir un proceso la cual elimine la primetra letra \r\nde cada palabra\r\n";
            // 
            // Entrada
            // 
            Entrada.Location = new Point(25, 113);
            Entrada.Multiline = true;
            Entrada.Name = "Entrada";
            Entrada.Size = new Size(242, 75);
            Entrada.TabIndex = 1;
            // 
            // Ejecutar
            // 
            Ejecutar.Location = new Point(58, 220);
            Ejecutar.Name = "Ejecutar";
            Ejecutar.Size = new Size(166, 51);
            Ejecutar.TabIndex = 2;
            Ejecutar.Text = "Ejecutar";
            Ejecutar.UseVisualStyleBackColor = true;
            Ejecutar.Click += Ejecutar_Click;
            // 
            // Respuesta
            // 
            Respuesta.AutoSize = true;
            Respuesta.Font = new Font("Cascadia Code PL", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Respuesta.Location = new Point(25, 320);
            Respuesta.Name = "Respuesta";
            Respuesta.Size = new Size(132, 27);
            Respuesta.TabIndex = 3;
            Respuesta.Text = "Respuesta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Font = new Font("Cascadia Code PL", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(296, 91);
            label1.Name = "label1";
            label1.Size = new Size(480, 220);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            // 
            // Cadenas_ejer4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Respuesta);
            Controls.Add(Ejecutar);
            Controls.Add(Entrada);
            Controls.Add(Title);
            Name = "Cadenas_ejer4";
            Text = "la";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TextBox Entrada;
        private Button Ejecutar;
        private Label Respuesta;
        private Label label1;
    }
}