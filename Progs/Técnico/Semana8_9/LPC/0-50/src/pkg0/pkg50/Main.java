package pkg0.pkg50;
import java.util.Random;
public class Main 
{
    public static void main(String[] args) 
    {
        Random rand = new Random();
        int vt[] = new int [20], r, i, aux, j;
        
        for(i=0;i<vt.length;i++)
            {
            r = rand.nextInt(51); 
            vt[i]=r;
            }
        for(i=0;i<vt.length;i++)
            {
                System.out.println("{"+i+"}"+"{"+vt[i]+"}");
            }
        
        for(i=0;i<vt.length;i++)
            {
                for(j=i+1;j<vt.length;j++)
                {
                    if(vt[i]>vt[j])
                    {
                        aux = vt[i];
                        vt[i] = vt[j];
                        vt[j] = aux;
                    }
                }
            }
        System.out.println("\n\tOrdem Crescente.");
        for(i=0;i<vt.length;i++)
            {
                System.out.println("{"+i+"}"+"{"+vt[i]+"}");
            }
    }
}