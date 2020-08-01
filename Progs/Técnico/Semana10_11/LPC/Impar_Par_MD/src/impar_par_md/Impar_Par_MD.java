package impar_par_md;
import java.util.Random;
public class Impar_Par_MD 
{
    public static void main(String[] args) 
    {
        Random rand = new Random();
        int vt[] = new int [10], aux, r, cti = 0, ctp = 0, aci = 0, acp = 0, c;
        float mdi, mdp;
        for(int i=0;i<vt.length;i++)
        {
            r = rand.nextInt(20)+1;
            if(i==0)
            {
                vt[i] = r;
            }
            else
            {
                c = 0;
                while(c < i)
                {
                    if(vt[c]==r)
                    {
                        r = rand.nextInt(20)+1;
                        c=0;
                    }
                    else
                    {
                        c++;
                    }    
                }
                vt[i] = r;
            }
        }
        for(int a=0;a<vt.length;a++)
        {
            for(int b=a+1;b<vt.length;b++)
            {
                if(vt[a] > vt[b])
                {
                    aux = vt[a];
                    vt[a] = vt[b];
                    vt[b] = aux;
                }
            }
        }
        for(int a=0;a<vt.length;a++)
        {
            System.out.println("{"+a+"}"+"{"+vt[a]+"}");
        }
        for(int i=0;i<vt.length;i++)
        {
            if(vt[i]%2==0)
            {
                acp= acp +vt[i];
                ctp++;
            }
            else
            {
                aci = aci + vt[i];
                cti++;
            }
        }
        mdp = acp / ctp;
        mdi = aci / cti;
        System.out.println("Par="+ctp+"\nImpar="+cti);
        System.out.println("Média Par = "+mdp+"\nMédia Impar = "+mdi);
    }
}