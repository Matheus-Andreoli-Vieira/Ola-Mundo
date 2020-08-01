package matheusa_2y_10.pkg20;
import java.util.Scanner;
import java.util.Random;
public class MatheusA_2Y_1020 
{
    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        Random rand = new Random();
        int A[] = new int [5], B[] = new int [5], r, i, comp[] = new int [5], j;
        for(i=0;i<A.length;i++)
        {
            r = rand.nextInt(20)+10;
            A[i] = r;
            while(r<10 || r>20)
            {
                r = rand.nextInt(20)+10;
                A[i] = r;
            }
        }
        for(i=0;i<B.length;i++)
        {
            System.out.println("Digite um número de 10-20.");
            B[i] = sc.nextInt();
            while(B[i]<10 || B[i]>20)
            {
                System.out.println("Número Inválido!!!\nDigite um número entre 10 e 20.");
                B[i] = sc.nextInt();
            }
        }
        System.out.println("    A   B");
        for(i=0;i<A.length;i++)
        {
            System.out.println("{"+i+"}"+"{"+A[i]+"}"+"{"+B[i]+"}");
        }
        
        for(i=0;i<A.length;i++)
        {
            for(j=0;j<A.length;j++)
            {
                if(A[i]==B[j])
                    {
                        comp[i] = A[i];
                    }
            }
        }
        System.out.println("Os números em comum dos vetores A e B é/são:");
        for(i=0;i<comp.length;i++)
        {
            if(comp[i]!=0)
            {
                System.out.println("{"+comp[i]+"}");
            }
        }
    }
}
