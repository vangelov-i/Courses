package streams;

import java.io.*;

public class AllCapitals {
    public static void main(String[] args) {
        try (
                BufferedReader reader = new BufferedReader(new FileReader("resources/allCapital/lines.txt"))
        ) {
            String line = reader.readLine();
            StringBuilder result = new StringBuilder();

            while (line != null) {
                result.append(line.toUpperCase());
                result.append("\r\n");

                line = reader.readLine();
            }

            FileWriter writer = new FileWriter("resources/allCapital/lines.txt");
            writer.write(result.toString());
            writer.close();
        } catch (FileNotFoundException fnfe) {
            fnfe.printStackTrace();
        } catch (IOException ioex) {
            ioex.printStackTrace();
        }
    }
}
