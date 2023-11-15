package collection;
import java.util.Arrays;
import java.util.Scanner;

public class Question2 {


    public static void EBandEK(int[] list){

        Arrays.sort(list);
        int[] eb3 = new int[3]; 
        int[] ek3 = new int[3];  
        // int[] order = new int[list.length];
        int listlength= list.length;

        
        for(int a=0;a<eb3.length;a++){
            ek3[a]=list[a];
        }

        for(int b=0;b<eb3.length;b++){
            eb3[b]=list[listlength-1];
            listlength--;
        }
        double avgeb;
        double avgek;

        double eksum=0; 
        double ebsum=0;

        for(int a:eb3){
            ebsum+=a;
        }

        for(int b:ek3){
            eksum+=b;
        }
        
       avgeb= ebsum/eb3.length;
       avgek= eksum/eb3.length;

       String formatliSayi2 = String.format("%.2f", avgeb);
       String formatliSayi3 = String.format("%.2f", avgek);

        System.out.println("en büyük 3 sayının ortalaması: "+formatliSayi2);
        System.out.println("en küçük 3 sayının ortalaması: "+formatliSayi3);

        System.out.println("en büyük 3 sayı:"+Arrays.toString(eb3));
        System.out.println("en küçük 3 sayı:"+Arrays.toString(ek3));
        
    }
    
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int sayi = 20;
        int[] array = new int[sayi];
        for(int a=1;a<=sayi;a++) {
            System.out.println(a+". sayiyi girin");

            if(scanner.hasNextInt()){   
            int b = scanner.nextInt();
                array[a]=b;
        }
    }
    EBandEK(array);
    //! System.out.println(Arrays.toString(array));  // this work
}
}