package softuni;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<Integer> numbers = Arrays.stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt).collect(Collectors.toList());

        int currentSequenceCount = 1;
        int biggestSequenceCount = 1;
        int biggestSeqStartIndex = 0;

        System.out.print(numbers.get(0));

        for (int index = 1; index < numbers.size(); index++) {
            int currentNumber = numbers.get(index);

            if (currentNumber <= numbers.get(index - 1)) {
                System.out.println();
                currentSequenceCount = 1;
            } else {
                System.out.print(" ");
                currentSequenceCount++;
            }

            System.out.print(currentNumber);

            if (biggestSequenceCount < currentSequenceCount) {
                biggestSequenceCount = currentSequenceCount;
                biggestSeqStartIndex = index - biggestSequenceCount + 1;
            }
        }

        System.out.println();
        System.out.print("Longest: ");

        int longestSeqEndIndex = biggestSeqStartIndex + biggestSequenceCount - 1;
        for (int index = biggestSeqStartIndex; index < longestSeqEndIndex; index++) {
            System.out.print(numbers.get(index) + " ");
        }

        System.out.println(numbers.get(longestSeqEndIndex));
    }
}