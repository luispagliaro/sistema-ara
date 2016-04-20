using System;
using System.Collections;
using System.Windows.Forms;

/// <summary>
/// Esta clase es una implementación de las interfaz 'IComparer'.
/// </summary>
public class ListViewColumnSorter : IComparer
{
    /// <summary>
    /// Especifica tipo de columna a ser ordenada
    /// </summary>
    private string ColumnType;

    /// <summary>
    /// Especifica la columna a ser ordenada
    /// </summary>
    private int ColumnToSort;

    /// <summary>
    /// Especifica el ordenamiento en el cual ordenar (Ej. 'Ascendente').
    /// </summary>
    private SortOrder OrderOfSort;

    /// <summary>
    /// Objeto comparador de minúsculas
    /// </summary>
    private CaseInsensitiveComparer ObjectCompare;

    /// <summary>
    /// Constructor de la clase.  Inicializa varios elementos
    /// </summary>
    public ListViewColumnSorter()
    {
        //Inicializa el tipo de columna
        ColumnType = "";

        // Inicializa la columna en '0'
        ColumnToSort = 0;

        // Inicializa el ordenamiento en 'none' (ninguno)
        OrderOfSort = SortOrder.None;

        // Inicializa el objeto CaseInsensitiveComparer
        ObjectCompare = new CaseInsensitiveComparer();
    }

    /// <summary>
    /// Este método es heredado de la interfaz IComparer.
    /// Compara los dos objetos pasados utilizando una comparación en minúsculas.
    /// </summary>
    /// <param name="x">Primer objeto a ser comparado</param>
    /// <param name="y">Segundo objeto a ser comparado</param>
    /// <returns>Resultado de la comparación.
    /// "0" si es igual, negativo si 'x' es menor que 'y' y positivo si 'x' es mayor que 'y'</returns>
    public int Compare(object x, object y)
    {
        int compareResult;
        ListViewItem listviewX, listviewY;

        // Convierte los objetos a ser comparados a objetos ListViewItem
        listviewX = (ListViewItem)x;
        listviewY = (ListViewItem)y;

        try
        {
            // Compara los dos ítems

            if (Tipo != "Fecha")
            {
                compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
            }
            else
            {
                compareResult = ObjectCompare.Compare(Convert.ToDateTime(listviewX.SubItems[ColumnToSort].Text), Convert.ToDateTime(listviewY.SubItems[ColumnToSort].Text));
            }

            // Calcula el valor de retorno basado en la comparación de objeto
            if (OrderOfSort == SortOrder.Ascending)
            {
                // Orden ascendente seleccionado, devuelve el resultado normal de la operación de comparación
                return compareResult;
            }
            else if (OrderOfSort == SortOrder.Descending)
            {
                // Orden descendiente seleccionado, devuelve el resultado negativo de la operación de comparación
                return (-compareResult);
            }
            else
            {
                // Devuelve '0' para indicar que son iguales
                return 0;
            }
        }
        catch
        {

        }

        return 0;
    }

    /// <summary>
    /// Obtiene o establece el número de la columna a la cual aplicar la operación de ordenamiento ('0' por defecto).
    /// </summary>
    public int SortColumn
    {
        set
        {
            ColumnToSort = value;
        }
        get
        {
            return ColumnToSort;
        }
    }

    /// <summary>
    /// Obtiene o establece el tipo de ordenamiento a aplicar (Ej. 'Ascendente', 'Descendente').
    /// </summary>
    public SortOrder Order
    {
        set
        {
            OrderOfSort = value;
        }
        get
        {
            return OrderOfSort;
        }
    }

    public string Tipo
    {
        set
        {
            ColumnType = value;
        }
        get
        {
            return ColumnType;
        }
    }

}