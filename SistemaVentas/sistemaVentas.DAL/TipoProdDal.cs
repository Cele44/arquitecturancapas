﻿using sistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVentas.DAL
{
    public class TipoProdDal
    {
        public DataTable ListarTipoProdDal()
        {
            string consulta = " select * from tipoprod";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarTipoProdDal(TipoProd tipoprod)
        {
            string consulta = "insert into tipoprod values('" + tipoprod.Nombre + "' ," +
                                                          "'" + tipoprod.Estado + "')";
            conexion.Ejecutar(consulta);
        }
        public TipoProd ObtenerTipoProdId(int id)
        {
            string consulta = "select * from tipoprod where idtipoprod=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            TipoProd t = new TipoProd();
            if (tabla.Rows.Count > 0)
            {
                t.IdTipoProd = Convert.ToInt32(tabla.Rows[0]["idtipoprod"]);
                t.Nombre = tabla.Rows[0]["nombre"].ToString();
                t.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return t;

        }
        public void EditarTipoProdDal(TipoProd t)
        {
            string consulta = "update tipoprod set nombre='" + t.Nombre + "'," +
                                                 "estado='" + t.Estado + "' " +
                               "where idtipoprod=" + t.IdTipoProd;
            conexion.Ejecutar(consulta);
        }
        public void EliminarTipoProdDal(int id)
        {
            string consulta = "delete from tipoprod where idtipoprod=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
