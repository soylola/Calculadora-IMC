namespace CursoProgramacion
{
    partial class frmPrincipal
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
            btnCalcular = new Button();
            lblPeso = new Label();
            lblAltura = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            lblIMC = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Sienna;
            btnCalcular.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.Bisque;
            btnCalcular.Location = new Point(136, 264);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(175, 58);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPeso.ForeColor = Color.Sienna;
            lblPeso.Location = new Point(67, 106);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(90, 33);
            lblPeso.TabIndex = 1;
            lblPeso.Text = "Peso:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAltura.ForeColor = Color.Sienna;
            lblAltura.Location = new Point(67, 153);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(120, 33);
            lblAltura.TabIndex = 2;
            lblAltura.Text = "Altura:";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(193, 112);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(155, 27);
            txtPeso.TabIndex = 3;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(193, 159);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(155, 27);
            txtAltura.TabIndex = 4;
            // 
            // lblIMC
            // 
            lblIMC.AutoSize = true;
            lblIMC.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIMC.ForeColor = Color.SaddleBrown;
            lblIMC.Location = new Point(187, 441);
            lblIMC.Name = "lblIMC";
            lblIMC.Size = new Size(0, 33);
            lblIMC.TabIndex = 5;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.Sienna;
            lblResultado.Location = new Point(146, 386);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(165, 33);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "El IMC es:";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(456, 600);
            Controls.Add(lblResultado);
            Controls.Add(lblIMC);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(lblAltura);
            Controls.Add(lblPeso);
            Controls.Add(btnCalcular);
            MaximumSize = new Size(474, 647);
            MinimumSize = new Size(474, 647);
            Name = "frmPrincipal";
            Text = "Calculadora IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblPeso;
        private Label lblAltura;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Label lblIMC;
        private Label lblResultado;
    }
}
