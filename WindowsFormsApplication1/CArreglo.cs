using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class CArreglo
    {
        private Array arr_Alumno = Array.CreateInstance(typeof(CAlumno), 100);
        private int indice = 0;
        public void Insertar(CAlumno obj)
        {
            arr_Alumno.SetValue(obj, indice);
            indice++;

        }
        public int Contar_por_carrera(string carrera)
        {
            int contador = 0;
            foreach (CAlumno elemento in arr_Alumno)
                if (elemento != null)
                    if (elemento.CarreraProfesional == carrera)
                        contador++;
            return contador;
        }
        public CAlumno Buscar_por_codigo(int codigo)
        {
            //delvuelve el objeto
            CAlumno resultado = Array.Find((CAlumno[])arr_Alumno, delegate (CAlumno value) 
            {
                if (value != null)
                    return value.Codigo == codigo;
                else
                    return false;

            });
            return resultado;
        }





    }
}
