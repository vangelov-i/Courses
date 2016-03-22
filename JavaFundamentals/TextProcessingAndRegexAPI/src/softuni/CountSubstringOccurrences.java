package softuni;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CountSubstringOccurrences {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();
        String wordToFind = scanner.nextLine();

        String regex = "(?=(" + wordToFind.toLowerCase() + "))";
        Pattern pattern = Pattern.compile(regex);
        Matcher matcher = pattern.matcher(input.toLowerCase());

        int wordOccurrences = 0;
        while (matcher.find()) {
            wordOccurrences++;
        }

        System.out.println(wordOccurrences);
    }
}
