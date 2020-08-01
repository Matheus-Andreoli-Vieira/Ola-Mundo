package nome;
import java.util.Scanner;
import java.util.Arrays;
public class Nome 
{
    public static void main(String[] args) 
    {
        Scanner ler = new Scanner(System.in);
        Scanner sc = new Scanner(System.in);
        String nome[] = new String[10], n;
        int op;
        
        System.out.println("Digite um nome:");
        for(int i=0;i<nome.length;i++)
        {
            System.out.println("{"+i+"}"+"Nome:");
            nome[i] = ler.next().toUpperCase();
            for(int j=0;j<i;j++)
            {
                if(nome[i].equals(nome[j]))
                {
                    System.out.println("Nome repetido.");
                    i--;
                }
            }
        }
        Arrays.sort(nome);
        for(int i=0;i<nome.length;i++)
        {
            System.out.println("{"+i+"}"+"{"+nome[i]+"}");
        }
        do
        {
            boolean find = false;
            System.out.println("Verificação de nome");
            System.out.println("Digite um nome para verificar:");
            n = ler.next().toUpperCase();
            for(int i=0;i<nome.length;i++)
            {
                if(n.equals(nome[i]))
                {
                    System.out.println("{"+i+"}"+"{"+nome[i]+"}");
                    find = true;
                }
            }
            if(find==false)
            {
                System.out.println("Nome não encontrado.");
            }
            System.out.println("Deseja pesquisar outro nome?\n1-SIM\n2-NÃO");
            op = sc.nextInt();
            while(op!=1 && op!=2)
            {
                System.out.println("Digite um núemero válido!!!\n1-SIM\n2-NÃO");
                op = sc.nextInt();
            }
        }while(op==1);
    }
}