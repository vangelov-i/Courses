package com;

import sun.plugin2.message.Message;

import java.util.Scanner;

public class GetAverage {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double a = Double.parseDouble(scanner.nextLine());
        double b = Double.parseDouble(scanner.nextLine());
        double c = Double.parseDouble(scanner.nextLine());

        Double average = getAvarege(a, b, c);
        System.out.printf("Avarege: %.2f", average);
    }

    public static double getAvarege(double a, double b, double c) {
        double sum = a + b + c;
        double avarege = sum / 3;

        return avarege;
    }
}
