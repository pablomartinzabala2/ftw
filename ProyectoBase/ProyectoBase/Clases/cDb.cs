﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace ProyectoBase.Clases
{
    public static class cDb
    {
        public static void ExecutarNonQuery(string sql)
        {
            SqlHelper.ExecuteNonQuery(cConexion.Cadenacon(), CommandType.Text, sql);
        }

        public static DataTable ExecuteDataTable(string sql)
        {
            return SqlHelper.ExecuteDataset(cConexion.Cadenacon(), CommandType.Text, sql).Tables[0];
        }

        public static string ExecuteScalar(string sql, string Campo)
        {
            string Dato = "";
            DataTable trdo = SqlHelper.ExecuteDataset(cConexion.Cadenacon(), CommandType.Text, sql).Tables[0];
            if (trdo.Rows.Count > 0)
            {
                Dato = trdo.Rows[0][Campo].ToString();
            }
            return Dato;
        }

        public static void EjecutarNonQueryTransaccion(SqlConnection con, SqlTransaction Transaccion, string Sql)
        {
            SqlCommand comand = new SqlCommand();
            comand.Connection = con;
            comand.Transaction = Transaccion;
            comand.CommandText = Sql;
            comand.ExecuteNonQuery();
        }

        public static Int32 EjecutarEscalarTransaccion(SqlConnection con, SqlTransaction Transaccion, string Sql)
        {
            Sql = Sql + "select SCOPE_IDENTITY()";
            SqlCommand comand = new SqlCommand();
            comand.Connection = con;
            comand.Transaction = Transaccion;
            comand.CommandText = Sql;
            return Convert.ToInt32(comand.ExecuteScalar());
        }

        public static Int32 EjecutarEscalar(string Sql)
        {
            Sql = Sql + "select SCOPE_IDENTITY()";
            return Convert.ToInt32(SqlHelper.ExecuteScalar(cConexion.Cadenacon(), CommandType.Text, Sql));
        }
    }
}
