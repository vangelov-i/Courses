package softuni;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class FilterArray {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] words = scanner.nextLine().split(" ");

        List<String> longerWords = Arrays.stream(words)
                .filter(word -> word.length() > 3)
                .collect(Collectors.toList());

        if (longerWords.size() > 0) {
            System.out.println(String.join(" ", longerWords));
        } else {
            System.out.println("(empty)");
        }
    }
}
