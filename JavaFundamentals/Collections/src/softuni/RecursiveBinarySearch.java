package softuni;

import javafx.collections.transformation.SortedList;

public class RecursiveBinarySearch {
    public static void main(String[] args) {
        // TODO: still in progress
    }

    private static <T> int binarySearchIndexOf(T element, SortedList<Comparable<T>> collection) {
        int result = -1;

        int indexToCheck = collection.size() / 2;
        Comparable<T> currentElement = collection.get(indexToCheck);

        if (currentElement.compareTo(element) > 0) {
            indexToCheck += (collection.size() - indexToCheck) / 2;
        }


        return result;
    }
}