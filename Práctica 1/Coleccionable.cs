using System;

namespace Práctica_1
{
	public interface Coleccionable
	{
		int Cuantos();
        Comparable minimo();
        Comparable maximo();
        void agregar (Comparable n);
        bool contiene(Comparable n);
	}
}
