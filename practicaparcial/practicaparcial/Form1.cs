using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaparcial
{
    public partial class Form1 : Form
    {
        Empresa empresa = new Empresa();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            int codigo = Convert.ToInt32(tbCodigo.Text);

            if (rbFijo.Checked)
            {
                Mostrador fijo = new Mostrador(nombre, codigo);
                empresa.AgregarVendedor(fijo);
            }
            else
            {
                Temporal temp = new Temporal(nombre, codigo);
                empresa.AgregarVendedor(temp);
            }
            tbNombre.Clear();
            tbCodigo.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(tbBuscarCod.Text);
            MessageBox.Show("Sueldo = " + empresa.VerSueldo(c));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(file);
                //StreamReader sr = new StreamReader(openFileDialog.FileName);
                string lineas = sr.ReadToEnd();
                string[] lines = lineas.Split('\n');
                foreach (string l in lines)
                {
                    string[] renglon  = l.Split(';');
                    empresa.AgregarVenta(Convert.ToDouble(renglon[1]), Convert.ToInt32(renglon[0]));
                }
                /*string line = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] aux = line.Split(';');
                    //MessageBox.Show(line + " -- " + aux[0] + " | " + aux[1] );
                    empresa.AgregarVenta(Convert.ToDouble(aux[1]) , Convert.ToInt32(aux[0]));
                    line = sr.ReadLine();
                }*/
                sr.Close();
                file.Dispose();
            }
            openFileDialog.Dispose();
        }
    }
}
