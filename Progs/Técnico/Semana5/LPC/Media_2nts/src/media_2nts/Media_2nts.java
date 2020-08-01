package media_2nts;
import java.util.Scanner;
public class Media_2nts {

    public static void main(String[] args) 
    {
        Scanner ler = new Scanner(System.in);
        Scanner sc=new Scanner(System.in);
        float n1[]=new float[8], n2[]=new float[8], md[]=new float[4];
        int i;
        String nome[]=new String[4];
        for(i=0;i<nome.length;i++)
        {
            System.out.println((i+1)+"º aluno.");
            System.out.println("Digite seu nome: ");
            nome[i]= ler.next();
            System.out.println("Escreva a 1º nota: ");
            n1[i]= sc.nextFloat();
            System.out.println("Escreva a 2º nota: ");
            n2[i]= sc.nextFloat();
            md[i] = (n1[i]+n2[i])/2;
        }
        for(i=0;i<nome.length;i++)
        {
            System.out.println("Aluno: "+nome[i]+"  Média: "+md[i]);
        }
    }
}
