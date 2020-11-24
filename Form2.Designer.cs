namespace Lanzamientos_Espaciales_Exitosos
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPaso = new System.Windows.Forms.Button();
            this.txtBoxPaso = new System.Windows.Forms.TextBox();
            this.cmbEjeX1_A = new System.Windows.Forms.ComboBox();
            this.cmbEjeX2_A = new System.Windows.Forms.ComboBox();
            this.labelArchivo1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEjeX1_B = new System.Windows.Forms.ComboBox();
            this.cmbEjeX2_B = new System.Windows.Forms.ComboBox();
            this.labelArchivo2 = new System.Windows.Forms.Label();
            this.btnProArchivo1 = new System.Windows.Forms.Button();
            this.btnProArchivo2 = new System.Windows.Forms.Button();
            this.txtBoxProbabilidad1 = new System.Windows.Forms.TextBox();
            this.txtBoxProbabilidad2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPuntoAnalizar = new System.Windows.Forms.TextBox();
            this.buttonAnalizarLikeli = new System.Windows.Forms.Button();
            this.labelLikeli1 = new System.Windows.Forms.Label();
            this.txtBoxLikeli1 = new System.Windows.Forms.TextBox();
            this.labelLikeli2 = new System.Windows.Forms.Label();
            this.txtBoxLikeli2 = new System.Windows.Forms.TextBox();
            this.txtBoxPertenece = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(23, 113);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(955, 512);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Función de Densidad";
            // 
            // btnPaso
            // 
            this.btnPaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaso.Location = new System.Drawing.Point(175, 56);
            this.btnPaso.Name = "btnPaso";
            this.btnPaso.Size = new System.Drawing.Size(102, 23);
            this.btnPaso.TabIndex = 2;
            this.btnPaso.Text = "Fijar Paso";
            this.btnPaso.UseVisualStyleBackColor = true;
            this.btnPaso.Click += new System.EventHandler(this.btnPaso_Click);
            // 
            // txtBoxPaso
            // 
            this.txtBoxPaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPaso.Location = new System.Drawing.Point(39, 56);
            this.txtBoxPaso.Name = "txtBoxPaso";
            this.txtBoxPaso.Size = new System.Drawing.Size(121, 22);
            this.txtBoxPaso.TabIndex = 3;
            // 
            // cmbEjeX1_A
            // 
            this.cmbEjeX1_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEjeX1_A.FormattingEnabled = true;
            this.cmbEjeX1_A.Location = new System.Drawing.Point(309, 43);
            this.cmbEjeX1_A.Name = "cmbEjeX1_A";
            this.cmbEjeX1_A.Size = new System.Drawing.Size(160, 24);
            this.cmbEjeX1_A.TabIndex = 4;
            // 
            // cmbEjeX2_A
            // 
            this.cmbEjeX2_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEjeX2_A.FormattingEnabled = true;
            this.cmbEjeX2_A.Location = new System.Drawing.Point(658, 44);
            this.cmbEjeX2_A.Name = "cmbEjeX2_A";
            this.cmbEjeX2_A.Size = new System.Drawing.Size(160, 24);
            this.cmbEjeX2_A.TabIndex = 4;
            // 
            // labelArchivo1
            // 
            this.labelArchivo1.AutoSize = true;
            this.labelArchivo1.BackColor = System.Drawing.Color.White;
            this.labelArchivo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArchivo1.ForeColor = System.Drawing.Color.Navy;
            this.labelArchivo1.Location = new System.Drawing.Point(352, 5);
            this.labelArchivo1.Name = "labelArchivo1";
            this.labelArchivo1.Size = new System.Drawing.Size(199, 24);
            this.labelArchivo1.TabIndex = 5;
            this.labelArchivo1.Text = "Probabilidad Archivo 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usar una coma para los decimales";
            // 
            // cmbEjeX1_B
            // 
            this.cmbEjeX1_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEjeX1_B.FormattingEnabled = true;
            this.cmbEjeX1_B.Location = new System.Drawing.Point(309, 76);
            this.cmbEjeX1_B.Name = "cmbEjeX1_B";
            this.cmbEjeX1_B.Size = new System.Drawing.Size(160, 24);
            this.cmbEjeX1_B.TabIndex = 4;
            // 
            // cmbEjeX2_B
            // 
            this.cmbEjeX2_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEjeX2_B.FormattingEnabled = true;
            this.cmbEjeX2_B.Location = new System.Drawing.Point(658, 76);
            this.cmbEjeX2_B.Name = "cmbEjeX2_B";
            this.cmbEjeX2_B.Size = new System.Drawing.Size(160, 24);
            this.cmbEjeX2_B.TabIndex = 4;
            // 
            // labelArchivo2
            // 
            this.labelArchivo2.AutoSize = true;
            this.labelArchivo2.BackColor = System.Drawing.Color.White;
            this.labelArchivo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArchivo2.ForeColor = System.Drawing.Color.Red;
            this.labelArchivo2.Location = new System.Drawing.Point(698, 5);
            this.labelArchivo2.Name = "labelArchivo2";
            this.labelArchivo2.Size = new System.Drawing.Size(199, 24);
            this.labelArchivo2.TabIndex = 5;
            this.labelArchivo2.Text = "Probabilidad Archivo 2";
            // 
            // btnProArchivo1
            // 
            this.btnProArchivo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProArchivo1.Location = new System.Drawing.Point(493, 43);
            this.btnProArchivo1.Name = "btnProArchivo1";
            this.btnProArchivo1.Size = new System.Drawing.Size(75, 23);
            this.btnProArchivo1.TabIndex = 2;
            this.btnProArchivo1.Text = "Calcular";
            this.btnProArchivo1.UseVisualStyleBackColor = true;
            this.btnProArchivo1.Click += new System.EventHandler(this.btnProArchivo1_Click);
            // 
            // btnProArchivo2
            // 
            this.btnProArchivo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProArchivo2.Location = new System.Drawing.Point(842, 44);
            this.btnProArchivo2.Name = "btnProArchivo2";
            this.btnProArchivo2.Size = new System.Drawing.Size(75, 23);
            this.btnProArchivo2.TabIndex = 2;
            this.btnProArchivo2.Text = "Calcular";
            this.btnProArchivo2.UseVisualStyleBackColor = true;
            this.btnProArchivo2.Click += new System.EventHandler(this.btnProArchivo2_Click);
            // 
            // txtBoxProbabilidad1
            // 
            this.txtBoxProbabilidad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProbabilidad1.Location = new System.Drawing.Point(493, 78);
            this.txtBoxProbabilidad1.Name = "txtBoxProbabilidad1";
            this.txtBoxProbabilidad1.Size = new System.Drawing.Size(100, 22);
            this.txtBoxProbabilidad1.TabIndex = 6;
            // 
            // txtBoxProbabilidad2
            // 
            this.txtBoxProbabilidad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProbabilidad2.Location = new System.Drawing.Point(842, 78);
            this.txtBoxProbabilidad2.Name = "txtBoxProbabilidad2";
            this.txtBoxProbabilidad2.Size = new System.Drawing.Size(100, 22);
            this.txtBoxProbabilidad2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(984, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Punto a analizar";
            // 
            // txtBoxPuntoAnalizar
            // 
            this.txtBoxPuntoAnalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPuntoAnalizar.Location = new System.Drawing.Point(987, 194);
            this.txtBoxPuntoAnalizar.Name = "txtBoxPuntoAnalizar";
            this.txtBoxPuntoAnalizar.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPuntoAnalizar.TabIndex = 7;
            // 
            // buttonAnalizarLikeli
            // 
            this.buttonAnalizarLikeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalizarLikeli.Location = new System.Drawing.Point(987, 243);
            this.buttonAnalizarLikeli.Name = "buttonAnalizarLikeli";
            this.buttonAnalizarLikeli.Size = new System.Drawing.Size(100, 28);
            this.buttonAnalizarLikeli.TabIndex = 8;
            this.buttonAnalizarLikeli.Text = "Calcular";
            this.buttonAnalizarLikeli.UseVisualStyleBackColor = true;
            this.buttonAnalizarLikeli.Click += new System.EventHandler(this.buttonAnalizarLikeli_Click);
            // 
            // labelLikeli1
            // 
            this.labelLikeli1.AutoSize = true;
            this.labelLikeli1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikeli1.Location = new System.Drawing.Point(984, 294);
            this.labelLikeli1.Name = "labelLikeli1";
            this.labelLikeli1.Size = new System.Drawing.Size(156, 16);
            this.labelLikeli1.TabIndex = 9;
            this.labelLikeli1.Text = "Likelihood: Distribución 1";
            // 
            // txtBoxLikeli1
            // 
            this.txtBoxLikeli1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLikeli1.Location = new System.Drawing.Point(987, 320);
            this.txtBoxLikeli1.Name = "txtBoxLikeli1";
            this.txtBoxLikeli1.Size = new System.Drawing.Size(122, 22);
            this.txtBoxLikeli1.TabIndex = 7;
            // 
            // labelLikeli2
            // 
            this.labelLikeli2.AutoSize = true;
            this.labelLikeli2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikeli2.Location = new System.Drawing.Point(984, 353);
            this.labelLikeli2.Name = "labelLikeli2";
            this.labelLikeli2.Size = new System.Drawing.Size(156, 16);
            this.labelLikeli2.TabIndex = 9;
            this.labelLikeli2.Text = "Likelihood: Distribución 2";
            // 
            // txtBoxLikeli2
            // 
            this.txtBoxLikeli2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLikeli2.Location = new System.Drawing.Point(987, 378);
            this.txtBoxLikeli2.Name = "txtBoxLikeli2";
            this.txtBoxLikeli2.Size = new System.Drawing.Size(122, 22);
            this.txtBoxLikeli2.TabIndex = 7;
            // 
            // txtBoxPertenece
            // 
            this.txtBoxPertenece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPertenece.Location = new System.Drawing.Point(987, 443);
            this.txtBoxPertenece.Name = "txtBoxPertenece";
            this.txtBoxPertenece.Size = new System.Drawing.Size(122, 22);
            this.txtBoxPertenece.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(984, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Pertenece a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(984, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usar una coma para los decimales";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(1162, 637);
            this.Controls.Add(this.txtBoxPertenece);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelLikeli2);
            this.Controls.Add(this.labelLikeli1);
            this.Controls.Add(this.buttonAnalizarLikeli);
            this.Controls.Add(this.txtBoxLikeli2);
            this.Controls.Add(this.txtBoxLikeli1);
            this.Controls.Add(this.txtBoxPuntoAnalizar);
            this.Controls.Add(this.txtBoxProbabilidad2);
            this.Controls.Add(this.txtBoxProbabilidad1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelArchivo2);
            this.Controls.Add(this.labelArchivo1);
            this.Controls.Add(this.cmbEjeX2_B);
            this.Controls.Add(this.cmbEjeX2_A);
            this.Controls.Add(this.cmbEjeX1_B);
            this.Controls.Add(this.cmbEjeX1_A);
            this.Controls.Add(this.txtBoxPaso);
            this.Controls.Add(this.btnProArchivo2);
            this.Controls.Add(this.btnProArchivo1);
            this.Controls.Add(this.btnPaso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Función de Densidad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Form2_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPaso;
        private System.Windows.Forms.TextBox txtBoxPaso;
        private System.Windows.Forms.ComboBox cmbEjeX1_A;
        private System.Windows.Forms.ComboBox cmbEjeX2_A;
        private System.Windows.Forms.Label labelArchivo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEjeX1_B;
        private System.Windows.Forms.ComboBox cmbEjeX2_B;
        private System.Windows.Forms.Label labelArchivo2;
        private System.Windows.Forms.Button btnProArchivo1;
        private System.Windows.Forms.Button btnProArchivo2;
        private System.Windows.Forms.TextBox txtBoxProbabilidad1;
        private System.Windows.Forms.TextBox txtBoxProbabilidad2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxPuntoAnalizar;
        private System.Windows.Forms.Button buttonAnalizarLikeli;
        private System.Windows.Forms.Label labelLikeli1;
        private System.Windows.Forms.TextBox txtBoxLikeli1;
        private System.Windows.Forms.Label labelLikeli2;
        private System.Windows.Forms.TextBox txtBoxLikeli2;
        private System.Windows.Forms.TextBox txtBoxPertenece;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
    }
}