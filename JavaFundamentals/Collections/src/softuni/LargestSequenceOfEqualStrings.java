package softuni;

import java.util.Scanner;

public class LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] words = scanner.nextLine().split(" ");

        int currentSequenceCount = 1;
        int biggestSequenceCount = 1;
        int biggestSeqElementIndex = -1;

        for (int index = 1; index < words.length; index++) {
            String currentWord = words[index];

            if (currentWord.equals(words[index - 1])) {
                currentSequenceCount++;
            } else {
                currentSequenceCount = 1;
            }

            if (biggestSequenceCount < currentSequenceCount) {
                biggestSequenceCount = currentSequenceCount;
                biggestSeqElementIndex = index;
            }
        }

        for (int index = 0; index < biggestSequenceCount - 1; index++) {
            System.out.print(words[biggestSeqElementIndex] + " ");
        }

        System.out.print(words[biggestSeqElementIndex]);
    }
}