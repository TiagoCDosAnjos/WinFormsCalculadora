namespace WinFormsCalculadora
{
    partial class Form1
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
            tbNumero1 = new TextBox();
            tbNumero2 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            btnCalcular = new Button();
            rbSomar = new RadioButton();
            rbDividir = new RadioButton();
            rbMultiplicar = new RadioButton();
            rbSubtrair = new RadioButton();
            groupBox1 = new GroupBox();
            btnLimpar = new Button();
            listBoxResultados = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbNumero1
            // 
            tbNumero1.Location = new Point(166, 68);
            tbNumero1.Name = "tbNumero1";
            tbNumero1.Size = new Size(100, 23);
            tbNumero1.TabIndex = 0;
            // 
            // tbNumero2
            // 
            tbNumero2.Location = new Point(166, 107);
            tbNumero2.Name = "tbNumero2";
            tbNumero2.Size = new Size(100, 23);
            tbNumero2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 71);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Número 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 110);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Número 2";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(91, 270);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(304, 25);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // rbSomar
            // 
            rbSomar.AutoSize = true;
            rbSomar.Location = new Point(6, 12);
            rbSomar.Name = "rbSomar";
            rbSomar.Size = new Size(59, 19);
            rbSomar.TabIndex = 6;
            rbSomar.TabStop = true;
            rbSomar.Text = "Somar";
            rbSomar.UseVisualStyleBackColor = true;
            // 
            // rbDividir
            // 
            rbDividir.AutoSize = true;
            rbDividir.Location = new Point(5, 87);
            rbDividir.Name = "rbDividir";
            rbDividir.Size = new Size(59, 19);
            rbDividir.TabIndex = 7;
            rbDividir.TabStop = true;
            rbDividir.Text = "Dividir";
            rbDividir.UseVisualStyleBackColor = true;
            rbDividir.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbMultiplicar
            // 
            rbMultiplicar.AutoSize = true;
            rbMultiplicar.Location = new Point(6, 62);
            rbMultiplicar.Name = "rbMultiplicar";
            rbMultiplicar.Size = new Size(82, 19);
            rbMultiplicar.TabIndex = 8;
            rbMultiplicar.TabStop = true;
            rbMultiplicar.Text = "Multiplicar";
            rbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbSubtrair
            // 
            rbSubtrair.AutoSize = true;
            rbSubtrair.Location = new Point(6, 37);
            rbSubtrair.Name = "rbSubtrair";
            rbSubtrair.Size = new Size(66, 19);
            rbSubtrair.TabIndex = 9;
            rbSubtrair.TabStop = true;
            rbSubtrair.Text = "Subtrair";
            rbSubtrair.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbMultiplicar);
            groupBox1.Controls.Add(rbSubtrair);
            groupBox1.Controls.Add(rbSomar);
            groupBox1.Controls.Add(rbDividir);
            groupBox1.Location = new Point(91, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 117);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione a operação";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(91, 301);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(304, 25);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.ItemHeight = 15;
            listBoxResultados.Location = new Point(91, 335);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(304, 214);
            listBoxResultados.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 571);
            Controls.Add(listBoxResultados);
            Controls.Add(btnLimpar);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(btnCalcular);
            Controls.Add(label1);
            Controls.Add(tbNumero2);
            Controls.Add(tbNumero1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNumero1;
        private TextBox tbNumero2;
        private Label label1;
        private Label label3;
        private Button btnCalcular;
        private RadioButton rbSomar;
        private RadioButton rbDividir;
        private RadioButton rbMultiplicar;
        private RadioButton rbSubtrair;
        private GroupBox groupBox1;
        private Button btnLimpar;
        private ListBox listBoxResultados;
    }
}
