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

        System.out.println("Write anything to continue");

        morseCodeGenerator();


    }

    public static void morseCodeGenerator() {
        Random random = new Random();
        Scanner scanner = new Scanner(System.in);



        String[] morse = {"_", "._", ".._", "..._", "...._", ".", "_....", "_...", "_..", "_."};

        String[] numbers = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

        String[] code = new String[4];
        String guess = scanner.nextLine();

        while (!guess.equals(code)) {
            for (int i = 0; i < code.length; i++) {
                code[i] = morse[random.nextInt(10)];
                if (guess.equals(code[i])) {
                    System.out.println("Nice!");
                }

            }
            System.out.println(Arrays.toString(code));

        }


    }
}
