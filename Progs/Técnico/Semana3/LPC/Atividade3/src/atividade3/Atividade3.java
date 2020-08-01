package atividade3;

import java.util.Random;

public class Atividade3 {
    public static void main(String[] args) 
    {
        int Cont_M20=0, Cont_m20=0, Ac_M20=0, Ac_m20=0, r, ContT=0;
        float  Md_M20, Md_m20,Pc_M20, Pc_m20;
        Random  rand=new Random();
        r=rand.nextInt(51);
        System.out.println(r);
        if(r>20)
        {
            Cont_M20++;
            Ac_M20=Ac_M20+r;
        }
           else
        {
            Cont_m20++;
            Ac_m20=Ac_m20+r;
        }
        ContT++;
        while(r!=0)
        {
           r=rand.nextInt(51);
           System.out.println(r);
           if(r>20)
                {
                    Cont_M20++;
                    Ac_M20=Ac_M20+r;
                }
           else
                {
                    Cont_m20++;
                    Ac_m20=Ac_m20+r;
                }
           ContT++;
        }
        Md_M20= Ac_M20 / Cont_M20;
        Md_m20= Ac_m20 / Cont_m20;
        Pc_M20= (Cont_M20*100)/ContT;
        Pc_m20= (Cont_m20*100)/ContT;
        System.out.println("Qntd de números gerados :"+ContT);
        System.out.println("Quantidade de números maiores que 20 = "+Cont_M20);
        System.out.println("Quantidade de números menores que 20 = "+Cont_m20);
        System.out.println("A média dos números maiores que 20 = "+Md_M20);
        System.out.println("A média dos números menores que 20 = "+Md_m20);
        System.out.println("A porcentagem de números maiores que 20 = "+Pc_M20);
        System.out.println("A porcentagem de números menores que 20 = "+Pc_m20);
    }
    
}