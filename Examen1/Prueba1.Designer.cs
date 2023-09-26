namespace Examen1
{
    partial class Prueba1
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEt = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txteActitudinal = new System.Windows.Forms.TextBox();
            this.txte3 = new System.Windows.Forms.TextBox();
            this.txte1 = new System.Windows.Forms.TextBox();
            this.txte2 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lvProm = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label7 = new System.Windows.Forms.Label();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(633, 11);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(84, 25);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo Dato";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(633, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 25);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Control de evaluaciones Programacion 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Del Estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "eva 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "eva2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Actitudinal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "eva3";
            // 
            // lbEt
            // 
            this.lbEt.FormattingEnabled = true;
            this.lbEt.ItemHeight = 15;
            this.lbEt.Location = new System.Drawing.Point(44, 344);
            this.lbEt.Name = "lbEt";
            this.lbEt.Size = new System.Drawing.Size(712, 94);
            this.lbEt.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txteActitudinal);
            this.groupBox1.Controls.Add(this.txte3);
            this.groupBox1.Controls.Add(this.txte1);
            this.groupBox1.Controls.Add(this.txte2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Location = new System.Drawing.Point(32, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 75);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Estudiante";
            // 
            // txteActitudinal
            // 
            this.txteActitudinal.Location = new System.Drawing.Point(485, 38);
            this.txteActitudinal.Name = "txteActitudinal";
            this.txteActitudinal.Size = new System.Drawing.Size(61, 23);
            this.txteActitudinal.TabIndex = 12;
            // 
            // txte3
            // 
            this.txte3.Location = new System.Drawing.Point(418, 38);
            this.txte3.Name = "txte3";
            this.txte3.Size = new System.Drawing.Size(51, 23);
            this.txte3.TabIndex = 11;
            // 
            // txte1
            // 
            this.txte1.Location = new System.Drawing.Point(300, 38);
            this.txte1.Name = "txte1";
            this.txte1.Size = new System.Drawing.Size(55, 23);
            this.txte1.TabIndex = 10;
            // 
            // txte2
            // 
            this.txte2.Location = new System.Drawing.Point(361, 38);
            this.txte2.Name = "txte2";
            this.txte2.Size = new System.Drawing.Size(51, 23);
            this.txte2.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(28, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(232, 23);
            this.txtNombre.TabIndex = 8;
            // 
            // lvProm
            // 
            this.lvProm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvProm.Location = new System.Drawing.Point(41, 129);
            this.lvProm.Name = "lvProm";
            this.lvProm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvProm.Size = new System.Drawing.Size(712, 170);
            this.lvProm.TabIndex = 10;
            this.lvProm.UseCompatibleStateImageBehavior = false;
            this.lvProm.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "nombre";
            this.columnHeader1.Width = 260;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "eva1";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "eva2";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "eva3";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "actitudinal";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "promedio";
            this.columnHeader6.Width = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "ESTADISTICA";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "condicion";
            this.columnHeader7.Width = 100;
            // 
            // Prueba1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvProm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbEt);
            this.Controls.Add(this.label1);
            this.Name = "Prueba1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNuevo;
        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox lbEt;
        private GroupBox groupBox1;
        private TextBox txteActitudinal;
        private TextBox txte3;
        private TextBox txte1;
        private TextBox txte2;
        private TextBox txtNombre;
        private ListView lvProm;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label7;
        private ColumnHeader columnHeader7;
    }
}