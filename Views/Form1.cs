using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APIGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //tooltip pa mostrar en el btn de Buscar/Actualizar/Eliminar/Agregar se pa que hace el boton
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(buttonGEN, " Generar una imagen ");
        }
        // Método buttonGEN_Click()
        private async void buttonGEN_Click(object sender, EventArgs e)
        {
            // Crear una instancia de HttpClient para realizar solicitudes HTTP
            using (HttpClient client = new HttpClient())
            {
                // Enviar una solicitud GET a la URL  para obtener una imagen aleatoria
                HttpResponseMessage response = await client.GetAsync("https://source.unsplash.com/random");
                // Verificar si la solicitud fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    // Obtener la URL de la imagen directamente de la solicitud original
                    string imageUrl = response.RequestMessage.RequestUri.ToString();
                    // Descargar la imagen y mostrarla en el PictureBox
                    using (HttpClient imageClient = new HttpClient())
                    {
                        // Descargar la imagen utilizando otra instancia de HttpClient y convertirla en un arreglo de bytes
                        byte[] imageData = await imageClient.GetByteArrayAsync(imageUrl);            
                        // Crear un MemoryStream con los datos de la imagen
                        using (var ms = new System.IO.MemoryStream(imageData))
                        {
                            // Mostrar la imagen descargada en el control PictureBox del formulario
                            pictureBoxIMG.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
        }
    }
}
