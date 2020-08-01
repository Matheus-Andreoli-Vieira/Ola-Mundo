package corrigindo_provas;
import java.util.Scanner;
public class Corrigindo_Provas 
{
    public static void main(String[] args) 
    {
        Scanner ler = new Scanner(System.in);
        Scanner ent = new Scanner(System.in);
        String nome[] = new String[3];
        int i, j, cont=0, pont[] = new int[3];
        char gab[] = new char[5], resp[][] = new char[3][5];
        
        System.out.println("Digite as respostas. ");
        for(i=0; i<gab.length; i++)
        {
            System.out.print((i+1)+"º pergunta: ");
            gab[i] =  ent.next().charAt(0);
        }
        System.out.println("Nome do Aluno: ");
        for(i=0; i<nome.length; i++)
        {
            System.out.print((i+1)+"º Aluno:");
            nome[i] = ler.next();
            
            System.out.print("Respostas do aluno: ");
            for(j=0; j<resp[i].length; j++)
            {
                System.out.print((j+1)+"º:");
                resp[i][j] = ent.next().charAt(0);
            }
        }
        for(i=0;i<resp.length;i++)
        {
            for(j=0;j<resp[i].length;j++)
            {
                if(resp[i][j] == gab[i])
                    cont=cont+2;
            }
            pont[i]=cont;
            cont=0;
        }
        for(i=0; i<resp.length; i++)
        {
            System.out.println(nome[i]+" teve "+pont[i]+" pontos.");
        }
    }
}