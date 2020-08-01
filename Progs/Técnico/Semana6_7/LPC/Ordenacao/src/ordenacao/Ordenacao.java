package ordenacao;
import java.util.Scanner;
public class Ordenacao {

    public static void main(String[] args) 
    {
        Scanner sc=new Scanner(System.in);
        int vt[] = new int[4], i, j, aux;
        for(i=0; i<vt.length; i++)
        {
            System.out.println("Digite um Número: ");
            vt[i]=sc.nextInt();
        }
        for(i=0; i<vt.length; i++)
        {
            for(j=i+1; j<vt.length; j++)
            {
                if(vt[i] > vt[j])
                {
                    aux = vt[i];
                    vt[i] = vt[j];
                    vt[j] = aux;
                }
            }
        }
        for(i=0; i<vt.length; i++)
        {
            System.out.println("{"+i+"}"+"{"+vt[i]+"}");
        }
    }
}
