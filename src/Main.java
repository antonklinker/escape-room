import java.util.Arrays;
import java.util.Scanner;
import java.util.Random;
public class Main {
    public static void main(String[] args) {

        System.out.println("0 = _");
        System.out.println("1 = ._");
        System.out.println("2 = .._");
        System.out.println("3 = ..._");
        System.out.println("4 = ...._");
        System.out.println("5 = .");
        System.out.println("6 = _....");
        System.out.println("7 = _...");
        System.out.println("8 = _..");
        System.out.println("9 = _.");

        morseCodeGenerator();


    }

    public static void morseCodeGenerator() {
        Random random = new Random();
        Scanner scanner = new Scanner(System.in);


        // HELP:           0     1     2      3       4       5      6        7      8     9
        String[] morse = {"_", "._", ".._", "..._", "...._", ".", "_....", "_...", "_..", "_."};

        String[] numbers = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

        String[] code = new String[4];
        String[] codeInNumbers = new String[4];
        String[] guess = {"0", "0", "0", "0"};

        while (!Arrays.equals(guess, codeInNumbers)) {
            for (int i = 0; i < code.length; i++) {
                int rand = random.nextInt(10);
                code[i] = morse[rand];
                codeInNumbers[i] = numbers[rand];
            }
            System.out.println("\nThis is the morse combination. Write one number at a time and then press enter.");
            System.out.println(Arrays.toString(code));

            for (int i = 0; i < codeInNumbers.length; i++) {
                guess[i] = scanner.nextLine();
            }

            if (Arrays.equals(guess, codeInNumbers)) {
                System.out.println("You guessed the combination: " + Arrays.toString(codeInNumbers) +"! Congratulations");
            } else {
                System.out.println("That was not correct. The correct combination is: " + Arrays.toString(codeInNumbers));
            }
        }


    }
}
