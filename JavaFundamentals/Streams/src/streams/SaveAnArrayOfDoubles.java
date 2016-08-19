package streams;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class SaveAnArrayOfDoubles {
    public static void main(String[] args) {
        List<Double> doubles = new ArrayList<>();
        doubles.add(1.1);
        doubles.add(2.2);
        doubles.add(3.3);
        doubles.add(4.4);
        doubles.add(5.5);

        try (
                ObjectOutputStream objectWriter =
                        new ObjectOutputStream(
                                new BufferedOutputStream(
                                        new FileOutputStream("resources/doubles.list")))
        ) {
            for (Double number : doubles) {
                objectWriter.writeDouble(number);
            }

            objectWriter.close();

            ObjectInputStream objectReader =
                    new ObjectInputStream(
                            new BufferedInputStream(
                                    new FileInputStream("resources/doubles.list")));

            for (int i = 0; i < doubles.size(); i++) {
                System.out.println(objectReader.readDouble());
            }

            objectReader.close();
        } catch (FileNotFoundException fnfe) {
            fnfe.printStackTrace();
        } catch (IOException ioex) {
            ioex.printStackTrace();
        }
    }
}
