package torneio_futebol;
import java.util.Scanner;
public class Torneio_Futebol 
{
    public static void main(String[] args) 
    {
        Scanner ler=new Scanner(System.in);
        String vt[] = new String[3];
        int i,j;
        
        for(i=0; i<vt.length; i++)
        {
            System.out.println("Digite o nome do "+(i+1)+"º time: ");
            vt[i] = ler.nextLine();
        }
        
        for(i=0;i<vt.length;i++)
        {
            for(j=i;j<vt.length;j++)
            {
                if(!vt[i].equals(vt[j]))
                {
                    System.out.println(vt[i]+"  x   "+vt[j]);
                }
                if(!vt[j].equals(vt[i]))
                {
                    System.out.println(vt[j]+"  x   "+vt[i]);
                }
            }
        }
    }   
}