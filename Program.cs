public class Program {
    public static void Main(){
        Random rand = new();
        StudentList StudentList = new();
        int r;
        Console.Clear();
        for(int i = 0; i > 10; i++){
            r = rand.Next(0, 39); 
            Console.Clear();
            Console.Write(StudentList.Students[r]);
            Thread.Sleep(100);
        }
    }
}
