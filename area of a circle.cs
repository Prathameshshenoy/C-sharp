 static void Main(string[] args)
        {
            double area;
            double radius;
            double circumference;
            Console.WriteLine("radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = Convert.ToDouble( 3.14 * (radius * radius));
            circumference = 2 * (3.14*radius);
            Console.WriteLine("the circumference is : " + circumference);
          
            Console.WriteLine("the area is: " + area);


        }
        
        
        