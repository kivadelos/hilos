using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//usamos la libreria para poder usar hilos
using System.Threading;

using ConexionInterface;
using ConexionStream;
using LibraryRE;

namespace ProyectoHilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            Stream streamw = new Stream();
            Clientes client = new Clientes();
            Thread First;
            Thread Second;       

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            CheckForIllegalCrossThreadCalls = false;

            //Desactivar boton de agregar porque es innecesario por el momento
            btnADD.Enabled = false;
        }

        //
        public void addAndSave()
        {
            for (int i = 0; i < dgvDATA.Rows.Count; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    client.Nombre = dgvDATA.Rows[i].Cells[j].Value.ToString();
                    client.Apellido = dgvDATA.Rows[i].Cells[j + 1].Value.ToString();
                    client.Direccion = dgvDATA.Rows[i].Cells[j + 1].Value.ToString();
                    client.Telefono = dgvDATA.Rows[i].Cells[j + 1].Value.ToString();
                    client.Email = dgvDATA.Rows[i].Cells[j + 1].Value.ToString();
                    client.CURP1 = dgvDATA.Rows[i].Cells[j + 1].Value.ToString();
                    client.Conexion();
                    client.addClient();
                    break;
                }
            }
            dgvDATA.Rows.Clear();
            progrBar.Value = progrBar.Minimum;
            progrFile.Value = progrFile.Minimum;
        }

        //Creacion del metodo para la conexion en esta caso con MYSQL
        public void DBConect()
        {
            int contador = dgvDATA.Rows.Count;
            contador = 100 / contador;
            if (contador <= 100)
            {
                for (int i = 0; i < dgvDATA.Rows.Count; i++)
                {
                    progrBar.Value += contador;
                    Thread.Sleep(3000);
                    if (progrBar.Value == 100)
                    {
                        break;
                    }
                }
                addAndSave();
            }
        }

        //Creacion del metodo para escribir en un archivo en este caso usando streamwriter
        public void WriteFile()
        {
            int conta = dgvDATA.Rows.Count;
            conta = 100 / conta;
            if (conta <= 100)
            {
                for (int i = 0; i < dgvDATA.Rows.Count; i++)
                {
                    progrFile.Value += conta;
                    Thread.Sleep(3000);
                    for (int j = 0; j <= 5; j++)
                    {
                        streamw.Writter(dgvDATA.Rows[i].Cells[j].Value.ToString());
                    }
                    if (progrFile.Value == 100)
                    {
                        break;
                    }
                }
                streamw.closeWritter();
            }
        }


        private void btnSAVE_Click(object sender, EventArgs e)
        {
            
            //Agregar los campos capturados al datagridview
            dgvDATA.Rows.Add(txtNAME.Text, txtLASTNAME.Text, txtADDRESS.Text, txtCELLPHONE.Text, txtEMAIL.Text, txtCURP.Text);

            //Habilitamos el botono de agregar
            btnADD.Enabled = true;

            //limpiamos los campos para volver a escribir desde cero
            txtNAME.Clear();
            txtLASTNAME.Clear();
            txtADDRESS.Clear();
            txtCELLPHONE.Clear();
            txtEMAIL.Clear();
            txtCURP.Clear();

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            //Indicamos el archivo donde se escribiran y guardaran los datos
            streamw.ConexionStream("Client.txt", false);
            streamw.InstanciaWritter();
            //Iniciamos los hilos haciendo una instancia de los metodos que preparamos 
            First = new Thread(DBConect);
            Second = new Thread(WriteFile);
            First.Start();
            Second.Start();
            
        }
    }
}