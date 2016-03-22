package javaSyntax;

import java.util.Scanner;

public class ConvertDecimalToBase7 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int numberToConvert = scanner.nextInt();
        String numberToBase7 = Integer.toString(numberToConvert, 7);

        System.out.println(numberToBase7);
    }
}