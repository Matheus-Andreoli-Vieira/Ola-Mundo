package vt_abcd;
import static java.util.Arrays.sort;
import java.util.Random;
public class VT_ABCD {
    public static void main(String[] args) {
        Random rand = new Random();
        int a[] = new int[10];
        int b[] = new int[20];
        int c[] = new int[30];
        int d[] = new int[60];
        int sa = 0, sb = 0, sc = 0, sd = 0;
        //VETOR A
        for (int i = 0; i < a.length; i++) {
            a[i] = 10 + rand.nextInt(20);
            for (int j = 0; j < i; j++) {
                if (a[i] == a[j]) {
                    i--; 
                }
            }
        }
        //VETOR B
        for (int i = 0; i < b.length; i++) {
            b[i] = 30 + rand.nextInt(70);
            for (int j = 0; j < i; j++) {
                if (b[i] == b[j]) {
                    i--; 
                }
            }
        }
        //VETOR C
        for (int i = 0; i < c.length; i++) {
            c[i] =rand.nextInt((90-50) + 1) + 50;
            for (int j = 0; j < i; j++) {
                if (c[i] == c[j]) {
                    i--; 
                }
            }
        }
        sort(a);
        sort(b);
        sort(c);
        int n1 = a.length, n2 = b.length, n3 = c.length;
        //VETOR D
        for(int i=0; i< a.length; i++){
            d[i] = a[i];
        }
        for(int i=0; i< b.length; i++){
            d[n2-n1] = b[i];
            n2++;
        }
        for(int i=0; i< c.length; i++){
            d[n3] = c[i];
            n3++;
        }
        //Exibição e soma dos vetores
        for(int i=0; i<a.length; i++){
            sa += a[i];
        }
        for(int i=0; i<b.length; i++){
            sb += b[i];
        }
        for(int i=0; i<c.length; i++){
            sc += c[i];
        }
        for(int i=0; i<d.length; i++){
            sd += d[i];
        }
        System.out.println("Índice\tVetor A\tVetor B\tVetor C\tVetor D");
        for(int i=0; i <d.length; i++){
            if(i<a.length){
                System.out.println("{"+i+"}=\t"+"{"+a[i]+"}\t{"+b[i]+"}\t{"+c[i]+"}\t{"+d[i]+"}");
            }
            else if(i<20){
                System.out.println("{"+i+"}=\t\t{"+b[i]+"}\t{"+c[i]+"}\t{"+d[i]+"}");
            }
            else if(i<30){
                System.out.println("{"+i+"}=\t\t\t{"+c[i]+"}\t{"+d[i]+"}");
            }
            else{
                System.out.println("{"+i+"}=\t\t\t\t{"+d[i]+"}");
            }
        }
        System.out.printf("\tA soma dos vetores:\t\nA %d\t\nB %d\t\nC %d\t\nD %d\n", sa, sb, sc, sd);
    }   
}
