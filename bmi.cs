static void Main(string[] args)
        {
            double weight;
            double height;
            double bmi;
            double fheight;

            Console.Write("enter weight(kgs) :");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter height(meters): ");
            height = Convert.ToDouble(Console.ReadLine());
            fheight = height * height;
            bmi = weight/ fheight;
            if (bmi >=30)
            {
                Console.WriteLine("your bmi is :" + bmi);
                Console.WriteLine("you are obese");
                Console.ReadLine();

            }
            if (bmi < 30 & bmi >= 25)
            {
                Console.WriteLine("your bmi is :" + bmi);
                Console.WriteLine("you are overweight");
                Console.ReadLine();
            }

            if(bmi <25 & bmi >= 18.5)
            {
                Console.WriteLine("your bmi is :" + bmi);
                Console.WriteLine("you are normal"); 
                   
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("your bmi is :" + bmi);
                Console.WriteLine("you are: underweight");
                Console.ReadLine();
            }