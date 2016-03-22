package javaSyntax;

import java.util.Scanner;

public class GetFirstOddOrEvenElements {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] numbersAsStr = scanner.nextLine().split(" ");
        int[] numbers = new int[numbersAsStr.length];

        for (int i = 0; i < numbersAsStr.length; i++) {
            numbers[i] = Integer.parseInt(numbersAsStr[i]);
        }

        String[] secondLine = scanner.nextLine().split(" ");

        int n = Integer.parseInt(secondLine[1]);
        String selector = secondLine[2];

        printFirstNEvenOrOddElements(numbers, n, selector);
    }

    private static void printFirstNEvenOrOddElements(
            int[] numbers,
            int n,
            String selector) {
        int counter = 0;

        for (int i = 0; i < numbers.length; i++) {
            int number = numbers[i];

            if (selector.equals("even") && number % 2 == 0) {
                System.out.print(number + " ");
                counter++;
            } else if (selector.equals("odd") && number % 2 == 1) {
                System.out.print(number + " ");
                counter++;
            }

            if (counter == n) {
                break;
            }
        }

        System.out.println();
    }
}