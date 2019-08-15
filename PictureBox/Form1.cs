using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> _InputColor;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Variable de la ruta de la imagen
            string imagen = "C:\\Users\\alumno\\Desktop\\SAF-logo.jpg";
            _InputColor = new Image<Bgr, byte>(imagen);

            if(_InputColor == null){
                MessageBox.Show("Mo se cargó la imagen");
                return;

            }
            imageBox1.Image = _InputColor;
        }
    }
}
