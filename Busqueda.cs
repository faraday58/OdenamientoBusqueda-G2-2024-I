using System;
using System.Runtime.InteropServices;

namespace OdenamientoBusqueda_G2_2024_I
{
    internal class Busqueda
    {
        internal static int Lineal(int[] A, int X )
        {
            for(int i =0; i < A.Length; i++)
            {
                if (A[i] == X)
                {
                    return i;
                }

            }

            return -1;

        }


        internal static int Binaria(int[] A, int IZQ, int DER, int X)
        {
            if (IZQ == DER   )
            {
                return -1;
            }
            else
            {
                int CEN = (IZQ + DER) / 2;

                if ( A[CEN] == X    )
                {
                    return CEN;
                }
                else if (X < A[CEN] )
                {
                    return Binaria(A, IZQ, CEN, X);
                }
                else
                {
                    return Binaria(A, CEN, DER, X);
                }


            }




        }

    }
}
