using FixyNet.Clases.Listas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using FixyNet.Forms;

namespace FixyNet.Clases
{
    class Grafico
    {
        public List<ListaGrafico> listaGraficos = new List<ListaGrafico>();
        public frmGrafico formGrafico = new frmGrafico();
        public int cantidadDispositivos;
        public event EventHandler CerrarClass;
        private bool detengoProceso = false;


        public void Iniciar()
        {


            formGrafico.Cambio += (s, e) =>
            {
                Dibujo(cantidadDispositivos);

            };

            formGrafico.Cerrofrm += (s, e) =>
            {
                detengoProceso = true;
                InvocarDetener();
            };

            Dibujo(cantidadDispositivos);

        }

        public void InvocarDetener()
        {
            this.CerrarClass?.Invoke(this, EventArgs.Empty);
        }

        public void Dibujo(int cantDispo)
        {

            try
            {

                formGrafico.progressGrafico.Maximum = cantDispo;
            }
            catch
            {

            }

            int anchoForm = formGrafico.DesktopBounds.Width - 30;
            int altoForm = formGrafico.DesktopBounds.Height - 30;

            double res = Math.Sqrt(cantDispo);
            int lados = Int32.Parse(Math.Ceiling(res).ToString());

            int filas = lados;
            int columnas = lados;

            int dispTotales = filas * columnas;
            int dispoSobran = dispTotales - cantDispo;

            while (dispoSobran >= columnas)
            {
                filas -= 1;
                dispTotales = filas * columnas;
                dispoSobran = dispTotales - cantDispo;
            }

            int anchoDisp = anchoForm / columnas;
            anchoDisp -= 5;

            int altoDisp = altoForm / filas;
            altoDisp -= 5;

            int espacioFilas = 5;
            int progressValue = 1;
            int cuentaTotal = 0;
            if (detengoProceso == false)
            {
                for (int ii = 1; ii <= filas; ii++)
                {
                    int espacioColumnas = 5;

                    for (int i = 1; i <= columnas; i++)
                    {

                        if (cuentaTotal >= cantDispo)
                        {

                            espacioColumnas += anchoDisp + 5;
                        }
                        else
                        {


                            try
                            {

                                System.Drawing.SolidBrush myBrush;
                                if (listaGraficos[cuentaTotal].estado == "Success")
                                {
                                    myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
                                }
                                else
                                {
                                    myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);

                                }

                                System.Drawing.Graphics formGraphics;
                                formGraphics = formGrafico.CreateGraphics();
                                formGraphics.FillRectangle(myBrush, new Rectangle(espacioColumnas, espacioFilas, anchoDisp, altoDisp));
                                myBrush.Dispose();
                                formGraphics.Dispose();
                                espacioColumnas += anchoDisp + 5;

                                formGrafico.progressGrafico.Value = 1;

                            }
                            catch (Exception ex)
                            {

                                return;
                            }

                            formGrafico.progressGrafico.Value = progressValue;
                        }
                        formGrafico.lblEstado.Text = "Escaneadas: " + cuentaTotal.ToString();

                        cuentaTotal += 1;
                        progressValue += 1;
                    }

                    espacioFilas += altoDisp + 5;

                }

            }
            try
            {
                //  formGrafico.progressGrafico.Value = 0;
            }
            catch
            {

            }

            //   MessageBox.Show("Lista: " + listaGraficos.Count().ToString());
            listaGraficos.Clear();
        }


    }
}
