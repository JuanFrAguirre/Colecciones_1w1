namespace Colecciones_1w1
{
  partial class frmColecciones
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
      this.cboCursos = new System.Windows.Forms.ComboBox();
      this.lstCursos = new System.Windows.Forms.ListBox();
      this.btnCargar = new System.Windows.Forms.Button();
      this.txtDato = new System.Windows.Forms.TextBox();
      this.txtPosicion = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnInsertar = new System.Windows.Forms.Button();
      this.btnInsertarPrimero = new System.Windows.Forms.Button();
      this.btnInsertarUltimo = new System.Windows.Forms.Button();
      this.btnInsertarSeleccionado = new System.Windows.Forms.Button();
      this.btnBorrar = new System.Windows.Forms.Button();
      this.btnBorrarPrimero = new System.Windows.Forms.Button();
      this.btnBorrarUltimo = new System.Windows.Forms.Button();
      this.btnBorrarSeleccion = new System.Windows.Forms.Button();
      this.btnBorrarPosicion = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // cboCursos
      // 
      this.cboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboCursos.FormattingEnabled = true;
      this.cboCursos.Location = new System.Drawing.Point(774, 358);
      this.cboCursos.Name = "cboCursos";
      this.cboCursos.Size = new System.Drawing.Size(271, 33);
      this.cboCursos.TabIndex = 0;
      // 
      // lstCursos
      // 
      this.lstCursos.FormattingEnabled = true;
      this.lstCursos.ItemHeight = 25;
      this.lstCursos.Location = new System.Drawing.Point(774, 22);
      this.lstCursos.Name = "lstCursos";
      this.lstCursos.Size = new System.Drawing.Size(271, 304);
      this.lstCursos.TabIndex = 1;
      // 
      // btnCargar
      // 
      this.btnCargar.Location = new System.Drawing.Point(342, 22);
      this.btnCargar.Name = "btnCargar";
      this.btnCargar.Size = new System.Drawing.Size(123, 74);
      this.btnCargar.TabIndex = 2;
      this.btnCargar.Text = "Cargar Dato";
      this.btnCargar.UseVisualStyleBackColor = true;
      this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
      // 
      // txtDato
      // 
      this.txtDato.Location = new System.Drawing.Point(42, 50);
      this.txtDato.Name = "txtDato";
      this.txtDato.Size = new System.Drawing.Size(271, 31);
      this.txtDato.TabIndex = 3;
      // 
      // txtPosicion
      // 
      this.txtPosicion.Location = new System.Drawing.Point(42, 131);
      this.txtPosicion.Name = "txtPosicion";
      this.txtPosicion.Size = new System.Drawing.Size(271, 31);
      this.txtPosicion.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(37, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 25);
      this.label1.TabIndex = 4;
      this.label1.Text = "Dato";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(42, 103);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(94, 25);
      this.label2.TabIndex = 4;
      this.label2.Text = "Posicion";
      // 
      // btnInsertar
      // 
      this.btnInsertar.Location = new System.Drawing.Point(342, 123);
      this.btnInsertar.Name = "btnInsertar";
      this.btnInsertar.Size = new System.Drawing.Size(123, 74);
      this.btnInsertar.TabIndex = 5;
      this.btnInsertar.Text = "Insertar";
      this.btnInsertar.UseVisualStyleBackColor = true;
      this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
      // 
      // btnInsertarPrimero
      // 
      this.btnInsertarPrimero.Location = new System.Drawing.Point(342, 224);
      this.btnInsertarPrimero.Name = "btnInsertarPrimero";
      this.btnInsertarPrimero.Size = new System.Drawing.Size(123, 74);
      this.btnInsertarPrimero.TabIndex = 6;
      this.btnInsertarPrimero.Text = "Insertar Primero";
      this.btnInsertarPrimero.UseVisualStyleBackColor = true;
      this.btnInsertarPrimero.Click += new System.EventHandler(this.btnInsertarPrimero_Click);
      // 
      // btnInsertarUltimo
      // 
      this.btnInsertarUltimo.Location = new System.Drawing.Point(342, 325);
      this.btnInsertarUltimo.Name = "btnInsertarUltimo";
      this.btnInsertarUltimo.Size = new System.Drawing.Size(123, 74);
      this.btnInsertarUltimo.TabIndex = 7;
      this.btnInsertarUltimo.Text = "Insertar Ultimo";
      this.btnInsertarUltimo.UseVisualStyleBackColor = true;
      this.btnInsertarUltimo.Click += new System.EventHandler(this.btnInsertarUltimo_Click);
      // 
      // btnInsertarSeleccionado
      // 
      this.btnInsertarSeleccionado.Location = new System.Drawing.Point(342, 426);
      this.btnInsertarSeleccionado.Name = "btnInsertarSeleccionado";
      this.btnInsertarSeleccionado.Size = new System.Drawing.Size(123, 74);
      this.btnInsertarSeleccionado.TabIndex = 9;
      this.btnInsertarSeleccionado.Text = "Insertar Seleccionado";
      this.btnInsertarSeleccionado.UseVisualStyleBackColor = true;
      this.btnInsertarSeleccionado.Click += new System.EventHandler(this.btnInsertarSeleccionado_Click);
      // 
      // btnBorrar
      // 
      this.btnBorrar.Location = new System.Drawing.Point(529, 22);
      this.btnBorrar.Name = "btnBorrar";
      this.btnBorrar.Size = new System.Drawing.Size(123, 74);
      this.btnBorrar.TabIndex = 10;
      this.btnBorrar.Text = "Borrar Dato";
      this.btnBorrar.UseVisualStyleBackColor = true;
      this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
      // 
      // btnBorrarPrimero
      // 
      this.btnBorrarPrimero.Location = new System.Drawing.Point(529, 224);
      this.btnBorrarPrimero.Name = "btnBorrarPrimero";
      this.btnBorrarPrimero.Size = new System.Drawing.Size(123, 74);
      this.btnBorrarPrimero.TabIndex = 11;
      this.btnBorrarPrimero.Text = "Borrar Primero";
      this.btnBorrarPrimero.UseVisualStyleBackColor = true;
      this.btnBorrarPrimero.Click += new System.EventHandler(this.btnBorrarPrimero_Click);
      // 
      // btnBorrarUltimo
      // 
      this.btnBorrarUltimo.Location = new System.Drawing.Point(529, 325);
      this.btnBorrarUltimo.Name = "btnBorrarUltimo";
      this.btnBorrarUltimo.Size = new System.Drawing.Size(123, 74);
      this.btnBorrarUltimo.TabIndex = 12;
      this.btnBorrarUltimo.Text = "Borrar Ultimo";
      this.btnBorrarUltimo.UseVisualStyleBackColor = true;
      this.btnBorrarUltimo.Click += new System.EventHandler(this.btnBorrarUltimo_Click);
      // 
      // btnBorrarSeleccion
      // 
      this.btnBorrarSeleccion.Location = new System.Drawing.Point(529, 426);
      this.btnBorrarSeleccion.Name = "btnBorrarSeleccion";
      this.btnBorrarSeleccion.Size = new System.Drawing.Size(123, 74);
      this.btnBorrarSeleccion.TabIndex = 13;
      this.btnBorrarSeleccion.Text = "Borrar Seleccionado";
      this.btnBorrarSeleccion.UseVisualStyleBackColor = true;
      this.btnBorrarSeleccion.Click += new System.EventHandler(this.btnBorrarSeleccion_Click);
      // 
      // btnBorrarPosicion
      // 
      this.btnBorrarPosicion.Location = new System.Drawing.Point(529, 123);
      this.btnBorrarPosicion.Name = "btnBorrarPosicion";
      this.btnBorrarPosicion.Size = new System.Drawing.Size(123, 74);
      this.btnBorrarPosicion.TabIndex = 14;
      this.btnBorrarPosicion.Text = "Borrar Posicion";
      this.btnBorrarPosicion.UseVisualStyleBackColor = true;
      this.btnBorrarPosicion.Click += new System.EventHandler(this.btnBorrarPosicion_Click);
      // 
      // frmColecciones
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1161, 710);
      this.Controls.Add(this.btnBorrarPosicion);
      this.Controls.Add(this.btnBorrarSeleccion);
      this.Controls.Add(this.btnBorrarUltimo);
      this.Controls.Add(this.btnBorrarPrimero);
      this.Controls.Add(this.btnBorrar);
      this.Controls.Add(this.btnInsertarSeleccionado);
      this.Controls.Add(this.btnInsertarUltimo);
      this.Controls.Add(this.btnInsertarPrimero);
      this.Controls.Add(this.btnInsertar);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtPosicion);
      this.Controls.Add(this.txtDato);
      this.Controls.Add(this.btnCargar);
      this.Controls.Add(this.lstCursos);
      this.Controls.Add(this.cboCursos);
      this.Name = "frmColecciones";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.frmColecciones_Load_1);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cboCursos;
    private System.Windows.Forms.ListBox lstCursos;
    private System.Windows.Forms.Button btnCargar;
    private System.Windows.Forms.TextBox txtDato;
    private System.Windows.Forms.TextBox txtPosicion;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnInsertar;
    private System.Windows.Forms.Button btnInsertarPrimero;
    private System.Windows.Forms.Button btnInsertarUltimo;
    private System.Windows.Forms.Button btnInsertarSeleccionado;
    private System.Windows.Forms.Button btnBorrar;
    private System.Windows.Forms.Button btnBorrarPrimero;
    private System.Windows.Forms.Button btnBorrarUltimo;
    private System.Windows.Forms.Button btnBorrarSeleccion;
    private System.Windows.Forms.Button btnBorrarPosicion;
  }
}

