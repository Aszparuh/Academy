using System;
using System.Linq;

namespace Swaping
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }

            var swapnumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //ReverseArray(0, 2, arr);
            //ReverseArray(3, arr.Length - 3, arr);
            //ReverseArray(0, arr.Length, arr);

            for (int i = 0; i < swapnumbers.Length; i++)
            {
                var num = swapnumbers[i];
                var indexOfNum = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == num)
                    {
                        indexOfNum = j;
                        break;
                    }
                }

                ReverseArray(0, indexOfNum, arr);
                var lenght = arr.Length;
                lenght = lenght - indexOfNum - 1;
                ReverseArray(indexOfNum + 1, lenght, arr);
                ReverseArray(0, arr.Length, arr);
            }

            Console.WriteLine(string.Join(" ", arr));

        }

        static void ReverseArray(int index, int lenght, int[] arr)
        {
            Array.Reverse(arr, index, lenght);
        }
    }
}



//        static int Gcd(int i, int j)
//        {
//            if (i == 0)
//            {
//                return j;
//            }

//            if (j == 0)
//            {
//                return i;
//            }

//            while (i != j)
//            {
//                if (i > j)
//                {
//                    i -= j;
//                }
//                else
//                {
//                    j -= i;
//                }
//            }

//            return i;
//        }

//        static void BlockExchange(int[] arr, int l, int m, int r)
//        {
//            int u_lenght = m - l + 1;
//            int v_lenght = r - m;
//            if (u_lenght <= 0 || v_lenght <= 0)
//            {
//                return;
//            }

//            int rotationDistance = m - l + 1;
//            int n = r - l + 1;
//            int gdcRotDistance = Gcd(rotationDistance, n);

//            for (int i = 0; i < gdcRotDistance; i++)
//            {
//                int t = arr[i];
//                int j = i;

//                while (true)
//                {
//                    int k = j + rotationDistance;

//                    if (k >= n)
//                    {
//                        k -= n;
//                    }

//                    if (k == i)
//                    {
//                        break;
//                    }

//                    arr[j] = arr[k];
//                    j = k;
//                }

//                arr[j] = t; 
//            }
//        }
//    }
//}

/*
 * // Juggling algorithm for block swapping.
// Greatest Common Divisor.  Assumes that neither input is zero
inline int gcd( int i, int j )
{
	if ( i == 0 ) return j;
	if ( j == 0 ) return i;
	while ( i != j )
	{
		if ( i > j )	i -= j;
		else		j -= i;
	}
	return i;
}

template< class _Type >
inline void block_exchange_juggling_Bentley( _Type* a, int l, int m, int r )
{
	int u_length = m - l + 1;
	int v_length = r - m;
	if ( u_length <= 0 || v_length <= 0 )	return;
	int rotdist = m - l + 1;
	int n       = r - l + 1;
	int gcd_rotdist_n = gcd( rotdist, n );
	for( int i = 0; i < gcd_rotdist_n; i++ )
	{
		// move i-th values of blocks
		_Type t = a[ i ];
		int j = i;
		while( true ) {
			int k = j + rotdist;
			if ( k >= n )
				k -= n;
			if ( k == i )  break;
			a[ j ] = a[ k ];
			j = k;
		}
		a[ j ] = t;
	}
}
 */
