using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenericParsing;
using System.IO;
using DBInsertMasivo.Info;
using DBInsertMasivo.Data;
using System.Data.OleDb;
using ClosedXML.Excel;

namespace DBInsertMasivo.Winform
{
    public partial class FrmInsertarMasivo : Form
    {
        List<cp_proveedor_microempresa> Lista;
        List<cp_proveedor_microempresa> ListaEnBase;
        Conexion db;
        public FrmInsertarMasivo()
        {
            InitializeComponent();
            Lista = new List<cp_proveedor_microempresa>();
            ListaEnBase = new List<cp_proveedor_microempresa>();
            db = new Conexion();
        }

        private void FrmInsertarMasivo_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                ListaEnBase = db.GetList();
                Lista = new List<cp_proveedor_microempresa>();
                string fileName = txtRuta.Text;
                var workbook = new XLWorkbook(fileName);
                var ws1 = workbook.Worksheet(2);
                int Cantidad = ws1.RowCount();
                int CantidadFinal = 0;
                for (int i = 0; i < Cantidad; i++)
                {
                    if (!ws1.Row(i + 1).IsEmpty())
                    {
                        CantidadFinal++;
                    }
                    else
                        break;
                }
                pbProceso.Properties.Maximum = CantidadFinal;
                pbProceso.Properties.Step = 1;
                pbProceso.EditValue = 0;
                pbProceso.Properties.Minimum = 1;
                pbProceso.Properties.PercentView = true;

                for (int i = 0; i < Cantidad; i++)
                {
                    if (!ws1.Row(i + 1).IsEmpty())
                    {
                        Lista.Add(new cp_proveedor_microempresa
                        {
                            Ruc = ws1.Cell(i + 1, 1).Value.ToString(),
                            Nombre = ws1.Cell(i + 1, 2).Value.ToString()
                        });

                        pbProceso.PerformStep();
                        pbProceso.Update();
                        gcDetalle.DataSource = Lista;
                        gcDetalle.RefreshDataSource();
                        Application.DoEvents();
                    }
                    else
                        break;
                }
                gcDetalle.DataSource = Lista;
                MessageBox.Show(Lista.Count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtRuta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                OpenFileDialog dialogo = new OpenFileDialog();
                dialogo.Filter = "All files (*.*)|*.*";
                dialogo.InitialDirectory = @"C:\";
                //para mostrar el cuadro de seleccion de archivo hacemos asi:
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    string fileName = System.IO.Path.GetFileName(dialogo.FileName);
                    string path = Path.GetDirectoryName(dialogo.FileName);
                    string tipofile = System.IO.Path.GetExtension(dialogo.FileName);
                    string ruta = path + "\\" + fileName;
                    txtRuta.Text = ruta;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                db.InsertMasivo(Lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                List<cp_proveedor_microempresa> ListaRepetidos = new List<cp_proveedor_microempresa>();
                ListaRepetidos.AddRange(ListaEnBase);
                ListaRepetidos.AddRange(Lista);

                var lst = ListaRepetidos.GroupBy(q => q.Ruc).Select(q => new cp_proveedor_microempresa
                {
                    Ruc = q.Key,
                    Cont = q.Count()
                }).ToList();
                lst = lst.Where(q => q.Cont > 1).ToList();
                foreach (var item in lst)
                {
                    Lista.RemoveAll(q => q.Ruc == item.Ruc);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
