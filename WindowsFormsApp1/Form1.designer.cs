namespace WindowsFormsApp1
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
            this.txtObservacionPreferencia = new System.Windows.Forms.TextBox();
            this.cboFranjaHoraria = new System.Windows.Forms.ComboBox();
            this.lstMaterias = new System.Windows.Forms.ListBox();
            this.txtCantidadVacantes = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.lstCombinaciones = new System.Windows.Forms.ListBox();
            this.btnCargarMateria = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnGenerarCombinaciones = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnLimpiartodo = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtObservacionPreferencia
            // 
            this.txtObservacionPreferencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtObservacionPreferencia.BackColor = System.Drawing.Color.LightCoral;
            this.txtObservacionPreferencia.Location = new System.Drawing.Point(12, 521);
            this.txtObservacionPreferencia.Name = "txtObservacionPreferencia";
            this.txtObservacionPreferencia.Size = new System.Drawing.Size(161, 20);
            this.txtObservacionPreferencia.TabIndex = 13;
            this.txtObservacionPreferencia.Text = "Filtrar observacion";
            this.txtObservacionPreferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboFranjaHoraria
            // 
            this.cboFranjaHoraria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboFranjaHoraria.BackColor = System.Drawing.Color.LightCoral;
            this.cboFranjaHoraria.FormattingEnabled = true;
            this.cboFranjaHoraria.Location = new System.Drawing.Point(11, 590);
            this.cboFranjaHoraria.Name = "cboFranjaHoraria";
            this.cboFranjaHoraria.Size = new System.Drawing.Size(161, 21);
            this.cboFranjaHoraria.TabIndex = 14;
            this.cboFranjaHoraria.Text = "Franja Horaria";
            // 
            // lstMaterias
            // 
            this.lstMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMaterias.BackColor = System.Drawing.Color.Pink;
            this.lstMaterias.FormattingEnabled = true;
            this.lstMaterias.Location = new System.Drawing.Point(503, 12);
            this.lstMaterias.Name = "lstMaterias";
            this.lstMaterias.Size = new System.Drawing.Size(968, 277);
            this.lstMaterias.TabIndex = 7;
            // 
            // txtCantidadVacantes
            // 
            this.txtCantidadVacantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCantidadVacantes.BackColor = System.Drawing.Color.LightCoral;
            this.txtCantidadVacantes.Location = new System.Drawing.Point(10, 384);
            this.txtCantidadVacantes.Name = "txtCantidadVacantes";
            this.txtCantidadVacantes.Size = new System.Drawing.Size(161, 20);
            this.txtCantidadVacantes.TabIndex = 1;
            this.txtCantidadVacantes.Text = "Cantidad de vacantes";
            this.txtCantidadVacantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtObservaciones.BackColor = System.Drawing.Color.LightCoral;
            this.txtObservaciones.Location = new System.Drawing.Point(12, 453);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(161, 20);
            this.txtObservaciones.TabIndex = 2;
            this.txtObservaciones.Text = "Observaciones";
            this.txtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtComision
            // 
            this.txtComision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtComision.BackColor = System.Drawing.Color.LightCoral;
            this.txtComision.Location = new System.Drawing.Point(13, 98);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(160, 20);
            this.txtComision.TabIndex = 6;
            this.txtComision.Text = "Comision";
            this.txtComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDia
            // 
            this.txtDia.BackColor = System.Drawing.Color.LightCoral;
            this.txtDia.Location = new System.Drawing.Point(11, 172);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(160, 20);
            this.txtDia.TabIndex = 5;
            this.txtDia.Text = "Dia";
            this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHorario
            // 
            this.txtHorario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHorario.BackColor = System.Drawing.Color.LightCoral;
            this.txtHorario.Location = new System.Drawing.Point(12, 252);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(160, 20);
            this.txtHorario.TabIndex = 4;
            this.txtHorario.Text = "Horario";
            this.txtHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProfesor
            // 
            this.txtProfesor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtProfesor.BackColor = System.Drawing.Color.LightCoral;
            this.txtProfesor.Location = new System.Drawing.Point(10, 320);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(161, 20);
            this.txtProfesor.TabIndex = 3;
            this.txtProfesor.Text = "Profesor";
            this.txtProfesor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstCombinaciones
            // 
            this.lstCombinaciones.AllowDrop = true;
            this.lstCombinaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCombinaciones.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lstCombinaciones.FormattingEnabled = true;
            this.lstCombinaciones.Location = new System.Drawing.Point(306, 308);
            this.lstCombinaciones.Name = "lstCombinaciones";
            this.lstCombinaciones.Size = new System.Drawing.Size(1165, 303);
            this.lstCombinaciones.TabIndex = 8;
            // 
            // btnCargarMateria
            // 
            this.btnCargarMateria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCargarMateria.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCargarMateria.Location = new System.Drawing.Point(306, 35);
            this.btnCargarMateria.Name = "btnCargarMateria";
            this.btnCargarMateria.Size = new System.Drawing.Size(136, 23);
            this.btnCargarMateria.TabIndex = 9;
            this.btnCargarMateria.Text = "Cargar Materias";
            this.btnCargarMateria.UseVisualStyleBackColor = false;
            this.btnCargarMateria.Click += new System.EventHandler(this.btnCargarMateria_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFiltrar.Location = new System.Drawing.Point(306, 114);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(136, 23);
            this.btnFiltrar.TabIndex = 11;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnGenerarCombinaciones
            // 
            this.btnGenerarCombinaciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerarCombinaciones.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGenerarCombinaciones.Location = new System.Drawing.Point(306, 75);
            this.btnGenerarCombinaciones.Name = "btnGenerarCombinaciones";
            this.btnGenerarCombinaciones.Size = new System.Drawing.Size(136, 23);
            this.btnGenerarCombinaciones.TabIndex = 10;
            this.btnGenerarCombinaciones.Text = "Generar Combinacion";
            this.btnGenerarCombinaciones.UseVisualStyleBackColor = false;
            this.btnGenerarCombinaciones.Click += new System.EventHandler(this.btnGenerarCombinaciones_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1491, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(0, 662);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.LightCoral;
            this.txtNombre.Location = new System.Drawing.Point(12, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(306, 195);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(136, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnLimpiartodo
            // 
            this.btnLimpiartodo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiartodo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiartodo.Location = new System.Drawing.Point(306, 236);
            this.btnLimpiartodo.Name = "btnLimpiartodo";
            this.btnLimpiartodo.Size = new System.Drawing.Size(136, 23);
            this.btnLimpiartodo.TabIndex = 18;
            this.btnLimpiartodo.Text = "Limpiar Todo";
            this.btnLimpiartodo.UseVisualStyleBackColor = false;
            this.btnLimpiartodo.Click += new System.EventHandler(this.btnLimpiartodo_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnexcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexcel.Location = new System.Drawing.Point(306, 153);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(136, 23);
            this.btnexcel.TabIndex = 19;
            this.btnexcel.Text = "Excel";
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1491, 662);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnLimpiartodo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lstCombinaciones);
            this.Controls.Add(this.lstMaterias);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.btnGenerarCombinaciones);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.txtObservacionPreferencia);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtCantidadVacantes);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnCargarMateria);
            this.Controls.Add(this.cboFranjaHoraria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtObservacionPreferencia;
        private System.Windows.Forms.ComboBox cboFranjaHoraria;
        private System.Windows.Forms.ListBox lstMaterias;
        private System.Windows.Forms.TextBox txtCantidadVacantes;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.Button btnGenerarCombinaciones;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnCargarMateria;
        private System.Windows.Forms.ListBox lstCombinaciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnLimpiartodo;
        private System.Windows.Forms.Button btnexcel;
    }
}

