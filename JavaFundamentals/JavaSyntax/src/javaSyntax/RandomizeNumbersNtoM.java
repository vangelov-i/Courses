package javaSyntax;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

public class RandomizeNumbersNtoM {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = scanner.nextInt();
        int m = scanner.nextInt();

        int start = Math.min(n,m);

        int totalNumbers = Math.abs(n-m)+1;
        List<Integer> numbers = new ArrayList<>();

        for (int i = 0; i <= totalNumbers; i++) {
            numbers.add(start++);
        }

        Random random = new Random();

        for (int i = 0; i < totalNumbers; i++) {
            int randomIndex = random.nextInt(totalNumbers - i);
            System.out.print(numbers.get(randomIndex) + " ");
            numbers.remove(randomIndex);
        }
    }
}