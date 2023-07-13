namespace poo
{
    partial class GestionarClientes
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
            listClientes = new ListBox();
            btnAgregar = new Button();
            label2 = new Label();
            textBoxNombre = new TextBox();
            btnEliminarCliente = new Button();
            inpApellido = new TextBox();
            label3 = new Label();
            inpTelefono = new TextBox();
            label5 = new Label();
            btnEditar = new Button();
            label4 = new Label();
            lblID = new Label();
            AgregarBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Gestionar clientes";
            label1.Click += label1_Click;
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 15;
            listClientes.Location = new Point(12, 72);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(290, 154);
            listClientes.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(436, 232);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(76, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Guardar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 72);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre :";
            label2.Click += label2_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(370, 72);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(142, 23);
            textBoxNombre.TabIndex = 4;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(81, 232);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(63, 25);
            btnEliminarCliente.TabIndex = 5;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // inpApellido
            // 
            inpApellido.Location = new Point(370, 139);
            inpApellido.Name = "inpApellido";
            inpApellido.Size = new Size(142, 23);
            inpApellido.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 139);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido :";
            // 
            // inpTelefono
            // 
            inpTelefono.Location = new Point(345, 203);
            inpTelefono.Name = "inpTelefono";
            inpTelefono.Size = new Size(167, 23);
            inpTelefono.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(308, 203);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 8;
            label5.Text = "Dni :";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(12, 232);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(63, 25);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 20);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 13;
            label4.Text = "ID :";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(350, 20);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 15);
            lblID.TabIndex = 14;
            // 
            // AgregarBtn
            // 
            AgregarBtn.Location = new Point(350, 232);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(60, 35);
            AgregarBtn.TabIndex = 15;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // GestionarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AgregarBtn);
            Controls.Add(lblID);
            Controls.Add(label4);
            Controls.Add(btnEditar);
            Controls.Add(inpTelefono);
            Controls.Add(label5);
            Controls.Add(inpApellido);
            Controls.Add(label3);
            Controls.Add(btnEliminarCliente);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(listClientes);
            Controls.Add(label1);
            Name = "GestionarClientes";
            Text = "Form2";
            Load += GestionarClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listClientes;
        private Button btnAgregar;
        private Label label2;
        private TextBox textBoxNombre;
        private Button btnEliminarCliente;
        private TextBox inpApellido;
        private Label label3;
        private TextBox inpTelefono;
        private Label label5;
        private Button btnEditar;
        private Label label4;
        private Label lblID;
        private Button AgregarBtn;
    }
}