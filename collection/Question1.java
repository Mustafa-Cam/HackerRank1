package collection;

import java.io.Console;
import java.util.ArrayList;
import java.util.Scanner;

public class Question1 {
   

public static boolean isPrime(int a){
    for(int i=2;i<=Math.sqrt(a);i++) {
        if(a%i==0){
            return false;
        }
    }
    return true;
}

    public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);
        
    
    int sayi = scanner.nextInt();
    ArrayList<Integer> integerList = new ArrayList<>();
    ArrayList<Integer> prime = new ArrayList<>();
    ArrayList<Integer> normalNum = new ArrayList<>();

    System.out.println("Lütfen"+ sayi +"sayı giriniz");
    for(int a=0;a<sayi;a++) {
        
        System.out.println(a+". sayiyi girin");

        if(scanner.hasNextInt()){   
            int b = scanner.nextInt();
        if(b<0){
            System.out.println("Enter the positive number not negative.");
            a--;
        }  else{
            integerList.add(b);
        }
        }
        else{
        System.out.println("Enter number");   
        scanner.next(); // buffer ı temizle knkm yani bizim değer sayı olmadığı zaman buffer da kalıyor onu temizlemen gerek yoksa sürekli sayı olmadığı için sonsuz döngüye girecek.
        a--;    
        
    } 
    }



    for(int a :integerList) {
        if(isPrime(a)){
            prime.add(a);
        }
        else{
            normalNum.add(a);
        }
    }

        System.out.println(prime);
        System.out.println(normalNum);

    // System.out.println(integerListesi); control=true

    scanner.close();
    }
}
