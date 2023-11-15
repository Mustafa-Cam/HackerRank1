package collection;

import java.util.Scanner;

public class Question3 {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in); 

        System.out.println("Lütden kelime cümle yazın");
        String kelime = scanner.nextLine();
        char[] sesliHarfler = sesliHarfleriBul(kelime);

        System.out.println("Kelime: " + kelime);
        System.out.print("Sesli Harfler: ");
        for (char harf : sesliHarfler) {
            System.out.print(harf + " ");
        }
        scanner.close();
    }

    public static char[] sesliHarfleriBul(String kelime) {
        char[] sesliHarfler = new char[kelime.length()];
        int index = 0;

        for (int i = 0; i < kelime.length(); i++) {
            char harf = kelime.charAt(i);
            if (sesliMi(harf)) {
                sesliHarfler[index] = harf;
                index++;
            }
        }

        // Gerektiğinde boyutu ayırabilirsiniz
        // char[] sonuc = new char[index];
        // System.arraycopy(sesliHarfler, 0, sonuc, 0, index);

        return sesliHarfler;
    }

    public static boolean sesliMi(char harf) {
        harf = Character.toUpperCase(harf); // Büyük/küçük harf duyarlılığını kaldırmak için
        return harf == 'A' || harf == 'E' || harf == 'I' || harf == 'O' || harf == 'U';
    }
    
}

