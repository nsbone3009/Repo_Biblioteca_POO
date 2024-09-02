using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca_Poo
{
    internal class csUsuarios :csConexionSQL
    {
        private Random random = new Random(DateTime.Now.Millisecond);
        private string cedula; private string nombre; private string apellido; private string fecha;
        private string rol; private string estado; private string domicilio; private string usuario;
        private string contra; private string correo; private int id;private string CifraClave;
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contra { get => contra; set => contra = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Id { get => id; set => id = value; }
        public string CifraClave1 { get => CifraClave; set => CifraClave = value; }
        public csUsuarios() { }
        public csUsuarios(string cedula, string nombre, string apellido, string fecha, string rol, string estado, string domicilio, string correo, string usuario, string contra)
        {
         Cedula = cedula; Nombre = nombre; Apellido = apellido; Fecha = fecha; Rol = rol; Estado = estado;
         Domicilio = domicilio; Usuario = usuario; Contra = contra; Correo = correo;
        }
        public void AgregarUsuario()
        {
            Conexion.Open();
            string consulta = "insert into Usuarios(cedula_usr,nombres_usr,apellidos_usr,fecha_nacimiento_usr,direccion_domicilio_usr,correo_usr,rol_usr,estado_usr) values" +
                "('" + cedula + "','" + Nombre + "','" + Apellido + "','" + Fecha + "','" + Domicilio + "','" + Correo + "','" + Rol + "','" + Estado + "')";
            SqlCommand comando = new SqlCommand(consulta, Conexion);
            comando.ExecuteReader();
            Conexion.Close();
        }
        public void AgregarCredenciales()
        {
            Id = random.Next(1000, 99999);
            CifraClave1 = Encriptar(Contra);
            Conexion.Open();
            string consulta01 = "insert into Credenciales(id_crd,cedula_usr,usuario_crd,contraseña_crd) values('" + Id + "','" + Cedula + "','" + Usuario + "','" + CifraClave1 + "')";
            SqlCommand comando01 = new SqlCommand(consulta01, Conexion);
            comando01.ExecuteNonQuery();
            Conexion.Close();
        }
        public void EditarDatos()
        {
            Conexion.Open();
            string consulta = "update Usuarios set nombres_usr='"+Nombre+"',apellidos_usr='"+Apellido+"',fecha_nacimiento_usr='"+Fecha+"',direccion_domicilio_usr='"+Domicilio+"',correo_usr='"+Correo+"',rol_usr='"+Rol+"',estado_usr='"+Estado+"' where cedula_usr='"+Cedula+"'";
            SqlCommand comando = new SqlCommand(consulta,Conexion); comando.ExecuteNonQuery();
            Conexion.Close();
       


        }
        public string Encriptar(string clave)
        {
            string frase = "hola";
            byte[] data = UTF8Encoding.UTF8.GetBytes(clave);
            MD5 md5 = MD5.Create();
            TripleDES tripldes = TripleDES.Create();
            tripldes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(frase));
            tripldes.Mode = CipherMode.ECB;
            ICryptoTransform transform = tripldes.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            return Convert.ToBase64String(result);
        }
        public string Desencriptar(string claveEn)
        {
            string frase = "hola";
            byte[] data = Convert.FromBase64String(claveEn);
            MD5 md5 = MD5.Create();
            TripleDES tripldes = TripleDES.Create();
            tripldes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(frase));
            tripldes.Mode = CipherMode.ECB;
            ICryptoTransform transform = tripldes.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            return UTF8Encoding.UTF8.GetString(result);
        }
    }
}
