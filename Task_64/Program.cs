 Console.Write("Введите число M: ");
                  int M = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите число N: ");
                 int N = Convert.ToInt32(Console.ReadLine());
                    Console.Write(RecursMetod(M,N));

static int RecursMetod(int M, int N)
        {
            if (M < N)
            {
                Console.Write(M + ", ");
                M++;
                RecursMetod(M, N);
            }
            return N;
        }