package streams;

import java.io.*;

public class StreamsExercise {
    public static void main(String[] args) {
        try (
                BufferedReader reader = new BufferedReader(new FileReader("resources/streamsExercise/users.txt"));
                BufferedWriter writer = new BufferedWriter(new FileWriter("resources/streamsExercise/total-played.txt"))
        ) {
            String line = reader.readLine();
            while (line != null) {
                String[] parameters = line.split(" ");

                String name = parameters[0];
                long totalMinutesPlayed = 0L;

                for (int i = 1; i < parameters.length; i++) {
                    String[] timeParameters = parameters[i].split(":");

                    int hours = Integer.parseInt(timeParameters[0]);
                    int minutes = Integer.parseInt(timeParameters[1]);

                    totalMinutesPlayed += hours * 60 + minutes;
                }

                int minutesInSingleDay = 24*60;

                int days = (int)(totalMinutesPlayed / minutesInSingleDay);
                int hours = (int)(totalMinutesPlayed % minutesInSingleDay) / 60;
                int minutes = (int)(totalMinutesPlayed % 60);

                String resultLine = String.format(
                        "%s %d (%d days, %d hours, %d minutes)\r\n",
                        name,
                        totalMinutesPlayed,
                        days,
                        hours,
                        minutes);

                writer.write(resultLine);

                line = reader.readLine();
            }
        } catch (FileNotFoundException fnfe) {
            fnfe.printStackTrace();
        } catch (IOException fnf) {
            fnf.printStackTrace();
        }
    }
}