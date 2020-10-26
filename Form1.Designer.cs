namespace Lanzamientos_Espaciales_Exitosos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPromedio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMax = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxVarianza = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxSTD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxDEP1Arriba = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxDEP2Arriba = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxDEP3Arriba = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxDEP4Arriba = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoxDEP1Abajo = new System.Windows.Forms.TextBox();
            this.txtBoxDEP2Abajo = new System.Windows.Forms.TextBox();
            this.txtBoxDEP3Abajo = new System.Windows.Forms.TextBox();
            this.txtBoxDEP4Abajo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 623);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calificaciones de Ingeniería de Manufactura 2020-2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Promedio de lanzamientos exitosos por año";
            // 
            // txtBoxPromedio
            // 
            this.txtBoxPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPromedio.Location = new System.Drawing.Point(466, 94);
            this.txtBoxPromedio.Name = "txtBoxPromedio";
            this.txtBoxPromedio.Size = new System.Drawing.Size(226, 22);
            this.txtBoxPromedio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor mínimo";
            // 
            // txtBoxMin
            // 
            this.txtBoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMin.Location = new System.Drawing.Point(466, 166);
            this.txtBoxMin.Name = "txtBoxMin";
            this.txtBoxMin.Size = new System.Drawing.Size(226, 22);
            this.txtBoxMin.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor Máximo";
            // 
            // txtBoxMax
            // 
            this.txtBoxMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMax.Location = new System.Drawing.Point(466, 232);
            this.txtBoxMax.Name = "txtBoxMax";
            this.txtBoxMax.Size = new System.Drawing.Size(226, 22);
            this.txtBoxMax.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(466, 280);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(881, 392);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(722, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Varianza P.";
            // 
            // txtBoxVarianza
            // 
            this.txtBoxVarianza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxVarianza.Location = new System.Drawing.Point(725, 128);
            this.txtBoxVarianza.Name = "txtBoxVarianza";
            this.txtBoxVarianza.Size = new System.Drawing.Size(152, 22);
            this.txtBoxVarianza.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(722, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Desviación Estandar P.";
            // 
            // txtBoxSTD
            // 
            this.txtBoxSTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSTD.Location = new System.Drawing.Point(725, 200);
            this.txtBoxSTD.Name = "txtBoxSTD";
            this.txtBoxSTD.Size = new System.Drawing.Size(152, 22);
            this.txtBoxSTD.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(911, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "D.E.P.1";
            // 
            // txtBoxDEP1Arriba
            // 
            this.txtBoxDEP1Arriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDEP1Arriba.Location = new System.Drawing.Point(969, 37);
            this.txtBoxDEP1Arriba.Name = "txtBoxDEP1Arriba";
            this.txtBoxDEP1Arriba.Size = new System.Drawing.Size(107, 22);
            this.txtBoxDEP1Arriba.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1002, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Arriba";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1212, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Abajo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(911, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "D.E.P.2";
            // 
            // txtBoxDEP2Arriba
            // 
            this.txtBoxDEP2Arriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDEP2Arriba.Location = new System.Drawing.Point(969, 74);
            this.txtBoxDEP2Arriba.Name = "txtBoxDEP2Arriba";
            this.txtBoxDEP2Arriba.Size = new System.Drawing.Size(107, 22);
            this.txtBoxDEP2Arriba.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(911, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "D.E.P.3";
            // 
            // txtBoxDEP3Arriba
            // 
            this.txtBoxDEP3Arriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDEP3Arriba.Location = new System.Drawing.Point(969, 111);
            this.txtBoxDEP3Arriba.Name = "txtBoxDEP3Arriba";
            this.txtBoxDEP3Arriba.Size = new System.Drawing.Size(107, 22);
            this.txtBoxDEP3Arriba.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(911, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "D.E.P.4";
            // 
            // txtBoxDEP4Arriba
            // 
            this.txtBoxDEP4Arriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDEP4Arriba.Location = new System.Drawing.Point(969, 148);
            this.txtBoxDEP4Arriba.Name = "txtBoxDEP4Arriba";
            this.txtBoxDEP4Arriba.Size = new System.Drawing.Size(107, 22);
            this.txtBoxDEP4Arriba.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1123, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "D.E.P.1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1123, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "D.E.P.2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1123, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "D.E.P.3";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1123, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "D.E.P.4";
            // 
            // txtBoxDEP1Abajo
            // 
            this.txtBoxDEP1Abajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDEP1Abajo.Location = new System.Drawing.Point(1181, 37);
            this.txtBoxDEP1Abajo.Name = "txtBoxDEP1Abajo";
            this.txtBoxDEP1Abajo.Size = new System.Drawing.Size(107, 22);
            this.txtBoxDEP1Abajo.TabIndex = 3;
            // 
            // txtBoxDEP2Abajo
            // 
            this.txtBoxDEP2Abajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDEP2Abajo.Location = new System.Drawing.Point(1181, 74);
            this.txtBoxDEP2Abajo.Name = "txtBoxDEP2Abajo";
            this.txtBoxDEP2Abajo.Size = new System.Drawing.Size(107, 22);
            this.txtBoxDEP2Abajo.TabIndex = 3;
            // 
            // txtBoxDEP3Abajo
            // 
            this.txtBoxDEP3Abajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDEP3Abajo.Location = new System.Drawing.Point(1181, 111);
            this.txtBoxDEP3Abajo.Name = "txtBoxDEP3Abajo";
            this.txtBoxDEP3Abajo.Size = new System.Drawing.Size(107, 22);
            this.txtBoxDEP3Abajo.TabIndex = 3;
            // 
            // txtBoxDEP4Abajo
            // 
            this.txtBoxDEP4Abajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDEP4Abajo.Location = new System.Drawing.Point(1181, 148);
            this.txtBoxDEP4Abajo.Name = "txtBoxDEP4Abajo";
            this.txtBoxDEP4Abajo.Size = new System.Drawing.Size(107, 22);
            this.txtBoxDEP4Abajo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(928, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Función de Densidad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(1350, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 714);
            this.vScrollBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1370, 714);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.txtBoxMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxSTD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxDEP4Abajo);
            this.Controls.Add(this.txtBoxDEP4Arriba);
            this.Controls.Add(this.txtBoxDEP3Abajo);
            this.Controls.Add(this.txtBoxDEP2Abajo);
            this.Controls.Add(this.txtBoxDEP3Arriba);
            this.Controls.Add(this.txtBoxDEP1Abajo);
            this.Controls.Add(this.txtBoxDEP2Arriba);
            this.Controls.Add(this.txtBoxDEP1Arriba);
            this.Controls.Add(this.txtBoxVarianza);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPromedio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificaciones Ing. de Manufactura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPromedio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxMax;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxVarianza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxSTD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxDEP1Arriba;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxDEP2Arriba;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxDEP3Arriba;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxDEP4Arriba;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBoxDEP1Abajo;
        private System.Windows.Forms.TextBox txtBoxDEP2Abajo;
        private System.Windows.Forms.TextBox txtBoxDEP3Abajo;
        private System.Windows.Forms.TextBox txtBoxDEP4Abajo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

