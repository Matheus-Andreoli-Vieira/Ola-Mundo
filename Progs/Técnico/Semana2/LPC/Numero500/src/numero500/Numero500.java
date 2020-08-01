
package numero500;

import java.util.Random;
import java.util.Scanner;

public class Numero500 {
    
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        Random rand=new Random();
        int n=0,r,contr=0;
        System.out.println("Digite qualquer número até 500:");
        n=sc.nextInt();
        r=rand.nextInt(500);
        while(r!=n)
        {
            r=rand.nextInt(500);
            System.out.println(r);
            contr++;
        }
        System.out.println("A máquina acertou o número "+r+" em "+contr+" tentativas.");
    }
    
}
