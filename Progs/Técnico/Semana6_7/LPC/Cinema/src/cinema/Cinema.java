package cinema;
import java.util.Scanner;
public class Cinema 
{
    public static void main(String[] args) 
    {
        Scanner ler = new Scanner(System.in);
        Scanner sc = new Scanner(System.in);
        String vt[] = {"B1","B2","B3","B4","B5","B6","B7","B8","B9","B10"};
        String lg, reserva[] = new String [10];
        int i, op=0;
        
        do
        {
            if(op==1)
            {
                System.out.println("\n\n\n\n\n\n\n\n\n\n\n");
            }
            for(i=0; i<vt.length; i++)
                {
                    System.out.print("{"+vt[i]+"}");
                }
            System.out.println("\nDigite o lugar que deseja reservar: ");
            lg = ler.next();
            lg = lg.toUpperCase();
            for(i=0;i<vt.length;i++)
            {
                if(lg.equals(reserva[i]))
                {
                    System.out.println("O lugar já doi reservado.");
                }
                else if(lg.equals(vt[i]))
                {
                    System.out.println("Reserva feita com êxito.");
                    reserva[i] = vt[i];
                    vt[i] = "---";
                }
            }
            System.out.println("Deseja reserva outro lugar?\n1-Sim\n2-Não");
            op = sc.nextInt();
        }while(op==1);
        for(i=0; i<vt.length; i++)
            {
                System.out.print("{"+vt[i]+"}");
            }
    }
}
