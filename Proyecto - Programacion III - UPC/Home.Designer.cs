namespace Proyecto___Programacion_III___UPC
{
    partial class Home
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            Elias = new ToolStripMenuItem();
            cADENASToolStripMenuItem = new ToolStripMenuItem();
            ejercicio1ToolStripMenuItem = new ToolStripMenuItem();
            ejercicio2ToolStripMenuItem = new ToolStripMenuItem();
            ejercicio3ToolStripMenuItem = new ToolStripMenuItem();
            ejercicio4ToolStripMenuItem = new ToolStripMenuItem();
            ejercicio5ToolStripMenuItem = new ToolStripMenuItem();
            vECTORESToolStripMenuItem = new ToolStripMenuItem();
            mATRICESToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 198);
            label1.Name = "label1";
            label1.Size = new Size(336, 27);
            label1.TabIndex = 0;
            label1.Text = "PROYECTO - PROGRAMACIÓN III";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Elias });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // Elias
            // 
            Elias.DropDownItems.AddRange(new ToolStripItem[] { cADENASToolStripMenuItem, vECTORESToolStripMenuItem, mATRICESToolStripMenuItem });
            Elias.Name = "Elias";
            Elias.Size = new Size(82, 24);
            Elias.Text = "ELIAS VR";
            Elias.Click += eLIASVASQUEToolStripMenuItem_Click;
            // 
            // cADENASToolStripMenuItem
            // 
            cADENASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ejercicio1ToolStripMenuItem, ejercicio2ToolStripMenuItem, ejercicio3ToolStripMenuItem, ejercicio4ToolStripMenuItem, ejercicio5ToolStripMenuItem });
            cADENASToolStripMenuItem.Name = "cADENASToolStripMenuItem";
            cADENASToolStripMenuItem.Size = new Size(224, 26);
            cADENASToolStripMenuItem.Text = "CADENAS";
            // 
            // ejercicio1ToolStripMenuItem
            // 
            ejercicio1ToolStripMenuItem.Name = "ejercicio1ToolStripMenuItem";
            ejercicio1ToolStripMenuItem.Size = new Size(224, 26);
            ejercicio1ToolStripMenuItem.Text = "Ejercicio 1";
            ejercicio1ToolStripMenuItem.Click += ejercicio1ToolStripMenuItem_Click;
            // 
            // ejercicio2ToolStripMenuItem
            // 
            ejercicio2ToolStripMenuItem.Name = "ejercicio2ToolStripMenuItem";
            ejercicio2ToolStripMenuItem.Size = new Size(224, 26);
            ejercicio2ToolStripMenuItem.Text = "Ejercicio 2";
            ejercicio2ToolStripMenuItem.Click += ejercicio2ToolStripMenuItem_Click;
            // 
            // ejercicio3ToolStripMenuItem
            // 
            ejercicio3ToolStripMenuItem.Name = "ejercicio3ToolStripMenuItem";
            ejercicio3ToolStripMenuItem.Size = new Size(224, 26);
            ejercicio3ToolStripMenuItem.Text = "Ejercicio 3";
            ejercicio3ToolStripMenuItem.Click += ejercicio3ToolStripMenuItem_Click;
            // 
            // ejercicio4ToolStripMenuItem
            // 
            ejercicio4ToolStripMenuItem.Name = "ejercicio4ToolStripMenuItem";
            ejercicio4ToolStripMenuItem.Size = new Size(224, 26);
            ejercicio4ToolStripMenuItem.Text = "Ejercicio 4";
            ejercicio4ToolStripMenuItem.Click += ejercicio4ToolStripMenuItem_Click;
            // 
            // ejercicio5ToolStripMenuItem
            // 
            ejercicio5ToolStripMenuItem.Name = "ejercicio5ToolStripMenuItem";
            ejercicio5ToolStripMenuItem.Size = new Size(224, 26);
            ejercicio5ToolStripMenuItem.Text = "Ejercicio 5";
            ejercicio5ToolStripMenuItem.Click += ejercicio5ToolStripMenuItem_Click;
            // 
            // vECTORESToolStripMenuItem
            // 
            vECTORESToolStripMenuItem.Name = "vECTORESToolStripMenuItem";
            vECTORESToolStripMenuItem.Size = new Size(224, 26);
            vECTORESToolStripMenuItem.Text = "VECTORES";
            // 
            // mATRICESToolStripMenuItem
            // 
            mATRICESToolStripMenuItem.Name = "mATRICESToolStripMenuItem";
            mATRICESToolStripMenuItem.Size = new Size(224, 26);
            mATRICESToolStripMenuItem.Text = "MATRICES";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Elias;
        private ToolStripMenuItem cADENASToolStripMenuItem;
        private ToolStripMenuItem vECTORESToolStripMenuItem;
        private ToolStripMenuItem mATRICESToolStripMenuItem;
        private ToolStripMenuItem ejercicio1ToolStripMenuItem;
        private ToolStripMenuItem ejercicio2ToolStripMenuItem;
        private ToolStripMenuItem ejercicio3ToolStripMenuItem;
        private ToolStripMenuItem ejercicio4ToolStripMenuItem;
        private ToolStripMenuItem ejercicio5ToolStripMenuItem;
    }
}
