package pares;
import java.util.Scanner;
public class Pares {
    
    public static void main(String[] args) 
    {
        Scanner sc=new Scanner(System.in);
        int vt[] = new int[4], i;
        for(i=0;i<vt.length;i++)
        {
            System.out.println("Digite o "+(i+1)+"º número:");
            vt[i]= sc.nextInt();
        }
        for(i=0;i<vt.length;i++)
        {
            if(vt[i]%2==0)
            {
                System.out.println("Número par: "+vt[i]);
            }
        }
    }
}
