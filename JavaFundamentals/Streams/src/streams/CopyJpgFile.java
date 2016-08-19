package streams;

import java.io.*;

public class CopyJpgFile {
    public static void main(String[] args) {
        try (BufferedInputStream inputStream = new BufferedInputStream(
                new FileInputStream("resources/MagicianLumpy.jpg"));
             BufferedOutputStream outputStream = new BufferedOutputStream(
                     new FileOutputStream("resources/MagicianLumpyCopy.jpg"))
        ) {
            int bytes = inputStream.read();
            while (bytes != -1) {
                outputStream.write(bytes);

                bytes = inputStream.read();
            }
        } catch (FileNotFoundException fnfe) {
            fnfe.printStackTrace();
        } catch (IOException ioex) {
            System.err.println("Cannot open .jpeg file.");
        }
    }
}
