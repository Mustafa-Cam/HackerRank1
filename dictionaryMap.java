import java.util.*;

class Solution {
    public static void main(String[] argh) {
        try (Scanner in = new Scanner(System.in)) {
            int n = in.nextInt();
            Map<String, Integer> phonebook = new HashMap<>();

            for (int i = 0; i < n; i++) {
                String name = in.next();
                int phone = in.nextInt();
                phonebook.put(name, phone);
            }

            // Check for more input
            while (in.hasNext()) {
                String s = in.next();
                
                Integer phoneNumber = phonebook.get(s); // burda ben for ile değerleri döndüm timeout hatası verdi çok haklı çünkü veri yapılarında da gördüğümüüz gibi döngü içinde döngü kullanmak O(n^2) oluyor bunu yapmasak daha iyi olur. bu get fonksiyonu ile getirebiliyor muşuz.  

                if (phoneNumber != null) {
                    System.out.println(s + "=" + phoneNumber);
                } else {
                    System.out.println("Not found");
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
