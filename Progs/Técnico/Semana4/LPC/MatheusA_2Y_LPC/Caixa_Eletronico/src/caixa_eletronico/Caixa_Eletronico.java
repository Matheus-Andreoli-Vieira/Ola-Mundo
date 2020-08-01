package caixa_eletronico;
import java.util.Scanner;
public class Caixa_Eletronico {

    public static void main(String[] args) 
    {
        Scanner sc=new Scanner(System.in);
        int N;
        int n100,n50,n20,n10;
        int r100,r50,r20,r10;
        System.out.println("\n\tBem vindo:");
        System.out.println("Digite o valor que deseja sacar: ");
        N=sc.nextInt();
        while(N%10!=0)
        {
            System.out.println("Digite um número múltiplo de 10: ");
            N=sc.nextInt();
        }
        if(N%10==0)
        {
            n100=N/100;
            r100=N%100;
            
            n50=r100/50;
            r50=r100%50;
            
            n20=r50/20;
            r20=r50%20;
            
            n10=r20/10;
            r10=r20%10;
            
            if(n100!=0)
            {
                System.out.println(n100+" cédulas de R$100,00");
            }
            if(n50!=0)
            {
                System.out.println(n50+" cédulas de R$50,00");
            }
            if(n20!=0)
            {
                System.out.println(n20+" cédulas de R$20,00");
            }
            if(n10!=0)
            {
                System.out.println(n10+" cédulas de R$10,00");
            }
        }
    }
}