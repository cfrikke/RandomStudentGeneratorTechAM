public class Program {
    public static void Main(){
        Random rnd = new();
        StudentList StudentList = new();
        int r;
        bool continuing = true;
        while(continuing){
        int x = 1;
        Console.Clear();
        for(int i = 0; i < 100; i++){
            r = rnd.Next(0, 38); 
            Console.Clear();
            Console.WriteLine(StudentList[r]);
            Thread.Sleep(x);
            x += i/20;
        }
        Console.WriteLine("Enter: Regenerate Name\nBackspace: Exit");
        int c = Console.ReadKey().KeyChar;
        switch (c)
        {
          case 08:
          continuing = false;
          break;
          case 13: 
          continuing = true;
          break;
        }
        Thread.Sleep(100);
    }

    }

}