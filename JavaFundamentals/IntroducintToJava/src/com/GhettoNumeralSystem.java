package com;

import java.util.Scanner;

public class GhettoNumeralSystem {

    public static void main(String[] args) {
        char[] input = new Scanner(System.in).nextLine().toCharArray();
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.length; i++) {

            switch (input[i]) {
                case '0':
                    result.append("Gee");
                    break;
                case '1':
                    result.append("Bro");
                    break;
                case '2':
                    result.append("Zuz");
                    break;
                case '3':
                    result.append("Ma");
                    break;
                case '4':
                    result.append("Duh");
                    break;
                case '5':
                    result.append("Yo");
                    break;
                case '6':
                    result.append("Dis");
                    break;
                case '7':
                    result.append("Hood");
                    break;
                case '8':
                    result.append("Jam");
                    break;
                case '9':
                    result.append("Mack");
                    break;
                default:
                    System.out.println("The given character is not a valid digit.");
                    break;
            }

        }

        System.out.println(result);
    }
}
