using System;


namespace ProgIIIListas
{
    class Cadenas
    {
        public int buscar(String cadena, char t, int p)
        {
            int k = p;
            while (k < cadena.Length && cadena[k] != t)
                k++;
            return k;
        }

        public String cortar(String cadena, int pi, int pf)
        {
            String tmp = ""; int k;
            for (k = pi; k < cadena.Length && k < pf; k++)
                tmp = tmp + cadena[k];
            return tmp;
        }


        public String Capicua(String Cadena)
        {
            int k, t1, t2; bool band = true; String res = "";
            t1 = Convert.ToInt32(Cadena[Cadena.Length / 2]);
            if (t1 < 48 || t1 > 57)
                band = false;
            for (k = 0; k < Cadena.Length / 2 && band; k++)
            {
                t1 = Convert.ToInt32(Cadena[k]);
                t2 = Convert.ToInt32(Cadena[Cadena.Length - 1 - k]);
                if ((t1 < 48 || t1 > 57) || (t2 < 48 || t2 > 57) || (t1 != t2))
                    band = false;
            }
            if (band)
                res = "Si es Capicúa";
            else
                res = "No es Capicúa";
            return res;
        }

        public String Suprimir(String Cadena, char x)
        {
            int c; String Texto = "";
            for (c = 0; c < Cadena.Length; c++)
            {
                if (Cadena[c] != x)
                    Texto = Texto + Cadena[c];
            }
            return Texto;
        }

        public String Mayuscula(String Cadena)
        {
            String Cad = ""; int k, n; char tmp;
            for (k = 0; k < Cadena.Length; k++)
            {
                tmp = Cadena[k];
                if (tmp >= 97 && tmp <= 122)
                {
                    n = tmp;
                    n = n - 32;
                    tmp = Convert.ToChar(n);
                }
                Cad = Cad + tmp;
            }
            return Cad;
        }

        public String Insertar(String cad1, String cad2, int p)
        {
            String texto = ""; int c;
            if (p < 0)
                texto = cad2 + cad1;
            else
            {
                if (p > cad1.Length)
                    texto = cad1 + cad2;
                else
                {
                    for (c = 0; c < p; c++)
                        texto = texto + cad1[c];
                    for (c = 0; c < cad2.Length; c++)
                        texto = texto + cad2[c];
                    for (c = p; c < cad1.Length; c++)
                        texto = texto + cad1[c];
                }
            }
            return texto;
        }

        public System.Windows.Forms.DataGridView Ordenar(System.Windows.Forms.DataGridView dataGridView)
        {
            
            dataGridView.Sort(dataGridView.Columns["Cantidad"], System.ComponentModel.ListSortDirection.Descending); //Ordena de manera descendente por cantidad

            while (dataGridView.Rows.Count >= 7) //Los indices se usan asi porque el primer indice es cero y la ultima fila es vacia
            {
                dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 2); //Se borran filas ignorando la ultima (vacia) y se resta uno mas por el indice desde cero
            }
            return dataGridView;
        }
    }
}
