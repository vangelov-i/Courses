package softuni;

import java.util.Scanner;

public class CombineListsOfLetters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String firstLine = scanner.nextLine();
        String secondLine = scanner.nextLine();

        System.out.print(firstLine);

        for (int index = 0; index < secondLine.length(); index++) {
            char currentChar = secondLine.charAt(index);

            if (currentChar != ' ' && firstLine.indexOf(currentChar) == -1) {
                System.out.print(" " + currentChar);
            }
        }
    }
}
