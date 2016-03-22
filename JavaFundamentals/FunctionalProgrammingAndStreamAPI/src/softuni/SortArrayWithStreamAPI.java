package softuni;

import java.util.*;
import java.util.stream.Collectors;

public class SortArrayWithStreamAPI {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<Integer> sortedNumbers = Arrays.stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt).sorted().collect(Collectors.toList());

        String sortingOrder = scanner.nextLine();
        if (sortingOrder.equals("Descending")) {
            Collections.reverse(sortedNumbers);
            for (Integer number : sortedNumbers) {
                System.out.print(number + " ");
            }

            return;
        }

        for (Integer number : sortedNumbers) {
            System.out.print(number + " ");
        }
    }
}