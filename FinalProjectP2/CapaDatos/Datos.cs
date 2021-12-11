using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class Datos
    {
        public static string Value, Display;
        public static string Value2, Display2;
        string[] array = new string[18]; 

        private static string StringConnectionSQLServer=    "Server = DESKTOP-3B0O51K\\MYSERVER;DataBase=SellPoint;Integrated Security = true"; //ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ToString();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        SqlConnection conexion = new SqlConnection(StringConnectionSQLServer);
        public SqlConnection OpenBD()
        {

            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public SqlConnection CloseBD()
        {

            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }

        //TODOS LOS INSERT SE ENCUENTRAN AQUI

        public void InsertarEntidades(string Descripcion, string Direccion, string Localidad, string TipoEntidad, string TipoDocumento, long NumeroDocumento, string Telefonos, string URLPaginaWeb, string  URLFacebook, string URLInstagram, string URLTwitter, string URLTikTok, int IdGrupoEntidad, int IdTipoEntidad, int LimiteCredito, string UserNameEntidad, string PassworEntidad, string  RolUserEntidad, string Comentario, string Estatus, int NoEliminable, DateTime FechaRegistro)
        {
            comando.Connection = OpenBD();
            comando.CommandText = "SpEntidadesInsertar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Descripcion",Descripcion);
            comando.Parameters.AddWithValue("@Direccion",Direccion);
            comando.Parameters.AddWithValue("@Localidad",Localidad);
            comando.Parameters.AddWithValue("@TipoEntidad",TipoEntidad);
            comando.Parameters.AddWithValue("@TipoDocumento",TipoDocumento);
            comando.Parameters.AddWithValue("@NumeroDocumento",NumeroDocumento);
            comando.Parameters.AddWithValue("@Telefonos",Telefonos);
            comando.Parameters.AddWithValue("@URLPaginaWeb",URLPaginaWeb);
            comando.Parameters.AddWithValue("@URLFacebook",URLFacebook);
            comando.Parameters.AddWithValue("@URLInstagram",URLInstagram);
            comando.Parameters.AddWithValue("@URLTwitter",URLTwitter);
            comando.Parameters.AddWithValue("@URLTikTok",URLTikTok);
            comando.Parameters.AddWithValue("@IdGrupoEntidad",IdGrupoEntidad);
            comando.Parameters.AddWithValue("@IdTipoEntidad",IdTipoEntidad );
            comando.Parameters.AddWithValue("@LimiteCredito",LimiteCredito );
            comando.Parameters.AddWithValue("@UserNameEntidad",UserNameEntidad);
            comando.Parameters.AddWithValue("@PassworEntidad",PassworEntidad);
            comando.Parameters.AddWithValue("@RolUserEntidad",RolUserEntidad);
            comando.Parameters.AddWithValue("@Comentario",Comentario);
            comando.Parameters.AddWithValue("@Estatus",Estatus);
            comando.Parameters.AddWithValue("@NoEliminable",NoEliminable);
            comando.Parameters.AddWithValue("@FechaRegistro", FechaRegistro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CloseBD();

        }

        public void InsertarGruposEntidades(string Descripcion, string Comentario, string Estatus, int NoEliminable, string FechaRegistro)
        {
            comando.Connection = OpenBD();
            comando.CommandText = "SpGruposEntidadesInsertar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Comentario", Comentario);
            comando.Parameters.AddWithValue("@Estatus", Estatus);
            comando.Parameters.AddWithValue("@NoEliminable", NoEliminable);
            comando.Parameters.AddWithValue("@FechaRegistro", FechaRegistro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CloseBD();
        }


        public void InsertarTiposEntidades(string Descripcion, int IdGrupoEntidad,string Comentario, string Estatus, int NoEliminable, DateTime FechaRegistro)
        {
            comando.Connection = OpenBD();
            comando.CommandText = "SpTiposEntidadesInsertar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@IdGrupoEntidad", IdGrupoEntidad);
            comando.Parameters.AddWithValue("@Comentario", Comentario);
            comando.Parameters.AddWithValue("@Estatus", Estatus);
            comando.Parameters.AddWithValue("@NoEliminable", NoEliminable);
            comando.Parameters.AddWithValue("@FechaRegistro", FechaRegistro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CloseBD();
        }


        //UPDATES

        public void UpdateEntidades(int IdEntidad, string Descripcion, string Direccion, string Localidad, string TipoEntidad, string TipoDocumento, long NumeroDocumento, string Telefonos, string URLPaginaWeb, string URLFacebook, string URLInstagram, string URLTwitter, string URLTikTok, int IdGrupoEntidad, int IdTipoEntidad, int LimiteCredito, string UserNameEntidad, string PassworEntidad, string RolUserEntidad, string Comentario, string Estatus, int NoEliminable, DateTime FechaRegistro)
        {
            comando.Connection = OpenBD();
            comando.CommandText = "SpEntidadesActualizar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdEntidad",IdEntidad);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Localidad", Localidad);
            comando.Parameters.AddWithValue("@TipoEntidad", TipoEntidad);
            comando.Parameters.AddWithValue("@TipoDocumento", TipoDocumento);
            comando.Parameters.AddWithValue("@NumeroDocumento", NumeroDocumento);
            comando.Parameters.AddWithValue("@Telefonos", Telefonos);
            comando.Parameters.AddWithValue("@URLPaginaWeb", URLPaginaWeb);
            comando.Parameters.AddWithValue("@URLFacebook", URLFacebook);
            comando.Parameters.AddWithValue("@URLInstagram", URLInstagram);
            comando.Parameters.AddWithValue("@URLTwitter", URLTwitter);
            comando.Parameters.AddWithValue("@URLTikTok", URLTikTok);
            comando.Parameters.AddWithValue("@IdGrupoEntidad", IdGrupoEntidad);
            comando.Parameters.AddWithValue("@IdTipoEntidad", IdTipoEntidad);
            comando.Parameters.AddWithValue("@LimiteCredito", LimiteCredito);
            comando.Parameters.AddWithValue("@UserNameEntidad", UserNameEntidad);
            comando.Parameters.AddWithValue("@PassworEntidad", PassworEntidad);
            comando.Parameters.AddWithValue("@RolUserEntidad", RolUserEntidad);
            comando.Parameters.AddWithValue("@Comentario", Comentario);
            comando.Parameters.AddWithValue("@Estatus", Estatus);
            comando.Parameters.AddWithValue("@NoEliminable", NoEliminable);
            comando.Parameters.AddWithValue("@FechaRegistro", FechaRegistro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CloseBD();

        }

        public void UpdateGruposEntidades(int IdGrupoEntidad, string Descripcion, string Comentario, string Estatus, int NoEliminable, string FechaRegistro)
        {
            comando.Connection = OpenBD();
            comando.CommandText = "SpGruposEntidadesActualizar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdGrupoEntidad", IdGrupoEntidad);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Comentario", Comentario);
            comando.Parameters.AddWithValue("@Estatus", Estatus);
            comando.Parameters.AddWithValue("@NoEliminable", NoEliminable);
            comando.Parameters.AddWithValue("@FechaRegistro", FechaRegistro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CloseBD();
        }


        public void UpdateTiposEntidades(int IdTipoEntidad,string Descripcion, int IdGrupoEntidad, string Comentario, string Estatus, int NoEliminable, DateTime FechaRegistro)
        {
            comando.Connection = OpenBD();
            comando.CommandText = "SpTiposEntidadesActualizar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdTipoEntidad", IdTipoEntidad);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@IdGrupoEntidad", IdGrupoEntidad);
            comando.Parameters.AddWithValue("@Comentario", Comentario);
            comando.Parameters.AddWithValue("@Estatus", Estatus);
            comando.Parameters.AddWithValue("@NoEliminable", NoEliminable);
            comando.Parameters.AddWithValue("@FechaRegistro", FechaRegistro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CloseBD();
        }

        //ELIMINAR

        public void EliminarEntidades(int IdEntidad)
        {
            comando.Connection = OpenBD();
            comando.CommandText = "SpEntidadesEliminar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdEntidad", IdEntidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CloseBD();
        }

        public void EliminarGruposEntidades(int IdGrupoEntidad)
        {
            comando.Connection = OpenBD();
            comando.CommandText = "SpGruposEntidadesEliminar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdGrupoEntidad", IdGrupoEntidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CloseBD();
        }

        public void EliminarTiposEntidades(int IdTipoEntidad)
        {
            comando.Connection = OpenBD();
            comando.CommandText = "SpTiposEntidadesEliminar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdTipoEntidad", IdTipoEntidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CloseBD();
        }

        //LISTAR

        public DataTable ListarTiposEntidades()
        {

            comando.Connection = OpenBD();
            comando.CommandText = "SpTiposEntidadesListar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CloseBD();
            return tabla;

        }

        public DataTable ListarGrupoEntidades()
        {

            comando.Connection = OpenBD();
            comando.CommandText = "SpGruposEntidadesListar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CloseBD();
            return tabla;

        }

        public DataTable ListarEntidades()
        {

            comando.Connection = OpenBD();
            comando.CommandText = "SpEntidadesListar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            CloseBD();
            return tabla;

        }

        //OBTENER

        public DataTable BuscarTiposEntidades(int IdTipoEntidad)
        {

            comando.Connection = OpenBD();
            comando.CommandText = "SpTiposEntidadesObtener";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdTipoEntidad", IdTipoEntidad);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            comando.Parameters.Clear();
            CloseBD();
            return tabla;

        }

        public DataTable BuscarGruposEntidades(int IdGrupoEntidad)
        {

            comando.Connection = OpenBD();
            comando.CommandText = "SpGruposEntidadesObtener";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdGrupoEntidad", IdGrupoEntidad);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            leer.Close();
            CloseBD();
            return tabla;

        }

        public DataTable BuscarEntidades(int IdEntidad)
        {

            comando.Connection = OpenBD();
            comando.CommandText = "SpEntidadesObtener";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdEntidad", IdEntidad);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            leer.Close();
            CloseBD();
            return tabla;

        }

        public DataTable cargarComboBox2(int IdGrupoEntidad)
        {

            comando.Connection = OpenBD();
            comando.CommandText = "cargarTiposEntidades";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdGrupoEntidad", IdGrupoEntidad);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CloseBD();
            leer.Close();
            comando.Parameters.Clear();
            Value2 = "IdTipoEntidad";
            Display2 =  "Descripcion";
            return tabla;

        }

        public DataTable cargarComboBox()
        {
            comando.Connection = OpenBD();
            comando.CommandText = "cargarGruposEntidades";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CloseBD();
            leer.Close();
            Value = "IdGrupoEntidad";
            Display =  "Descripcion";
            return tabla;
        }
    }
}
