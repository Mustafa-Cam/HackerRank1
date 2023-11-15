package collection;

import java.io.Console;
import java.util.ArrayList;
import java.util.Scanner;

public class Question1 {
   

public static boolean isPrime(int a){
    for(int i=2;i<=Math.sqrt(a);i++){
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
        int b = scanner.nextInt();
        integerList.add(b);
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
