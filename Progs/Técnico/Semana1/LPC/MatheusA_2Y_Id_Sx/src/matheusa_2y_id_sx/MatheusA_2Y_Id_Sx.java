/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package matheusa_2y_id_sx;

/**
 *
 * @author Matheus
 */
import java.util.Scanner;
public class MatheusA_2Y_Id_Sx {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int id,i,sx,cm=0,cf=0,cmid=0,cfid=0,acmid=0,acfid=0;
        float mdm=0,mdf=0;
        for(i=1;i<=10;i++)
        {
        System.out.println("Digite a sua idade:");
        id=sc.nextInt();
        System.out.println("Digite o seu sexo: \n1-Masculino \n2-Feminino");
        sx=sc.nextInt();
        while(sx!=1 && sx!=2)
        {
            System.out.println("Digite um número válido: \n1-Masculino \n2-Feminino");
            sx=sc.nextInt();  
        }
        if(sx==1)
        {
            acmid=acmid+id;
        }
        else if(sx==2)
        {
            acfid=acfid+id;
        }
        if(sx==1)
        {
            cm++;
        }
        else if(sx==2)
        {
            cf++;
        }
        if(sx==1 && id>21)
        {
            cmid++;
        }
        else if(sx==2 && id<21)
        {
            cfid++;
        }
        }
        mdm=acmid/cm;
        mdf=acfid/cf;
        System.out.println("Quantidade de homens : "+cm);
        System.out.println("Quantidade de mulheres : "+cf);
        System.out.println("Quantidade de homens com mais de 21 anos :"+cmid);
        System.out.println("Quantidade de mulheres com menos de 21 anos :"+cfid);
        System.out.println("Média das idades dos homens :"+mdm);
        System.out.println("Média das idades das mulheres :"+mdf);
    }
    
}