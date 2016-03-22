package streams;

import java.io.*;

public class CountCharacterType {
    public static void main(String[] args) {
        try (
                BufferedReader reader = new BufferedReader(
                        new FileReader("resources/CountCharacterType.txt"));
                BufferedWriter writer = new BufferedWriter(
                        new FileWriter("resources/count-chars.txt")
                )
        ) {
            int vowelsCount = 0;
            int consonantsCount = 0;
            int punctuationsCount = 0;

            String line = reader.readLine();
            while (line != null) {
                for (int i = 0; i < line.length(); i++) {
                    char currentChar = line.charAt(i);

                    if (Character.isLetter(currentChar)) {
                        boolean charIsVowel =
                                currentChar == 'o' ||
                                currentChar == 'u' ||
                                currentChar == 'e' ||
                                currentChar == 'i' ||
                                currentChar == 'a';
                        if (charIsVowel) {
                            vowelsCount++;
                        } else {
                            consonantsCount++;
                        }
                    } else if (currentChar == ',' || currentChar == '.' || currentChar == '!' || currentChar == '?') {
                        punctuationsCount++;
                    }
                }

                line = reader.readLine();
            }

            String result = String.format(
                    "Vowels: %d\r\nConsonants: %d\r\nPunctuation: %d",
                    vowelsCount,
                    consonantsCount,
                    punctuationsCount);

            writer.write(result);
        } catch (FileNotFoundException fnfe) {
            fnfe.printStackTrace();
        } catch (IOException ioex) {
            System.err.println("Cannot open the file.");
        }
    }
}