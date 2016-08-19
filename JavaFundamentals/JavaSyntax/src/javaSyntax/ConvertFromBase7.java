package javaSyntax;

import java.util.Scanner;

public class ConvertFromBase7 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String base7Number = scanner.nextLine();

        System.out.println(Integer.parseInt(base7Number, 7));
    }
}