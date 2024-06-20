namespace Proyecto___Programacion_III___UPC
{
    partial class PalabraMasLargaEjer3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PalabraMasLargaEjer3));
            Title = new Label();
            Entrada = new TextBox();
            button1 = new Button();
            Respuesta = new Label();
            code = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(114, 9);
            Title.Name = "Title";
            Title.Size = new Size(552, 54);
            Title.TabIndex = 0;
            Title.Text = "ESCRIBIR UNA FUNCION QUE DEVUELBA LA PALABRA \r\nMAS LARGA\r\n";
            Title.Click += label1_Click;
            // 
            // Entrada
            // 
            Entrada.Location = new Point(12, 117);
            Entrada.Multiline = true;
            Entrada.Name = "Entrada";
            Entrada.Size = new Size(241, 80);
            Entrada.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(38, 203);
            button1.Name = "button1";
            button1.Size = new Size(183, 50);
            button1.TabIndex = 2;
            button1.Text = "Probar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Respuesta
            // 
            Respuesta.AutoSize = true;
            Respuesta.Font = new Font("Cascadia Code PL", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Respuesta.Location = new Point(15, 311);
            Respuesta.Name = "Respuesta";
            Respuesta.Size = new Size(132, 27);
            Respuesta.TabIndex = 3;
            Respuesta.Text = "RESPUESTA:";
            // 
            // code
            // 
            code.AutoSize = true;
            code.BackColor = SystemColors.ControlDarkDark;
            code.Font = new Font("Cascadia Code PL", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            code.ForeColor = Color.White;
            code.Location = new Point(291, 63);
            code.Name = "code";
            code.Size = new Size(486, 360);
            code.TabIndex = 4;
            code.Text = resources.GetString("code.Text");
            // 
            // PalabraMasLargaEjer3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(code);
            Controls.Add(Respuesta);
            Controls.Add(button1);
            Controls.Add(Entrada);
            Controls.Add(Title);
            Name = "PalabraMasLargaEjer3";
            Text = "PalabraMasLargaEjer3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TextBox Entrada;
        private Button button1;
        private Label Respuesta;
        private Label code;
    }
}