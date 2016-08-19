package com;

import java.util.Scanner;

public class SumNumbers1ToN {
    public static void main(String[] args) {
        long n = Long.parseLong(new Scanner(System.in).nextLine());

        long sum = 0;

        for (int i = 1; i <= n; i++) {
            sum += i;
        }

        System.out.println(sum);
    }
}
