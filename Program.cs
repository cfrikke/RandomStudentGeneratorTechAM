public class Program {
    public static void Main(){
        Random rnd = new Random();
        StudentList StudentList = new StudentList();
        int r;
        int x = 1;
        Console.Clear();
        for(int i = 0; i < 100; i++){
            r = rnd.Next(0, 38); 
            Console.Clear();
            Console.WriteLine(StudentList[r]);
            Thread.Sleep(x);
            x += i/20;
        }
    }
}
