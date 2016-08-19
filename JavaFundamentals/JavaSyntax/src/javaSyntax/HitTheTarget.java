package javaSyntax;

import java.util.Scanner;

public class HitTheTarget {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int targetNum = scanner.nextInt();

        for (int firstNum = 1; firstNum <= 20; firstNum++) {
            for (int secondNum = 1; secondNum <= 20; secondNum++) {
                if (firstNum + secondNum == targetNum) {
                    System.out.printf("%d + %d = %d\n",firstNum, secondNum, targetNum);
                }

                int bigger = Math.max(firstNum, secondNum);
                int smaller = Math.min(firstNum, secondNum);

                if (bigger - smaller == targetNum) {
                    System.out.printf("%d - %d = %d\n",firstNum, secondNum, targetNum);
                }
            }
        }
    }
}