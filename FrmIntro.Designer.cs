namespace Medicamentos
{
    partial class FrmIntro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIntro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtMedicamento = new TextBox();
            CmbMedicamento = new ComboBox();
            NumCantidad = new NumericUpDown();
            pictureBox1 = new PictureBox();
            RdbCofarma = new RadioButton();
            RdbEmpsephar = new RadioButton();
            RdbCemefar = new RadioButton();
            ChkPrincipal = new CheckBox();
            ChkSucursal = new CheckBox();
            BtnBorrar = new Button();
            BtnConfirmar = new Button();
            LblErrMedicamento = new Label();
            LblErrTipoMedicamento = new Label();
            LblErrCantidad = new Label();
            LblErrDistribuidor = new Label();
            LblErrSucursal = new Label();
            ((System.ComponentModel.ISupportInitialize)NumCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 41);
            label1.Name = "label1";
            label1.Size = new Size(143, 24);
            label1.TabIndex = 0;
            label1.Text = "Crear pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 106);
            label2.Name = "label2";
            label2.Size = new Size(124, 18);
            label2.TabIndex = 1;
            label2.Text = "Medicamento: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 160);
            label3.Name = "label3";
            label3.Size = new Size(187, 18);
            label3.TabIndex = 2;
            label3.Text = "Tipo de medicamento: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(117, 219);
            label4.Name = "label4";
            label4.Size = new Size(89, 18);
            label4.TabIndex = 3;
            label4.Text = "Cantidad: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(96, 279);
            label5.Name = "label5";
            label5.Size = new Size(110, 18);
            label5.TabIndex = 4;
            label5.Text = "Distribuidor: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(87, 404);
            label6.Name = "label6";
            label6.Size = new Size(119, 18);
            label6.TabIndex = 5;
            label6.Text = "Despachar a: ";
            // 
            // TxtMedicamento
            // 
            TxtMedicamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMedicamento.Location = new Point(214, 101);
            TxtMedicamento.Name = "TxtMedicamento";
            TxtMedicamento.Size = new Size(195, 29);
            TxtMedicamento.TabIndex = 6;
            // 
            // CmbMedicamento
            // 
            CmbMedicamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbMedicamento.FormattingEnabled = true;
            CmbMedicamento.Items.AddRange(new object[] { "Analgésico", "Analéptico", "Anestésico", "Antiácido", "Antidepresivo", "Antibiótico" });
            CmbMedicamento.Location = new Point(214, 156);
            CmbMedicamento.Name = "CmbMedicamento";
            CmbMedicamento.Size = new Size(195, 29);
            CmbMedicamento.TabIndex = 7;
            CmbMedicamento.Text = "Seleccione";
            // 
            // NumCantidad
            // 
            NumCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumCantidad.Location = new Point(212, 214);
            NumCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumCantidad.Name = "NumCantidad";
            NumCantidad.Size = new Size(195, 29);
            NumCantidad.TabIndex = 8;
            NumCantidad.TextAlign = HorizontalAlignment.Right;
            NumCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.farmacia;
            pictureBox1.Location = new Point(17, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // RdbCofarma
            // 
            RdbCofarma.AutoSize = true;
            RdbCofarma.Checked = true;
            RdbCofarma.Font = new Font("Arial Rounded MT Bold", 12F);
            RdbCofarma.Location = new Point(212, 278);
            RdbCofarma.Name = "RdbCofarma";
            RdbCofarma.Size = new Size(94, 22);
            RdbCofarma.TabIndex = 11;
            RdbCofarma.TabStop = true;
            RdbCofarma.Text = "Cofarma";
            RdbCofarma.UseVisualStyleBackColor = true;
            // 
            // RdbEmpsephar
            // 
            RdbEmpsephar.AutoSize = true;
            RdbEmpsephar.Font = new Font("Arial Rounded MT Bold", 12F);
            RdbEmpsephar.Location = new Point(212, 310);
            RdbEmpsephar.Name = "RdbEmpsephar";
            RdbEmpsephar.Size = new Size(117, 22);
            RdbEmpsephar.TabIndex = 12;
            RdbEmpsephar.Text = "Empsephar";
            RdbEmpsephar.UseVisualStyleBackColor = true;
            // 
            // RdbCemefar
            // 
            RdbCemefar.AutoSize = true;
            RdbCemefar.Font = new Font("Arial Rounded MT Bold", 12F);
            RdbCemefar.Location = new Point(212, 342);
            RdbCemefar.Name = "RdbCemefar";
            RdbCemefar.Size = new Size(94, 22);
            RdbCemefar.TabIndex = 13;
            RdbCemefar.Text = "Cemefar";
            RdbCemefar.UseVisualStyleBackColor = true;
            // 
            // ChkPrincipal
            // 
            ChkPrincipal.AutoSize = true;
            ChkPrincipal.Checked = true;
            ChkPrincipal.CheckState = CheckState.Checked;
            ChkPrincipal.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChkPrincipal.Location = new Point(212, 401);
            ChkPrincipal.Name = "ChkPrincipal";
            ChkPrincipal.Size = new Size(97, 22);
            ChkPrincipal.TabIndex = 14;
            ChkPrincipal.Text = "Principal";
            ChkPrincipal.UseVisualStyleBackColor = true;
            // 
            // ChkSucursal
            // 
            ChkSucursal.AutoSize = true;
            ChkSucursal.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChkSucursal.Location = new Point(212, 434);
            ChkSucursal.Name = "ChkSucursal";
            ChkSucursal.Size = new Size(98, 22);
            ChkSucursal.TabIndex = 15;
            ChkSucursal.Text = "Sucursal";
            ChkSucursal.UseVisualStyleBackColor = true;
            // 
            // BtnBorrar
            // 
            BtnBorrar.BackColor = Color.FromArgb(255, 192, 192);
            BtnBorrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBorrar.Location = new Point(181, 497);
            BtnBorrar.Name = "BtnBorrar";
            BtnBorrar.Size = new Size(110, 40);
            BtnBorrar.TabIndex = 16;
            BtnBorrar.Text = "Borrar";
            BtnBorrar.UseVisualStyleBackColor = false;
            BtnBorrar.Click += BtnBorrar_Click;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.BackColor = Color.FromArgb(192, 255, 192);
            BtnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConfirmar.Location = new Point(297, 497);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(110, 40);
            BtnConfirmar.TabIndex = 17;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = false;
            BtnConfirmar.Click += BtnConfirmar_Click;
            // 
            // LblErrMedicamento
            // 
            LblErrMedicamento.AutoSize = true;
            LblErrMedicamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblErrMedicamento.ForeColor = Color.Red;
            LblErrMedicamento.Location = new Point(214, 131);
            LblErrMedicamento.Name = "LblErrMedicamento";
            LblErrMedicamento.Size = new Size(141, 15);
            LblErrMedicamento.TabIndex = 19;
            LblErrMedicamento.Text = "Digite un medicamento.";
            // 
            // LblErrTipoMedicamento
            // 
            LblErrTipoMedicamento.AutoSize = true;
            LblErrTipoMedicamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblErrTipoMedicamento.ForeColor = Color.Red;
            LblErrTipoMedicamento.Location = new Point(214, 188);
            LblErrTipoMedicamento.Name = "LblErrTipoMedicamento";
            LblErrTipoMedicamento.Size = new Size(209, 15);
            LblErrTipoMedicamento.TabIndex = 20;
            LblErrTipoMedicamento.Text = "Seleccione un tipo de medicamento.";
            // 
            // LblErrCantidad
            // 
            LblErrCantidad.AutoSize = true;
            LblErrCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblErrCantidad.ForeColor = Color.Red;
            LblErrCantidad.Location = new Point(214, 246);
            LblErrCantidad.Name = "LblErrCantidad";
            LblErrCantidad.Size = new Size(152, 15);
            LblErrCantidad.TabIndex = 21;
            LblErrCantidad.Text = "Digite una cantidad válida.";
            // 
            // LblErrDistribuidor
            // 
            LblErrDistribuidor.AutoSize = true;
            LblErrDistribuidor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblErrDistribuidor.ForeColor = Color.Red;
            LblErrDistribuidor.Location = new Point(214, 367);
            LblErrDistribuidor.Name = "LblErrDistribuidor";
            LblErrDistribuidor.Size = new Size(153, 15);
            LblErrDistribuidor.TabIndex = 22;
            LblErrDistribuidor.Text = "Seleccione un distribuidor.";
            // 
            // LblErrSucursal
            // 
            LblErrSucursal.AutoSize = true;
            LblErrSucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblErrSucursal.ForeColor = Color.Red;
            LblErrSucursal.Location = new Point(214, 459);
            LblErrSucursal.Name = "LblErrSucursal";
            LblErrSucursal.Size = new Size(185, 15);
            LblErrSucursal.TabIndex = 23;
            LblErrSucursal.Text = "Seleccione mínimo una sucursal.";
            // 
            // FrmIntro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(434, 561);
            Controls.Add(LblErrSucursal);
            Controls.Add(LblErrDistribuidor);
            Controls.Add(LblErrCantidad);
            Controls.Add(LblErrTipoMedicamento);
            Controls.Add(LblErrMedicamento);
            Controls.Add(BtnConfirmar);
            Controls.Add(BtnBorrar);
            Controls.Add(ChkSucursal);
            Controls.Add(ChkPrincipal);
            Controls.Add(RdbCemefar);
            Controls.Add(RdbEmpsephar);
            Controls.Add(RdbCofarma);
            Controls.Add(pictureBox1);
            Controls.Add(NumCantidad);
            Controls.Add(CmbMedicamento);
            Controls.Add(TxtMedicamento);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmIntro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema para pedido de medicamentos";
            ((System.ComponentModel.ISupportInitialize)NumCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtMedicamento;
        private ComboBox CmbMedicamento;
        private NumericUpDown NumCantidad;
        private PictureBox pictureBox1;
        private RadioButton RdbCofarma;
        private RadioButton RdbEmpsephar;
        private RadioButton RdbCemefar;
        private CheckBox ChkPrincipal;
        private CheckBox ChkSucursal;
        private Button BtnBorrar;
        private Button BtnConfirmar;
        private Label LblErrMedicamento;
        private Label LblErrTipoMedicamento;
        private Label LblErrCantidad;
        private Label LblErrDistribuidor;
        private Label LblErrSucursal;
    }
}
