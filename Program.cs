using ConsoleApp1;
public class ConsolaImpuestos
{
    public static  void Main(String[]args)
    {
        Imp im = new Imp();
        double[] S; double[] P; double[] L;
        S = new double[10];
        P = new double[10];
        L = new double[10];
        int ind = 0; int ce;

        do
        {

            ce = im.Validar("Cantidad de elementos");

        }while (ce <= 0 || ce > 10);
        for (ind = 0; ind < ce; ind++)
        {
            do
            {


                S[ind] = im.Validar("Valor;");
                im.setIng(S);
            } while (S[ind]<4800 || S[ind]> 500000);
            P[ind] = S[ind] * 0.07;
            L[ind] = S[ind] * 0.22;
        }  

        for (ind = 0; ind < ce; ind++ )
        {
            
            Console.WriteLine("\t" + S[ind]);

        }
        for (ind = 0; ind < ce; ind++)
        {
            Console.WriteLine("\t" + P[ind]);

        }
        for (ind = 0; ind < ce; ind++)
        {
            Console.WriteLine("\t" +L[ind]);

        }

    }
}