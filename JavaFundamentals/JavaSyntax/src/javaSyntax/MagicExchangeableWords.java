package javaSyntax;

import java.util.Scanner;

public class MagicExchangeableWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] lineParams = scanner.nextLine().split(" ");

        boolean areExchangeable = checkWordsAreExchangeable(lineParams[0], lineParams[1]);

        System.out.println(areExchangeable);
    }

    private static boolean checkWordsAreExchangeable(String first, String second) {
        boolean result = false;

        if (first.length() != second.length()) {
            return result;
        }

        for (int i = 0; i < first.length(); i++) {
            char currentChar = first.charAt(i);
            int nextIndexToCompare = first.indexOf(currentChar, i +1);
            int difference = currentChar - second.charAt(i);

            while (nextIndexToCompare > - 1) {
                if (currentChar - second.charAt(nextIndexToCompare) != difference) {
                    return result;
                }

                nextIndexToCompare = first.indexOf(currentChar, nextIndexToCompare + 1);
            }
        }

        result = true;

        return result;
    }
}