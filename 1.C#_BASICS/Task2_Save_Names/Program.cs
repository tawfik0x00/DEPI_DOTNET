namespace Task2
{
    class Student
    {
        public string name;
        public int[] grads = new int[4];
    }
    class Program
    {
        public static void Main()
        {
            // 01- we have a simple system to store names of students only so foreach group we take the Number from user then store their names in our system implement this part as a c# program 
            Console.Write("Please Enter the number of students you want to add: ");
            int std_size = int.Parse(Console.ReadLine());

            Student[] stds = new Student[std_size];

            for (int i = 0; i < std_size; i++)
            {
                Console.Write($"Enter Sudent name number {i + 1}: ");
                stds[i] = new Student();
                stds[i].name = Console.ReadLine();

                int sum = 0;

                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Enter student {i + 1} Grade {j  + 1}: ");
                    stds[i].grads[j] = Convert.ToInt32(Console.ReadLine());
                    sum += stds[i].grads[j];
                }

                Console.WriteLine($"Sum of Grads: {sum}");
            }

        }
    }
}