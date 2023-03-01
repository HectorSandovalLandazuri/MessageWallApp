namespace MessageWall
{
    partial class Dashboard
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lbxMensajes = new ListBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(91, 207);
            btnAceptar.Margin = new Padding(5, 6, 5, 6);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(147, 46);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Hola";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += BtnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(320, 207);
            btnCancelar.Margin = new Padding(5, 6, 5, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(129, 46);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Adiós";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(21, 24);
            lblNombre.Margin = new Padding(5, 0, 5, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(94, 30);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(144, 21);
            txtNombre.Margin = new Padding(5, 6, 5, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(169, 35);
            txtNombre.TabIndex = 0;
            // 
            // lbxMensajes
            // 
            lbxMensajes.FormattingEnabled = true;
            lbxMensajes.ItemHeight = 30;
            lbxMensajes.Location = new Point(21, 80);
            lbxMensajes.Name = "lbxMensajes";
            lbxMensajes.Size = new Size(292, 94);
            lbxMensajes.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(342, 21);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 45);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 315);
            Controls.Add(btnAdd);
            Controls.Add(lbxMensajes);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblNombre;
        private TextBox txtNombre;
        private ListBox lbxMensajes;
        private Button btnAdd;
    }
}