namespace Medicamentos
{
    partial class FrmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            LblMedicamento = new Label();
            LblDespachar = new Label();
            BtnCancelar = new Button();
            BtnEnviar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 25);
            label1.Name = "label1";
            label1.Size = new Size(216, 24);
            label1.TabIndex = 0;
            label1.Text = "Resumen del pedido";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.farmacia;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 105);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 2;
            label2.Text = "Medicamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 186);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 3;
            label3.Text = "Despachar a:";
            // 
            // LblMedicamento
            // 
            LblMedicamento.AutoSize = true;
            LblMedicamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblMedicamento.Location = new Point(60, 130);
            LblMedicamento.Name = "LblMedicamento";
            LblMedicamento.Size = new Size(105, 21);
            LblMedicamento.TabIndex = 4;
            LblMedicamento.Text = "Medicamento";
            // 
            // LblDespachar
            // 
            LblDespachar.AutoSize = true;
            LblDespachar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDespachar.Location = new Point(60, 214);
            LblDespachar.Name = "LblDespachar";
            LblDespachar.Size = new Size(107, 21);
            LblDespachar.TabIndex = 5;
            LblDespachar.Text = "Despachar a....";
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(255, 192, 192);
            BtnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.Location = new Point(12, 359);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(150, 40);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "Cancelar Pedido";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnEnviar
            // 
            BtnEnviar.BackColor = Color.FromArgb(192, 255, 192);
            BtnEnviar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEnviar.Location = new Point(222, 359);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(150, 40);
            BtnEnviar.TabIndex = 7;
            BtnEnviar.Text = "Enviar Pedido";
            BtnEnviar.UseVisualStyleBackColor = false;
            BtnEnviar.Click += BtnEnviar_Click;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 411);
            Controls.Add(BtnEnviar);
            Controls.Add(BtnCancelar);
            Controls.Add(LblDespachar);
            Controls.Add(LblMedicamento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPedido";
            Text = "Pedido al distribuidor ...";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label LblMedicamento;
        private Label LblDespachar;
        private Button BtnCancelar;
        private Button BtnEnviar;
    }
}