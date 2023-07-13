namespace poo
{
    partial class Menu
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
            btnGestionarClientes = new Button();
            SuspendLayout();
            // 
            // btnGestionarClientes
            // 
            btnGestionarClientes.Location = new Point(281, 84);
            btnGestionarClientes.Name = "btnGestionarClientes";
            btnGestionarClientes.Size = new Size(75, 52);
            btnGestionarClientes.TabIndex = 0;
            btnGestionarClientes.Text = "Gestionar clientes";
            btnGestionarClientes.UseVisualStyleBackColor = true;
            btnGestionarClientes.Click += button1_Click_1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 174);
            Controls.Add(btnGestionarClientes);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionarClientes;
    }
}