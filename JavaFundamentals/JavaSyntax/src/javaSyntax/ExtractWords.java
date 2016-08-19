package javaSyntax;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String inputLine = scanner.nextLine();

        Pattern pat = Pattern.compile("([A-za-z]{2,})");

        Matcher matcher = pat.matcher(inputLine);

        while (matcher.find()) {
            System.out.print(matcher.group() + " ");
        }

        System.out.println();
    }
}