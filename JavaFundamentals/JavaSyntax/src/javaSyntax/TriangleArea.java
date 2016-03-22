package javaSyntax;

import java.util.Scanner;

public class TriangleArea {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double aX = scanner.nextDouble();
        double aY = scanner.nextDouble();

        double bX = scanner.nextDouble();
        double bY = scanner.nextDouble();

        double cX = scanner.nextDouble();
        double cY = scanner.nextDouble();

        double sideAB = Math.sqrt(Math.abs(aX-bX)*Math.abs(aX-bX) + Math.abs(aY - bY)*Math.abs(aY - bY));
        double sideBC = Math.sqrt(Math.abs(cX-bX)*Math.abs(cX-bX) + Math.abs(cY - bY)*Math.abs(cY - bY));
        double sideAC = Math.sqrt(Math.abs(aX-cX)*Math.abs(aX-cX) + Math.abs(aY - cY)*Math.abs(aY - cY));

        double halfPerimeter = (sideAB + sideBC + sideAC) / 2;

        double area = Math.sqrt(
                halfPerimeter*
                        (halfPerimeter-sideAB)*
                        (halfPerimeter-sideBC)*
                        (halfPerimeter-sideAC));

        System.out.println(Math.round(area));
    }
}
