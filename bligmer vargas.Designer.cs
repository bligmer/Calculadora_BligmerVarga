namespace bligmer_vargas
{
    partial class btnLimpiar
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
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            txtResultado = new TextBox();
            primero = new Label();
            segundo = new Label();
            resultado = new Label();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(252, 104);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(95, 23);
            txtNum2.TabIndex = 0;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(252, 48);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 1;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(252, 176);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(95, 23);
            txtResultado.TabIndex = 2;
            // 
            // primero
            // 
            primero.AutoSize = true;
            primero.Location = new Point(386, 56);
            primero.Name = "primero";
            primero.Size = new Size(51, 15);
            primero.TabIndex = 3;
            primero.Text = "1er num";
            // 
            // segundo
            // 
            segundo.AutoSize = true;
            segundo.Location = new Point(386, 107);
            segundo.Name = "segundo";
            segundo.Size = new Size(55, 15);
            segundo.TabIndex = 4;
            segundo.Text = "2do num";
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(388, 182);
            resultado.Name = "resultado";
            resultado.Size = new Size(69, 15);
            resultado.TabIndex = 5;
            resultado.Text = "RESULTADO";
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(62, 256);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 6;
            btnSumar.Text = "sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(171, 256);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(75, 23);
            btnRestar.TabIndex = 7;
            btnRestar.Text = "restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(293, 256);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 8;
            btnMultiplicar.Text = "multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(411, 256);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 9;
            btnDividir.Text = "dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(539, 176);
            button1.Name = "button1";
            button1.Size = new Size(75, 105);
            button1.TabIndex = 10;
            button1.Text = "limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 18);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(resultado);
            Controls.Add(segundo);
            Controls.Add(primero);
            Controls.Add(txtResultado);
            Controls.Add(txtNum1);
            Controls.Add(txtNum2);
            Name = "btnLimpiar";
            Text = "BLIGMER VARGAS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum2;
        private TextBox txtNum1;
        private TextBox txtResultado;
        private Label primero;
        private Label segundo;
        private Label resultado;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button button1;
        private Label label1;
    }
}
