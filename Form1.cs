using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {


                int numCantidad = Convert.ToInt32(txtCantidad.Text);
                int numIteraciones = Convert.ToInt32(txtIteraciones.Text);
                int numDesde = Convert.ToInt32(txtDesde.Text);
                float numProbDPAUA = float.Parse(txtDPAUA.Text, CultureInfo.CreateSpecificCulture("en-US"));
                float numProbDPNAUA = float.Parse(txtDPNAUA.Text, CultureInfo.CreateSpecificCulture("en-US"));
                float numProbDNHA = float.Parse(txtDNHA.Text, CultureInfo.CreateSpecificCulture("en-US"));
                float numProbPAUASA = float.Parse(txtPAUASA.Text, CultureInfo.CreateSpecificCulture("en-US"));
                float numProbPAUANSA = float.Parse(txtPAUANSA.Text, CultureInfo.CreateSpecificCulture("en-US"));
                float numProbPNAUASA = float.Parse(txtPNAUASA.Text, CultureInfo.CreateSpecificCulture("en-US"));
                float numProbPNAUANSA = float.Parse(txtPNAUANSA.Text, CultureInfo.CreateSpecificCulture("en-US"));
                float numProbNHASA = float.Parse(txtNHASA.Text, CultureInfo.CreateSpecificCulture("en-US"));
                float numProbNHANSA = float.Parse(txtNHANSA.Text, CultureInfo.CreateSpecificCulture("en-US"));
                bool valido = true;

                if (numCantidad <= 0 || numIteraciones <= 0 || numDesde <= 0)
                {
                    valido = false;
                    MessageBox.Show("Ingrese un valor válido de cantidad, iteraciones y  desde donde");
                }
                if (!(numProbDPAUA + numProbDPNAUA + numProbDNHA).Equals(1))
                {
                    valido = false;
                    MessageBox.Show("Los valores de probabilidades del destinatario de mail deben sumar 1");
                }

                if (!(numProbPAUASA + numProbPAUANSA).Equals(1))
                {
                    valido = false;
                    MessageBox.Show("Los valores de probabilidades de paciente que asistió el último año deben sumar 1");
                }

                if (!(numProbPNAUASA + numProbPNAUANSA).Equals(1))
                {
                    valido = false;
                    MessageBox.Show("Los valores de probabilidades de paciente que no asistió el último año deben sumar 1");
                }


                if (!(numProbNHASA + numProbNHANSA).Equals(1))
                {
                    valido = false;
                    MessageBox.Show("Los valores de probabilidades de paciente que nunca asistió deben sumar 1");
                }

                if (numProbDPAUA < 0 || numProbDPNAUA < 0 || numProbDNHA < 0 || numProbPAUASA < 0 || numProbPAUANSA < 0 || numProbPNAUASA < 0 || numProbPNAUANSA < 0 || numProbNHASA < 0 || numProbNHANSA < 0)
                {
                    valido = false;
                    MessageBox.Show("No puede ingresar valores de probabilidad negativos");
                }

                if (valido)
                {
                    Simulador simulador = new Simulador(numCantidad, numDesde, numIteraciones - 1, numProbDPAUA, numProbDPNAUA, numProbDNHA, numProbPAUASA, numProbPAUANSA, numProbPNAUASA, numProbPNAUANSA, numProbNHASA, numProbNHANSA);
                    if (numIteraciones > numCantidad)
                    {
                        numIteraciones = numCantidad;
                    }
                    this.txtIteraciones.Text = numIteraciones.ToString();

                    IList<StateRow> filasAMostrarMails;
                    filasAMostrarMails = simulador.simulate();
                    FormSimulacion frm = new FormSimulacion();
                    frm.LlenarDataGridView(filasAMostrarMails);

                    frm.ShowDialog();

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Debe ingresar valores numéricos separados por punto");
            }



        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
            txtIteraciones.Text = "";
            txtDesde.Text = "";
            txtDPAUA.Text = "";
            txtDPNAUA.Text = "";
            txtDNHA.Text = "";
            txtPAUASA.Text = "";
            txtPAUANSA.Text = "";
            txtPNAUASA.Text = "";
            txtPNAUANSA.Text = "";
            txtNHASA.Text = "";
            txtNHANSA.Text = "";
        }
    }
}
