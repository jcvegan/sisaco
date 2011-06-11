using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace BDA_SISACO
{
    public class BDABase
    {

        /// <summary>
        /// Se encarga de la validacion del valor a ingresar y si es nulo ingresa el nulo
        /// por default System.DBNull.Value
        /// </summary>
        /// <param name="param">Atributo al cual se le ingresara el valor</param>
        /// <param name="value">Dato que se validara</param>
        public void ValidateAndInsertValue(SqlParameter param, object value) {
            if (value != null) {
                switch (value.GetType().ToString()) {
                    case "System.String":
                        String s = (String)value;
                        param.Value = s;
                        break;

                    case "System.Int16":
                        Int16 i16 = (Int16)value;
                        param.Value = i16;
                        break;

                    case "System.Int32":
                        Int32 i32 = (Int32)value;
                        if (i32 != 0)
                            param.Value = i32;
                        else
                            param.Value = System.DBNull.Value;
                        break;

                    case "System.Int64":
                        Int64 i64 = (Int64)value;
                        param.Value = i64;
                        break;

                    case "System.Decimal":
                        Decimal d = (Decimal)value;
                        param.Value = d;
                        break;

                    case "System.Byte":
                        Byte by = (Byte)value;
                        param.Value = by;
                        break;

                    case "System.Boolean":
                        Boolean b = (Boolean)value;
                        param.Value = b;
                        break;

                    case "System.DateTime":
                        DateTime dt = (DateTime)value;
                        if (dt != DateTime.MinValue)
                            param.Value = dt;
                        else
                            param.Value = System.DBNull.Value;
                        break;

                    case "System.Double":
                        Double db = (Double)value;
                        param.Value = db;
                        break;

                    default:
                        param.Value = System.DBNull.Value;
                        break;
                }
            } else {
                param.Value = System.DBNull.Value;
            }
        }
        


        //Depreciado
        public object ValidateAndReturnValue(object value) {
            //string prueba = value.GetType().ToString();
            switch (value.GetType().ToString()) {
                case "System.String":
                    if (value != System.DBNull.Value) {
                        String s = (String)value;
                        return s;
                    } else
                        return String.Empty;

                case "System.Int16":
                    if (value != System.DBNull.Value) {
                        Int16 i = (Int16)value;
                        return i;
                    } else
                        return default(Int16);

                case "System.Int32":
                    if (value != System.DBNull.Value) {
                        Int32 i = (Int32)value;
                        return i;
                    } else
                        return default(Int32);

                case "System.Int64":
                    if (value != System.DBNull.Value) {
                        Int64 i = (Int64)value;
                        return i;
                    } else
                        return default(Int64);

                case "System.Decimal":
                    if (value != System.DBNull.Value) {
                        Decimal d = (Decimal)value;
                        return d;
                    } else
                        return Decimal.Zero;

                case "System.Byte":
                    if (value != System.DBNull.Value) {
                        Byte by = (Byte)value;
                        return by;
                    } else
                        return Byte.MinValue;

                case "System.Boolean":
                    if (value != System.DBNull.Value) {
                        Boolean b = (Boolean)value;
                        return b;
                    } else
                        return false;

                case "System.DateTime":
                    if (value != System.DBNull.Value) {
                        DateTime dt = (DateTime)value;
                        return dt;
                    } else
                        return DateTime.MinValue;

                case "System.Double":
                    if (value != System.DBNull.Value) {
                        Double d = (Double)value;
                        return d;
                    } else
                        return default(Double);
                //case "System.DBNull":
                //    return;
                    
                default:
                    return String.Empty;
            }
        }
    }
}

