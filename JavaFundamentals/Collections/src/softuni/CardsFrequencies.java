package softuni;

import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class CardsFrequencies {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] cards = scanner.nextLine().split("\\W+");
        LinkedHashMap<String, Integer> cardsOccurences = new LinkedHashMap<>();

        for (String card : cards) {
            if (!cardsOccurences.containsKey(card)) {
                cardsOccurences.put(card, 0);
            }

            int value = cardsOccurences.get(card) + 1;
            cardsOccurences.put(card, value);
        }

        for (String card : cardsOccurences.keySet()) {
            float percentage = (float)cardsOccurences.get(card) / cards.length * 100;
            System.out.printf("%s -> %.2f%%%n", card, percentage);
        }
    }
}
