package softuni;

import java.util.Scanner;

public class SequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] words = scanner.nextLine().split(" ");

        System.out.print(words[0]);

        for (int i = 1; i < words.length; i++) {
            String currentWord = words[i];
            if (!currentWord.equals(words[i - 1])) {
                System.out.println();
            } else {
                System.out.print(" ");
            }

            System.out.print(currentWord);
        }
    }
}
