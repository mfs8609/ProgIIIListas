using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProgIIIListas
{
    public partial class Form1 : Form
    {
        Cadenas obj = new Cadenas();
        List<String> vcade = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtCargar_Click(object sender, EventArgs e)
        {
            int k = 0, x1, x2, c;
            DvDatos.Rows.Clear();
            vcade.Clear();
            using (StreamReader BLectura = new StreamReader("Articulos.csv"))
            {
                while (!BLectura.EndOfStream)
                {
                    BLectura.ReadLine();
                    vcade.Add(BLectura.ReadLine());
                    DvDatos.Rows.Add();
                    x1 = x2 = c = 0;
                    while (x2 < vcade[k].Length)
                    {
                        x2 = obj.buscar(vcade[k], ';', x1);
                        DvDatos.Rows[k].Cells[c].Value = obj.cortar(vcade[k], x1, x2);
                        if (c == 2) //Cuando C es 2 quiere decir que es la celda de cantidad, se convierte a si misma en entero para poder realizar un ordenamiento numerico y no por string
                            DvDatos.Rows[k].Cells[c].Value = Convert.ToInt32(DvDatos.Rows[k].Cells[c].Value.ToString());
                        x1 = x2 + 1;
                        c++;
                    }
                    k++;
                }
            }
            BtOrdenar.Enabled = true;
        }

        private void DvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n;
            //TxCodigo.Enabled = false;
            n = DvDatos.CurrentRow.Index;
            LbReg.Text = n.ToString();
            TxCodigo.Text = DvDatos.Rows[n].Cells[0].Value.ToString();
            TxArticulo.Text = DvDatos.Rows[n].Cells[1].Value.ToString();
            TxCantidad.Text = DvDatos.Rows[n].Cells[2].Value.ToString();
            TxLimite.Text = DvDatos.Rows[n].Cells[3].Value.ToString();
            BtActualizar.Enabled = true;
            BtBorrar.Enabled = true;
        }

        private void BtActualizar_Click(object sender, EventArgs e)
        {
            int n;
            if (LbReg.Text != "")
            {
                n = Convert.ToInt32(LbReg.Text);
                DvDatos.Rows[n].Cells[1].Value = TxArticulo.Text;
                DvDatos.Rows[n].Cells[2].Value = Convert.ToInt32(TxCantidad.Text.ToString());
                DvDatos.Rows[n].Cells[3].Value = TxLimite.Text;
                DvDatos.Rows[n].Cells[0].Value = TxCodigo.Text;
                TxCodigo.Enabled = true;
                LbReg.Text = "";
                TxCodigo.Text = "";
                TxArticulo.Text = "";
                TxCantidad.Text = "";
                TxLimite.Text = "";
                BtBorrar.Enabled = false;
                BtActualizar.Enabled = false;
            }
        }

        private void BtBorrar_Click(object sender, EventArgs e)
        {
            int n;
            if (LbReg.Text != "")
            {
                n = Convert.ToInt32(LbReg.Text);
                DvDatos.Rows.RemoveAt(n); //Funcion que borra una fila segun el indice              
                LbReg.Text = "";
                TxCodigo.Text = "";
                TxArticulo.Text = "";
                TxCantidad.Text = "";
                TxLimite.Text = "";
                BtBorrar.Enabled = false;
                BtActualizar.Enabled = false;
            }
        }

        private void BtOrdenar_Click(object sender, EventArgs e)
        {
            obj.Ordenar(DvDatos);
            BtOrdenar.Enabled = false;
        }
    }
}
