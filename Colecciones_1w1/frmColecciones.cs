using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecciones_1w1
{
  public partial class frmColecciones : Form
  {
    public frmColecciones()
    {
      InitializeComponent();
    }

    private void frmColecciones_Load_1(object sender, EventArgs e)
    {
      this.cboCursos.Items.Clear();
      this.cboCursos.Items.Add("1w1");
      this.cboCursos.Items.Add("1w2");
      this.cboCursos.Items.Add("1w3");
      this.cboCursos.SelectedIndex = 0;

      this.lstCursos.Items.Clear();
      this.lstCursos.Items.Add("1w1");
      this.lstCursos.Items.Add("1w2");
      this.lstCursos.Items.Add("1w3");
      this.lstCursos.SelectedIndex = this.lstCursos.Items.Count - 1;
    }

    private void btnCargar_Click(object sender, EventArgs e)
    {
      this.cboCursos.Items.Add(this.txtDato.Text);
      this.lstCursos.Items.Add(this.txtDato.Text);
    }

    private void btnInsertar_Click(object sender, EventArgs e)
    {
      this.cboCursos.Items.Insert(int.Parse(txtPosicion.Text), txtDato.Text);
      this.lstCursos.Items.Insert(int.Parse(txtPosicion.Text), txtDato.Text);
    }

    private void btnInsertarPrimero_Click(object sender, EventArgs e)
    {
      this.cboCursos.Items.Insert(0, this.txtDato.Text);
      this.lstCursos.Items.Insert(0, this.txtDato.Text);
    }

    private void btnInsertarUltimo_Click(object sender, EventArgs e)
    {
      this.cboCursos.Items.Insert(this.cboCursos.Items.Count, this.txtDato.Text);
      this.lstCursos.Items.Insert(this.lstCursos.Items.Count, this.txtDato.Text);
    }

    private void btnInsertarSeleccionado_Click(object sender, EventArgs e)
    {
      this.cboCursos.Items.Insert(this.cboCursos.SelectedIndex, txtDato.Text);
      this.lstCursos.Items.Insert(this.lstCursos.SelectedIndex, txtDato.Text);
    }

    private void btnBorrar_Click(object sender, EventArgs e)
    {
      this.cboCursos.Items.Remove(this.txtDato.Text);
      this.lstCursos.Items.Remove(this.txtDato.Text);
    }

    private void btnBorrarPrimero_Click(object sender, EventArgs e)
    {
      this.cboCursos.Items.RemoveAt(0);
      this.lstCursos.Items.RemoveAt(0);
    }

    private void btnBorrarUltimo_Click(object sender, EventArgs e)
    {
      this.cboCursos.Items.RemoveAt(this.cboCursos.Items.Count - 1);
      this.lstCursos.Items.RemoveAt(this.lstCursos.Items.Count - 1);
    }

    private void btnBorrarPosicion_Click(object sender, EventArgs e)
    {
      this.cboCursos.Items.RemoveAt(int.Parse(txtPosicion.Text));
      this.lstCursos.Items.RemoveAt(int.Parse(txtPosicion.Text));
    }

    private void btnBorrarSeleccion_Click(object sender, EventArgs e)
    {
      this.cboCursos.Items.RemoveAt(this.cboCursos.SelectedIndex);
      this.lstCursos.Items.RemoveAt(this.lstCursos.SelectedIndex);
    }

    private void btnLimpiarLista_Click(object sender, EventArgs e)
    {
      this.cboCursos.Items.Clear();
      this.lstCursos.Items.Clear();
    }

    private void btnMostrarPosicion_Click(object sender, EventArgs e)
    {
      lblPosicion.Text = this.lstCursos.SelectedIndex.ToString();
    }

    private void btnMostrarCantidad_Click(object sender, EventArgs e)
    {
      lblCantidad.Text = this.lstCursos.Items.Count.ToString();
    }

    private void btnMostrarItem_Click(object sender, EventArgs e)
    {
      lblItem.Text = this.lstCursos.SelectedItem.ToString();
    }
  }
}