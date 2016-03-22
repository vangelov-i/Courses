package softuni;

import java.util.Scanner;
import java.util.TreeSet;

public class ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] words = scanner.nextLine().toLowerCase().split("\\W+");
        TreeSet<String> sortedUniqueWords = new TreeSet<>();

        for (String word : words) {
            sortedUniqueWords.add(word);
        }

        for (String word : sortedUniqueWords) {
            System.out.print(word + " ");
        }
    }
}