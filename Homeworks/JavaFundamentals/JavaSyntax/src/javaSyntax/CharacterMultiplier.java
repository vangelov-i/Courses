package javaSyntax;

import java.util.Scanner;

public class CharacterMultiplier {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] words = scanner.nextLine().split(" ");

        long sum = getSumOfMultipliedChars(words[0], words[1]);

        System.out.println(sum);
    }

    private static long getSumOfMultipliedChars(String first, String second) {
        String longest = "";
        int maxLength = 0;
        int minLength = 0;

        if (first.length() >= second.length()) {
            longest = first;
            maxLength = first.length();
            minLength = second.length();
        } else {
            longest = second;
            maxLength = second.length();
            minLength = first.length();
        }

        long result = 0L;

        for (int i = 0; i < maxLength; i++) {
            if (i < minLength) {
                result += first.charAt(i) * second.charAt(i);
                continue;
            }

            result += longest.charAt(i);
        }

        return result;
    }
}