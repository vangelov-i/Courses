package softuni;

import java.util.*;

public class MostFrequentWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // TODO: try to make this by mapping the HashMap
        String[] words = scanner.nextLine().toLowerCase().split("\\W+");
        TreeMap<String, Integer> wordsOccurences = new TreeMap<>();
        int biggestCount = 0;

        for (String word : words) {
            if (!wordsOccurences.containsKey(word)) {
                wordsOccurences.put(word, 0);
            }

            int value = wordsOccurences.get(word) + 1;
            wordsOccurences.put(word, value);

            biggestCount = biggestCount < value ? value : biggestCount;
        }

        for (Map.Entry<String, Integer> stringIntegerEntry : wordsOccurences.entrySet()) {
            if (stringIntegerEntry.getValue() == biggestCount) {
                System.out.printf(
                        "%s -> %d times%n",
                        stringIntegerEntry.getKey(),
                        biggestCount);
            }
        }
    }
}
