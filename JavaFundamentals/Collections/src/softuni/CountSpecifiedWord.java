package softuni;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine().toLowerCase();
        String wordToSearch = scanner.nextLine().toLowerCase();

        Pattern pattern = Pattern.compile(wordToSearch + "\\W");
        Matcher matcher = pattern.matcher(text);

        int matches = 0;
        while (matcher.find()) {
            matches++;
        }

        System.out.println(matches);
    }
}
