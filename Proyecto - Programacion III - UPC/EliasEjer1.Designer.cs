namespace Proyecto___Programacion_III___UPC
{
    partial class EliasEjer1
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            Ejecutar = new Button();
            Funcion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(657, 40);
            label1.TabIndex = 0;
            label1.Text = "ESCRIBIR UNA FUNCION QUE DEVUELVA LA CANTIDAD DE PALABRAS QUE HAY EN UNA\r\nCADENA\r\n";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 143);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 61);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 332);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "RESPUESTA: ";
            // 
            // Ejecutar
            // 
            Ejecutar.Location = new Point(63, 250);
            Ejecutar.Name = "Ejecutar";
            Ejecutar.Size = new Size(122, 38);
            Ejecutar.TabIndex = 3;
            Ejecutar.Text = "Probar";
            Ejecutar.UseVisualStyleBackColor = true;
            Ejecutar.Click += Ejecutar_Click;
            // 
            // Funcion
            // 
            Funcion.AutoSize = true;
            Funcion.BackColor = SystemColors.ControlDarkDark;
            Funcion.Font = new Font("Cascadia Code PL", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Funcion.ForeColor = SystemColors.ControlLightLight;
            Funcion.Location = new Point(353, 108);
            Funcion.Name = "Funcion";
            Funcion.Size = new Size(351, 140);
            Funcion.TabIndex = 4;
            Funcion.Text = "public int count_words(string words) {\r\n\r\n    int res = 0;\r\n    string[] arreglo = words.Split();\r\n    res = arreglo.Length;\r\n    return res;\r\n}";
            // 
            // EliasEjer1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Funcion);
            Controls.Add(Ejecutar);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "EliasEjer1";
            Text = "EliasEjer1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button Ejecutar;
        private Label Funcion;
    }
}