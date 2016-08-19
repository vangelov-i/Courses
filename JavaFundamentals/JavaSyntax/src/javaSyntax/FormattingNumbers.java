package javaSyntax;

import java.util.Scanner;

public class FormattingNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int a = scanner.nextInt();
        double b = scanner.nextDouble();
        double c = scanner.nextDouble();

        String aToBinaryPadded =
                ("0000000000" + Integer.toBinaryString(a)).substring(Integer.toBinaryString(a).length());

        System.out.printf(
                "|%-10s|%s|%10.2f|%10.3f|",
                Integer.toHexString(a).toUpperCase(),
                aToBinaryPadded,
                b,
                c
                );
    }
}
