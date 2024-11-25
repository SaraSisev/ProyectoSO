namespace WinFormsPrincipio
{
    partial class FormPrincipal
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
            labelTitulo = new Label();
            textBoxSolicitudes = new TextBox();
            textBoxInicial = new TextBox();
            buttonFCFS = new Button();
            buttonSCAN = new Button();
            buttonCSCAN = new Button();
            buttonSalir = new Button();
            labelOpcion = new Label();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(179, 41);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(429, 32);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Planifiacion de acceso a disco duro";
            // 
            // textBoxSolicitudes
            // 
            textBoxSolicitudes.Location = new Point(237, 133);
            textBoxSolicitudes.Name = "textBoxSolicitudes";
            textBoxSolicitudes.PlaceholderText = "Ingrese los cilindros solicitados";
            textBoxSolicitudes.Size = new Size(265, 31);
            textBoxSolicitudes.TabIndex = 1;
            // 
            // textBoxInicial
            // 
            textBoxInicial.Location = new Point(237, 208);
            textBoxInicial.Name = "textBoxInicial";
            textBoxInicial.PlaceholderText = "Ingrese la posicion inicial del cabezal";
            textBoxInicial.Size = new Size(298, 31);
            textBoxInicial.TabIndex = 2;
            // 
            // buttonFCFS
            // 
            buttonFCFS.Location = new Point(109, 322);
            buttonFCFS.Name = "buttonFCFS";
            buttonFCFS.Size = new Size(112, 34);
            buttonFCFS.TabIndex = 3;
            buttonFCFS.Text = "FCFS";
            buttonFCFS.UseVisualStyleBackColor = true;
            buttonFCFS.Click += buttonFCFS_Click;
            // 
            // buttonSCAN
            // 
            buttonSCAN.Location = new Point(267, 322);
            buttonSCAN.Name = "buttonSCAN";
            buttonSCAN.Size = new Size(112, 34);
            buttonSCAN.TabIndex = 4;
            buttonSCAN.Text = "SCAN";
            buttonSCAN.UseVisualStyleBackColor = true;
            // 
            // buttonCSCAN
            // 
            buttonCSCAN.Location = new Point(423, 322);
            buttonCSCAN.Name = "buttonCSCAN";
            buttonCSCAN.Size = new Size(112, 34);
            buttonCSCAN.TabIndex = 5;
            buttonCSCAN.Text = "C-SCAN";
            buttonCSCAN.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(588, 322);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(112, 34);
            buttonSalir.TabIndex = 6;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // labelOpcion
            // 
            labelOpcion.AutoSize = true;
            labelOpcion.Location = new Point(291, 272);
            labelOpcion.Name = "labelOpcion";
            labelOpcion.Size = new Size(188, 25);
            labelOpcion.TabIndex = 7;
            labelOpcion.Text = "Seleccione una opcion";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelOpcion);
            Controls.Add(buttonSalir);
            Controls.Add(buttonCSCAN);
            Controls.Add(buttonSCAN);
            Controls.Add(buttonFCFS);
            Controls.Add(textBoxInicial);
            Controls.Add(textBoxSolicitudes);
            Controls.Add(labelTitulo);
            Name = "FormPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox textBoxSolicitudes;
        private TextBox textBoxInicial;
        private Button buttonFCFS;
        private Button buttonSCAN;
        private Button buttonCSCAN;
        private Button buttonSalir;
        private Label labelOpcion;
    }
}
