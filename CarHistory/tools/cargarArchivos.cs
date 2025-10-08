using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHistory.tools
{
    public class cargarArchivos
    {
        internal static string filtroExcel = "Excel antiguo (.xlsx)|*.xlsx|Excel (*.xlsx)|*.xlsx";
        internal static string filtroTxt = "Archivo de texto (.txt)|*.txt";
        internal static string filtroJpg = "Archivo JPG (.jpg)|*.jpg";
        internal static string SolicitarArchivo(string filtro)
        {
            string resultado = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filtro;
            openFileDialog.FilterIndex = 1;
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                resultado = openFileDialog.FileName;
            }
            return resultado;
        }
    }
}
