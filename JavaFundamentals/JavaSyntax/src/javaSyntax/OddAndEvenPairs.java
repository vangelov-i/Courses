package javaSyntax;

import java.util.Scanner;

public class OddAndEvenPairs {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] numbersAsString = scanner.nextLine().split(" ");

        if (numbersAsString.length % 2 != 0) {
            System.out.println("Invalid length");
            return;
        }

        for (int i = 0; i < numbersAsString.length; i+=2) {
            int firstNum = Integer.parseInt(numbersAsString[i]);
            int secondNum = Integer.parseInt(numbersAsString[i+1]);

            if (firstNum % 2 == 0 && secondNum % 2 == 0) {
                System.out.printf("%d, %d -> both are even\n", firstNum, secondNum);
            } else if (firstNum % 2 == 1 && secondNum % 2 == 1) {
                System.out.printf("%d, %d -> both are odd\n", firstNum, secondNum);
            } else {
                System.out.printf("%d, %d -> different\n", firstNum, secondNum);
            }
        }

    }
}