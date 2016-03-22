package softuni;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class SortArrayOfNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        scanner.nextLine();

        List<Integer> sortedNumbers = Arrays.stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt).sorted().collect(Collectors.toList());

        for (Integer sortedNumber : sortedNumbers) {
            System.out.print(sortedNumber + " ");
        }
    }
}