package softuni;

import java.math.BigInteger;
import java.util.Scanner;

public class CalculateNFactorial {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int number = scanner.nextInt();

        long factorial = calculateFactorial(number);
        System.out.println(factorial);

//        BigInteger bigFactorial = calculateBigFactorial(number);
//        System.out.println(bigFactorial);
    }

    private static long calculateFactorial(int number) {
        long result = number;
        if (number > 1) {
            result *= calculateFactorial(number - 1);
        } else if (number == 0) {
            result = 1;
        }

        return result;
    }

    private static BigInteger calculateBigFactorial(int number) {
        BigInteger result = BigInteger.valueOf(number);
        if (number > 1) {
            result = result.multiply(calculateBigFactorial(number - 1));
        } else if (number == 0) {
            result = BigInteger.valueOf(1);
        }

        return result;
    }
}
