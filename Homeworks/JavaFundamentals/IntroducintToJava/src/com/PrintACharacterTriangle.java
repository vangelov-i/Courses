package com;

import java.util.Scanner;

public class PrintACharacterTriangle {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int b = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < b * 2 - 1; i++) {
            if (i < b) {
                for (int j = 'a'; j <= 'a' + i; j++) {
                    System.out.print((char) j + " ");
                }
            } else {
                for (int j = 'a'; j < 'a' + b*2 - 1 - i; j++) {
                    System.out.print((char) j + " ");
                }
            }

            System.out.println();
        }
    }
}