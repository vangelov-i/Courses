package javaSyntax;

import java.util.Scanner;

public class CalculateExpression {
    public static void main(String[] args) {
        // run-vai vseki edin file s ctrl + F9 sled kato go otvorish,
        // che neshto ne mi stignaha slot-ovete ot menu-to gore vdqsno.
        // Ako znaesh kak stava nai- praktichno tova- kaji mi v recenziqta, ako moje.

        Scanner scanner = new Scanner(System.in);

        double a = scanner.nextDouble();
        double b = scanner.nextDouble();
        double c = scanner.nextDouble();

        double sum = a + b + c;
        double avarege = sum / 3;

        double aSquare = Math.pow(a, 2);
        double bSquare = Math.pow(b, 2);
        double formula1Pow = sum / Math.sqrt(c);

        double formula1Result =
                Math.pow((aSquare + bSquare) / (aSquare - bSquare), formula1Pow);

        double forumula2Result =
                Math.pow(aSquare + bSquare - Math.pow(c, 3), a - b);

        double formulasAvarege = (formula1Result + forumula2Result) / 2;
        double difference = Math.abs(formulasAvarege - avarege);

        System.out.printf(
                "F1 result: %.2f; F2 result: %.2f; Diff: %.2f",
                formula1Result,
                forumula2Result,
                difference);
    }
}