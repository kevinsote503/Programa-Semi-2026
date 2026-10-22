using System;
using System.Data;
using System.Data.SqlClient;

namespace Parcial2_1
{
    class Conexion_base_datos
    {
        private const string CADENA_CONEXION =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_parcial2_1;Integrated Security=True";

        SqlConnection miConexion = new SqlConnection();
        SqlCommand miComando = new SqlCommand();
        SqlDataAdapter miAdaptador = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Conexion_base_datos()
        {
            miConexion.ConnectionString = CADENA_CONEXION;
            miComando.Connection = miConexion;
            verificarBaseDatos();
        }

        // Crea la base de datos y la tabla de usuarios si no existen, y asegura el usuario principal.
        private static void verificarBaseDatos()
        {
            const string MASTER =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";
            try
            {
                using (SqlConnection cn = new SqlConnection(MASTER))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "IF DB_ID('db_parcial2_1') IS NULL CREATE DATABASE db_parcial2_1", cn))
                        cmd.ExecuteNonQuery();
                }

                using (SqlConnection cn = new SqlConnection(CADENA_CONEXION))
                {
                    cn.Open();
                    string sql =
                        "IF OBJECT_ID('dbo.usuarios_ustr086626', 'U') IS NULL " +
                        "CREATE TABLE dbo.usuarios_ustr086626 (" +
                        "idUsuario INT IDENTITY(1,1) NOT NULL, " +
                        "usuario VARCHAR(35) NOT NULL, " +
                        "clave VARCHAR(35) NOT NULL, " +
                        "nombre VARCHAR(65) NOT NULL, " +
                        "direccion VARCHAR(85) NULL, " +
                        "telefono VARCHAR(9) NULL, " +
                        "CONSTRAINT PK_usuarios_ustr086626 PRIMARY KEY (idUsuario), " +
                        "CONSTRAINT UQ_usuarios_ustr086626_usuario UNIQUE (usuario)); " +
                        "IF OBJECT_ID('dbo.alumnos', 'U') IS NULL " +
                        "BEGIN " +
                        "CREATE TABLE dbo.alumnos (" +
                        "idAlumno INT IDENTITY(1,1) NOT NULL, " +
                        "codigo VARCHAR(10) NOT NULL, " +
                        "nombre VARCHAR(65) NOT NULL, " +
                        "direccion VARCHAR(85) NULL, " +
                        "telefono VARCHAR(9) NULL, " +
                        "CONSTRAINT PK_alumnos PRIMARY KEY (idAlumno), " +
                        "CONSTRAINT UQ_alumnos_codigo UNIQUE (codigo)); " +
                        "INSERT INTO dbo.alumnos (codigo, nombre, direccion, telefono) VALUES " +
                        "('AL2026001', 'José Manuel Rivas', 'Barrio La Merced, Usulután', '7123-4501'), " +
                        "('AL2026002', 'Daniela Beatriz Cruz', 'Colonia El Molino, Usulután', '7234-5612'), " +
                        "('AL2026003', 'Kevin Alexander Portillo', 'Santa María, Usulután', '7345-6723'), " +
                        "('AL2026004', 'Gabriela Abigail Mejía', 'Ozatlán, Usulután', '7456-7834'), " +
                        "('AL2026005', 'Luis Fernando Argueta', 'Jiquilisco, Usulután', '7567-8945'); " +
                        "END; " +
                        "IF OBJECT_ID('dbo.materias', 'U') IS NULL " +
                        "BEGIN " +
                        "CREATE TABLE dbo.materias (" +
                        "idMateria INT IDENTITY(1,1) NOT NULL, " +
                        "codigo INT NOT NULL, " +
                        "nombre VARCHAR(65) NOT NULL, " +
                        "uv INT NOT NULL, " +
                        "CONSTRAINT PK_materias PRIMARY KEY (idMateria), " +
                        "CONSTRAINT UQ_materias_codigo UNIQUE (codigo)); " +
                        "INSERT INTO dbo.materias (codigo, nombre, uv) VALUES " +
                        "(101, 'Programación Computacional I', 4), " +
                        "(102, 'Matemática I', 4), " +
                        "(103, 'Lógica Computacional', 3), " +
                        "(104, 'Inglés Técnico I', 3); " +
                        "END; " +
                        "IF OBJECT_ID('dbo.periodos', 'U') IS NULL " +
                        "BEGIN " +
                        "CREATE TABLE dbo.periodos (" +
                        "idPeriodo INT IDENTITY(1,1) NOT NULL, " +
                        "periodo VARCHAR(30) NOT NULL, " +
                        "fecha DATE NOT NULL, " +
                        "CONSTRAINT PK_periodos PRIMARY KEY (idPeriodo)); " +
                        "INSERT INTO dbo.periodos (periodo, fecha) VALUES " +
                        "('Ciclo I-2026', '2026-01-19'), " +
                        "('Ciclo II-2026', '2026-07-13'); " +
                        "END; " +
                        "IF OBJECT_ID('dbo.notas', 'U') IS NULL " +
                        "BEGIN " +
                        "CREATE TABLE dbo.notas (" +
                        "idNota INT IDENTITY(1,1) NOT NULL, " +
                        "idAlumno INT NOT NULL, " +
                        "idPeriodo INT NOT NULL, " +
                        "fecha DATE NOT NULL, " +
                        "CONSTRAINT PK_notas PRIMARY KEY (idNota), " +
                        "CONSTRAINT FK_notas_alumnos FOREIGN KEY (idAlumno) REFERENCES dbo.alumnos (idAlumno) ON DELETE CASCADE, " +
                        "CONSTRAINT FK_notas_periodos FOREIGN KEY (idPeriodo) REFERENCES dbo.periodos (idPeriodo)); " +
                        "INSERT INTO dbo.notas (idAlumno, idPeriodo, fecha) " +
                        "SELECT a.idAlumno, p.idPeriodo, p.fecha FROM dbo.alumnos a CROSS JOIN dbo.periodos p; " +
                        "END; " +
                        "IF OBJECT_ID('dbo.dnotas', 'U') IS NULL " +
                        "BEGIN " +
                        "CREATE TABLE dbo.dnotas (" +
                        "idDetalle INT IDENTITY(1,1) NOT NULL, " +
                        "idNota INT NOT NULL, " +
                        "idMateria INT NOT NULL, " +
                        "lab1 DECIMAL(4,2) NOT NULL DEFAULT 0, " +
                        "lab2 DECIMAL(4,2) NOT NULL DEFAULT 0, " +
                        "parcial DECIMAL(4,2) NOT NULL DEFAULT 0, " +
                        "CONSTRAINT PK_dnotas PRIMARY KEY (idDetalle), " +
                        "CONSTRAINT FK_dnotas_notas FOREIGN KEY (idNota) REFERENCES dbo.notas (idNota) ON DELETE CASCADE, " +
                        "CONSTRAINT FK_dnotas_materias FOREIGN KEY (idMateria) REFERENCES dbo.materias (idMateria) ON DELETE CASCADE); " +
                        "INSERT INTO dbo.dnotas (idNota, idMateria, lab1, lab2, parcial) " +
                        "SELECT n.idNota, m.idMateria, " +
                        "5 + ((n.idNota * 3 + m.idMateria * 7) % 50) / 10.0, " +
                        "5 + ((n.idNota * 7 + m.idMateria * 3) % 50) / 10.0, " +
                        "5 + ((n.idNota * 11 + m.idMateria * 5) % 50) / 10.0 " +
                        "FROM dbo.notas n CROSS JOIN dbo.materias m; " +
                        "END;";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                        cmd.ExecuteNonQuery();

                    string[][] usuarios =
                    {
                        new[] { "ustr086626", "mined2002", "Kevin Alexander Amaya Bermúdez", "Usulután, El Salvador", "7777-8888" },
                        new[] { "dmelendez",  "Melendez26", "Diana Carolina Meléndez",        "Barrio La Parroquia, Usulután",  "7614-8820" },
                        new[] { "rzelaya09",  "Zelaya2026", "Roberto Alejandro Zelaya",       "Puerto El Triunfo, Usulután",    "7932-4410" }
                    };
                    string upsert =
                        "IF EXISTS (SELECT 1 FROM dbo.usuarios_ustr086626 WHERE usuario = @usuario) " +
                        "UPDATE dbo.usuarios_ustr086626 SET clave = @clave, nombre = @nombre, " +
                        "direccion = @direccion, telefono = @telefono WHERE usuario = @usuario " +
                        "ELSE INSERT INTO dbo.usuarios_ustr086626 (usuario, clave, nombre, direccion, telefono) " +
                        "VALUES (@usuario, @clave, @nombre, @direccion, @telefono)";
                    foreach (string[] u in usuarios)
                    {
                        using (SqlCommand cmd = new SqlCommand(upsert, cn))
                        {
                            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 35).Value = u[0];
                            cmd.Parameters.Add("@clave", SqlDbType.VarChar, 35).Value = u[1];
                            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 65).Value = u[2];
                            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 85).Value = u[3];
                            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 9).Value = u[4];
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Si LocalDB no está disponible, los errores se reportan al usar la conexión.
            }
        }

        public DataSet crearDs()
        {
            ds.Clear();
            miComando.Parameters.Clear();
            miAdaptador.SelectCommand = miComando;

            miComando.CommandText = "SELECT idUsuario, usuario, clave, nombre, direccion, telefono FROM usuarios_ustr086626 ORDER BY idUsuario";
            miAdaptador.Fill(ds, "usuarios");

            miComando.CommandText = "SELECT idAlumno, codigo, nombre, direccion, telefono FROM alumnos ORDER BY idAlumno";
            miAdaptador.Fill(ds, "alumnos");

            miComando.CommandText = "SELECT idMateria, codigo, nombre, uv FROM materias ORDER BY idMateria";
            miAdaptador.Fill(ds, "materias");

            miComando.CommandText = "SELECT idPeriodo, periodo, fecha FROM periodos ORDER BY fecha";
            miAdaptador.Fill(ds, "periodos");

            return ds;
        }

        public string mantenimiento_usuarios_ustr086626(string[] datos, string accion)
        {
            string sql = "";
            if (accion == "nuevo")
                sql = "INSERT INTO usuarios_ustr086626 (usuario, clave, nombre, direccion, telefono) " +
                      "VALUES (@usuario, @clave, @nombre, @direccion, @telefono)";
            else if (accion == "modificar")
                sql = "UPDATE usuarios_ustr086626 SET usuario = @usuario, clave = @clave, nombre = @nombre, " +
                      "direccion = @direccion, telefono = @telefono WHERE idUsuario = @idUsuario";
            else if (accion == "eliminar")
                sql = "DELETE FROM usuarios_ustr086626 WHERE idUsuario = @idUsuario";
            else
                return "Accion no reconocida: " + accion;

            SqlParameter[] parametros =
            {
                new SqlParameter("@idUsuario", SqlDbType.Int)         { Value = aEntero(datos[0]) },
                new SqlParameter("@usuario",   SqlDbType.VarChar, 35) { Value = datos[1] },
                new SqlParameter("@clave",     SqlDbType.VarChar, 35) { Value = datos[2] },
                new SqlParameter("@nombre",    SqlDbType.VarChar, 65) { Value = datos[3] },
                new SqlParameter("@direccion", SqlDbType.VarChar, 85) { Value = datos[4] },
                new SqlParameter("@telefono",  SqlDbType.VarChar, 9)  { Value = datos[5] }
            };
            return procesar(sql, parametros);
        }

        public string administrarDatosAlumnos(string[] datos, string accion)
        {
            string sql = "";
            if (accion == "nuevo")
                sql = "INSERT INTO alumnos (codigo, nombre, direccion, telefono) VALUES (@codigo, @nombre, @direccion, @telefono)";
            else if (accion == "modificar")
                sql = "UPDATE alumnos SET codigo = @codigo, nombre = @nombre, direccion = @direccion, telefono = @telefono WHERE idAlumno = @id";
            else if (accion == "eliminar")
                sql = "DELETE FROM alumnos WHERE idAlumno = @id";

            SqlParameter[] parametros =
            {
                new SqlParameter("@id",        SqlDbType.Int)         { Value = aEntero(datos[0]) },
                new SqlParameter("@codigo",    SqlDbType.VarChar, 10) { Value = datos[1] },
                new SqlParameter("@nombre",    SqlDbType.VarChar, 65) { Value = datos[2] },
                new SqlParameter("@direccion", SqlDbType.VarChar, 85) { Value = datos[3] },
                new SqlParameter("@telefono",  SqlDbType.VarChar, 9)  { Value = datos[4] }
            };
            return procesar(sql, parametros);
        }

        public string administrarDatosMaterias(string[] datos, string accion)
        {
            string sql = "";
            if (accion == "nuevo")
                sql = "INSERT INTO materias (codigo, nombre, uv) VALUES (@codigo, @nombre, @uv)";
            else if (accion == "modificar")
                sql = "UPDATE materias SET codigo = @codigo, nombre = @nombre, uv = @uv WHERE idMateria = @id";
            else if (accion == "eliminar")
                sql = "DELETE FROM materias WHERE idMateria = @id";

            SqlParameter[] parametros =
            {
                new SqlParameter("@id",     SqlDbType.Int)         { Value = aEntero(datos[0]) },
                new SqlParameter("@codigo", SqlDbType.Int)         { Value = aEntero(datos[1]) },
                new SqlParameter("@nombre", SqlDbType.VarChar, 65) { Value = datos[2] },
                new SqlParameter("@uv",     SqlDbType.Int)         { Value = aEntero(datos[3]) }
            };
            return procesar(sql, parametros);
        }

        public string guardarPeriodos(DataTable periodos)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.InsertCommand = new SqlCommand("INSERT INTO periodos (periodo, fecha) VALUES (@periodo, @fecha)", miConexion);
            adaptador.InsertCommand.Parameters.Add("@periodo", SqlDbType.VarChar, 30, "periodo");
            adaptador.InsertCommand.Parameters.Add("@fecha", SqlDbType.Date, 0, "fecha");

            adaptador.UpdateCommand = new SqlCommand("UPDATE periodos SET periodo = @periodo, fecha = @fecha WHERE idPeriodo = @idPeriodo", miConexion);
            adaptador.UpdateCommand.Parameters.Add("@periodo", SqlDbType.VarChar, 30, "periodo");
            adaptador.UpdateCommand.Parameters.Add("@fecha", SqlDbType.Date, 0, "fecha");
            adaptador.UpdateCommand.Parameters.Add("@idPeriodo", SqlDbType.Int, 0, "idPeriodo");

            adaptador.DeleteCommand = new SqlCommand("DELETE FROM periodos WHERE idPeriodo = @idPeriodo", miConexion);
            SqlParameter pId = adaptador.DeleteCommand.Parameters.Add("@idPeriodo", SqlDbType.Int, 0, "idPeriodo");
            pId.SourceVersion = DataRowVersion.Original;

            try
            {
                adaptador.Update(periodos);
                return "1";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    return "No se puede eliminar un período que ya tiene notas registradas.";
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable obtenerNotas(int idMateria, int idPeriodo)
        {
            DataTable notas = new DataTable("notasAlumnos");
            miComando.Parameters.Clear();
            miComando.CommandText =
                "SELECT alumnos.nombre, dnotas.idDetalle, dnotas.idNota, dnotas.idMateria, " +
                "dnotas.lab1, dnotas.lab2, dnotas.parcial, " +
                "CAST(dnotas.lab1 * 0.3 + dnotas.lab2 * 0.3 + dnotas.parcial * 0.4 AS DECIMAL(5,2)) AS nf " +
                "FROM dnotas " +
                "INNER JOIN notas ON notas.idNota = dnotas.idNota " +
                "INNER JOIN alumnos ON alumnos.idAlumno = notas.idAlumno " +
                "WHERE notas.idPeriodo = @idPeriodo AND dnotas.idMateria = @idMateria " +
                "ORDER BY alumnos.nombre";
            miComando.Parameters.Add("@idPeriodo", SqlDbType.Int).Value = idPeriodo;
            miComando.Parameters.Add("@idMateria", SqlDbType.Int).Value = idMateria;
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(notas);
            miComando.Parameters.Clear();
            return notas;
        }

        public string actualizarNota(int idDetalle, decimal lab1, decimal lab2, decimal parcial)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@lab1", SqlDbType.Decimal)    { Value = lab1, Precision = 4, Scale = 2 },
                new SqlParameter("@lab2", SqlDbType.Decimal)    { Value = lab2, Precision = 4, Scale = 2 },
                new SqlParameter("@parcial", SqlDbType.Decimal) { Value = parcial, Precision = 4, Scale = 2 },
                new SqlParameter("@idDetalle", SqlDbType.Int)   { Value = idDetalle }
            };
            return procesar("UPDATE dnotas SET lab1 = @lab1, lab2 = @lab2, parcial = @parcial WHERE idDetalle = @idDetalle", parametros);
        }

        public string procesar(string sql, SqlParameter[] parametros)
        {
            try
            {
                miComando.CommandText = sql;
                miComando.Parameters.Clear();
                miComando.Parameters.AddRange(parametros);
                miConexion.Open();
                return miComando.ExecuteNonQuery().ToString();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return "Ya existe un registro con ese código o nombre de usuario.";
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                miComando.Parameters.Clear();
                if (miConexion.State == ConnectionState.Open) miConexion.Close();
            }
        }

        public bool validarUsuario(string usuario, string clave)
        {
            try
            {
                miComando.CommandText =
                    "SELECT COUNT(*) FROM usuarios_ustr086626 " +
                    "WHERE usuario = @usuario AND clave = @clave COLLATE Latin1_General_CS_AS";
                miComando.Parameters.Clear();
                miComando.Parameters.Add("@usuario", SqlDbType.VarChar, 35).Value = usuario;
                miComando.Parameters.Add("@clave", SqlDbType.VarChar, 35).Value = clave;
                miConexion.Open();
                return Convert.ToInt32(miComando.ExecuteScalar()) > 0;
            }
            finally
            {
                miComando.Parameters.Clear();
                if (miConexion.State == ConnectionState.Open) miConexion.Close();
            }
        }

        private static int aEntero(string texto)
        {
            int numero;
            return int.TryParse(texto, out numero) ? numero : 0;
        }
    }
}
