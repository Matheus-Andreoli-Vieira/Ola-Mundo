package busca_binaria;
import java.util.Random;
import java.util.Scanner;
public class Busca_binaria 
{
    public static void main(String[] args) 
    {
        Random rand = new Random();
        Scanner sc = new Scanner(System.in);
        int vt[] = new int[50], sch, r, c, aux, ct=0;
        int in, fn, me;
        boolean find = false;
        for(int i=0;i<vt.length;i++)
        {
            r = rand.nextInt((200-100)+1)+100;
            if(i==0)
            {
                vt[i]=r;
            }
            else
            {
                c=0;
                while(c<i)
                {
                    if(vt[c]==r)
                    {
                       r = rand.nextInt((200-100)+1)+100; 
                       c=0;
                    }
                    else
                    {
                        c++;
                    }
                }
                vt[i]=r;
            }
        }
        for(int i=0;i<vt.length;i++)
        {
            for(int j=i+1;j<vt.length;j++)
            {
                if(vt[i] > vt[j])
                {
                    aux = vt[i];
                    vt[i] = vt[j];
                    vt[j] = aux;
                }
            }
        }
        for(int i=0;i<vt.length;i++)
        {
            System.out.println("{"+i+"}"+"{"+vt[i]+"}");
        }
        in = 0;
        fn = 50;
        me = 0;
        System.out.println("Número para a busca: ");
        sch = sc.nextInt();
        while(in <= fn && find == false)
        {
            me = (in+fn)/2;
            if(vt[me]==sch)
            {
                find = true;
            }
            else if(vt[me] > sch)
            {
                fn = me-1;
            }
            else if(vt[me] < sch)
            {
                in = me+1;
            }
            ct++;
        }
        if(find==true)
        {
            System.out.println("Valor encontrado na posição "+me);
            System.out.println("Foram feitas "+ct+" busca até encontrar o número pesquisado.");
        }
        else if(find == false)
        {
            System.out.println("Valor não encontrado.");
            System.out.println("Foram feitas "+ct+" busca até não encontrar o número pesquisado.");
        }
    }
}
