package vt_para_vt;
import java.util.*;
import static java.util.Arrays.sort;
public class Vt_para_Vt {
    public static void main(String[] args) {
        Random rand = new Random();
        Scanner sc = new Scanner(System.in);
        int a[] = new int [10], b[] = new int [10], c[] = new int [a.length+b.length], r, n, aux;
        //Vetor A
        for(int i=0; i<a.length; i++){
            r = rand.nextInt((30-10) + 1) + 10;
            if(i==0)
            {
                a[i] = r;
            }
            else
            {
                n = 0;
                while(n < i)
                {
                    if(a[n]==r)
                    {
                        r = rand.nextInt((30-10) + 1) + 10;
                        n=0;
                    }
                    else
                    {
                        n++;
                    }    
                }
                a[i] = r;
            }
        }
        //Vetor B
        for(int i=0; i<b.length; i++){
            r = rand.nextInt((50-31) + 1) + 31;
            if(i==0)
            {
                b[i] = r;
            }
            else
            {
                n = 0;
                while(n < i)
                {
                    if(b[n]==r)
                    {
                        r = rand.nextInt((50-30) + 1) + 30;
                        n=0;
                    }
                    else
                    {
                        n++;
                    }    
                }
                b[i] = r;
            }
        }
        sort(a);
        sort(b);
        for(int i=0; i<b.length; i++){
            System.out.println("A{"+i+"}"+"{"+a[i]+"}"+"B{"+i+"}"+"{"+b[i]+"}");
        }
        //Vetor C
        int p = a.length, p1 = b.length;
        for(int i=0; i<a.length; i++){
            c[i] = a[i];
            c[p1] = b[i];
            p1++;
        }
        for(int i=0; i<c.length; i++){
            System.out.println("{"+i+"}"+"{"+c[i]+"}");
        }
        //Busca Binária
        int in=10, fn=20, me=0, bc;
        boolean find = false;
        System.out.println("Número para busca: ");
        bc = sc.nextInt();
        while(in<=fn && find == false){
            me = (in+fn)/2;
            if(c[me] == bc){
                find = true;
            }
            else if(c[me] > bc){
                fn = me - 1;
            }
            else if(c[me] < bc){
                in = me + 1;
            }
        }
        if(find == true){
            System.out.println("O número foi achado na posição "+me+".");
        }
        else if(find == false){
            System.out.println("O número não foi encontrado.");
        }
    }
}
