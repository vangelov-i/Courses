package streams;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class SumLines {
    public static void main(String[] args) {
        try (
                BufferedReader reader = new BufferedReader(
                        new FileReader("resources/sumLines/lines.txt"));
                ) {
            String line = reader.readLine();

            while (line != null) {
                long charactersSum = 0L;
                for (int i = 0; i < line.length(); i++) {
                    charactersSum += line.charAt(i);
                }

                System.out.println(charactersSum);

                line = reader.readLine();
            }
        } catch (FileNotFoundException fnfe) {
            fnfe.printStackTrace();
        } catch (IOException ioex) {
            ioex.printStackTrace();
        }
    }
}
