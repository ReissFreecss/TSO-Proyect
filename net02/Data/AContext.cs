using Microsoft.SqlServer.Server;
using net02.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net02.Data
{
    internal class AContext
    {
        private readonly static string sCn = "Data Source=WICHOLIK\\SQLEXPRESS;Initial Catalog=curp_xa_2023;" +
            "Persist Security Info=True;User ID=sa;Password=toonlinkike;" +
            "Encrypt=False;TrustServerCertificate=True";

        private readonly static string[] Consultas = {

            "EXEC sp_Bitacora '{0}','{1}';",
            "EXEC sp_Login '{0}','{1}';",
            "EXEC sp_Logout '{0}';",
            "EXEC sp_insertaAlumno '{0}','{1}',{2},'{3}';"
            };

        private readonly static int execBitacora = 0;
        private readonly static int loginUser = 1;
        private readonly static int logoutUser = 2;
        private readonly static int insertAlumno = 3;

        public static void insertaAlumno(string NC, string Nombre, string C, string U)
        {
            noQuery(construyeQuery(insertAlumno, NC, Nombre, C, U));
        }

        public static void borraAlumno(string NC)
        {
            noQuery($"UPDATE Alumnos SET Borrado=1 WHERE NC={NC}");
        }

        public static void logoutUsuario(string U)
        {
            noQuery(construyeQuery(logoutUser, U));
        }
        public static void insertaBitacora(string U, string A)
        {
            noQuery(construyeQuery(execBitacora, U, A));
        }

        private static string construyeQuery(int n, params string[] args)
        {
            string aux = Consultas[n];
            for (int i = 0; i < args.Length; i++)
            {
                aux = aux.Replace("{" + i + "}", args[i]);
            }
            return aux;
        }

        private static void noQuery(string Q)
        {
            SqlConnection con = new SqlConnection(sCn);
            SqlCommand cmd = new SqlCommand(Q, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static UsuariosModel Login(string U, string C)
        {
            return loginUsuario(U, C);
        }

        private static UsuariosModel loginUsuario(string U, string C)
        {
            UsuariosModel usuario = new UsuariosModel();
            SqlConnection con = new SqlConnection(sCn);
            SqlCommand cmd = new SqlCommand(construyeQuery(loginUser, U, C), con);
            con.Open();
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {

                usuario.Usuario = r.GetString(0);
                usuario.Nombre = r.GetString(1);
                usuario.Tipo = r.GetInt32(2);
            }
            con.Close();
            return usuario;
        }
    }

}
